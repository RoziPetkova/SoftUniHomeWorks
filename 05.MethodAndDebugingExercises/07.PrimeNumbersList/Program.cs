using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimeNumbersList
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine()); 
            int secondNum = int.Parse(Console.ReadLine());

            List<int> PrimesInRange = new List<int>();
            for (int i = firstNum; i <= secondNum; i++)
            {
                if (isPrime(i)) PrimesInRange.Add(i);
            }


            for (int item = 0; item <= PrimesInRange.Count-1; item++)
            {
                Console.Write(PrimesInRange[item]);
                if (item == PrimesInRange.Count - 1) break;
                Console.Write(", ");
            }
            

        }

        public static bool isPrime(double number, int num1 = 2)
        {
            if (number == 1 || number == 0) return false;
            if (number == 2) return true;

            var boundary = (int)(Math.Sqrt(number));

            for (num1 = 2; num1 <= boundary; ++num1)
            {
                if (number % num1 == 0) return false;
            }

            return true;
        }
    }
}
