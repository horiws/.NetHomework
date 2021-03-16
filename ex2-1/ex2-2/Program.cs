using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int index =0;
            int max = 0;
            int min = 0;
            int sum = 0;
            double average = 0;
            string temp = "";

            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Please enter several numbers and end with #.");
            do
            {
                temp = Console.ReadLine();
                if (temp != "#")
                {
                    num = int.Parse(temp);
                    arrayList.Add(num);
                    index++;
                }               
            } while (temp != "#");

            if (index > 0)
            {
                max = min = (int)arrayList[0];

                foreach (int i in arrayList)
                {
                    if (i > max)
                    {
                        max = i;
                    }
                    if (i < min)
                    {
                        min = i;
                    }
                    sum += i;
                }

                average = (double)sum / index;

                Console.WriteLine($"Among these numbers, the maximum is {max}, minimum is {min}, " +
                    $"average value is {average}, sum is {sum}.");
            }
            else
            {
                Console.WriteLine("You haven't entered any number.");
            }


            Console.Read();

        }
    }
}
