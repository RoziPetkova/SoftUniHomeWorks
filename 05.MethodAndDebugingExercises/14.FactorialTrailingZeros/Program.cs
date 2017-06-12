using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeros
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeros(Factorial(n)));


        }
        public static int TrailingZeros (BigInteger num)
        {
            int traillingZeroesCount = 0;
            while (num % 10 == 0)
            {
                num /= 10;
                traillingZeroesCount++;
            }
            return traillingZeroesCount;

        }
        public static BigInteger Factorial (int num)
        {
            if (num == 0) return 1;
            else return num * Factorial(num - 1);
        }
    }
}
