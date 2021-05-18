using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace Homework9
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;

        public string StartURL { get; set; }//起始页面

        Queue<string> pending = new Queue<string>();

        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";

        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";

        public string HostFilter { get; set; }

        public string FileFilter { get; set; }

        /*
        static void Main(string[] args)
        {
            Crawler myCrawler = new Crawler();

            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];

            myCrawler.urls.Add(startUrl, false);//加入初始页面

            new Thread(myCrawler.Crawl).Start();

            Console.ReadLine();
        }
        */

        public void Crawl()
        {
            urls.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);
            //Console.WriteLine("开始爬了");
            while (true)
            {
                string current = null;
                foreach(string url in urls.Keys)//找到一个还没有下载过的链接
                {
                    if ((bool)urls[url]) continue;//已经下载过的不再下载
                    current = url;
                }
                if (current == null || count > 10) break;

                Console.WriteLine("爬行" + current + "页面！");

                string html = Download(current);//下载

                urls[current] = true;
                count++;

                Parse(html,current);//解析，并加入新的链接
            }
            //Console.WriteLine("爬行结束");
        }

        public string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                string fileName = count.ToString();//为啥文件名是count
                File.WriteAllText(fileName, html, Encoding.UTF8);
                //Console.WriteLine($"Current html is {html}.");
                return html;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        //解析并加入新的链接
        //先找到html中的URL
        public void Parse(string html,string pageUrl)
        {
            MatchCollection matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                //strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('#' , '"' , ',' , '>');
                //Console.WriteLine($"Current strRef is {strRef}.");
                string url = match.Groups["url"].Value;
                if (url.Length == 0 || url == "")
                {
                    continue;
                }
                url = FixUrl(url, pageUrl);//转绝对路径
                                           //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(url, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !(bool)urls[url])
                {
                    pending.Enqueue(url);
                    if (urls[url] == null) urls[url] = false;
                }
            }
        }

        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }

    }
}
