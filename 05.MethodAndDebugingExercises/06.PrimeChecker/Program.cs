using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(input));
        }

        public static bool isPrime(double number)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            var boundary = (int)(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

