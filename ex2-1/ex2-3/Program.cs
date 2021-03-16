using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_3
{
    class Program
    {

        public static void getPrime(int length)
        {
            bool[] numbers = new bool[length + 1];
            int aPrime;
            
            for(aPrime = 2;aPrime <=  length; aPrime++)
            {
                if(numbers[aPrime] == false)
                {
                    for(int i = aPrime*2; i <= length; i += aPrime)
                    {
                        numbers[i] = true;
                    }
                    Console.Write($"{aPrime} ");
                }
            }
        }
        static void Main(string[] args)
        {
            int length = 100;

            Console.WriteLine("The prime numbers between 2-100 are as followed:");
            getPrime(length);

            Console.Read();
            
        }
    }
}
