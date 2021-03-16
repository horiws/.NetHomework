using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_1
{
    class Program
    {
        static void prime(int x)
        {
            int temp = x;
            ArrayList divisor = new ArrayList();
            bool isEven = false;

            if(x <= 1)
            {
                Console.WriteLine("Please enter a number > 1.");
                return;
            }

            while (temp % 2 == 0)
            {
                temp /= 2;
                isEven = true;  
            }
            
            if (isEven)
            {
                divisor.Add(2);
            }

            for(int i = 3;i <= System.Math.Sqrt(x);i += 2)
            {
                while(temp % i == 0)
                {
                    divisor.Add(i);
                    temp /= i;

                    if(temp == 1)
                    {
                        break;
                    }
                }
            }

            foreach(int i in divisor)
            {
                
                Console.Write($"{i} ");
            }
            
        }
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Please enter a number > 1.");
            num = int.Parse(Console.ReadLine());

            prime(num);

            Console.Read();
        }
    }
}
