using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the start");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the end");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("the prime numbers are : ");
          
            for (int i = start; i <= end; i++)
            {
                bool isprime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(i==1) continue; 
                if (i==0) continue;
                if (isprime)
                {
                    Console.WriteLine(i);
                }















            }
        }
    }
}