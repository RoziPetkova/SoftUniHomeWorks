using System;
using System.Numerics;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFactorial(input));
        }

        public static BigInteger GetFactorial(int num)
        {
            if (num == 0) return 1;
            else { return num * GetFactorial(num - 1); }
            // BigInteger result = 1;
            // for (int i = 1; i <= num; i++)
            // {
            //     result = result * i;
            // }
            // return result;         }
        }
    }
}

 