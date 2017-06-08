using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(FibSum(input));
        }


        public static long FibSum(int number)
        {
            long a = 1;
            long b= 0;
           
            int i = 0;
            for ( i = 0; i <= number; i++)
            {
                long temporaryA = a;
                a = b;
                b = temporaryA + b;                       
            }
            return b;
        }
    }
}
