using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SieveofEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            List<int> primeNumbers = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                primeNumbers.Add(i);
            }
            Console.WriteLine(string.Join(" ", FindPrimeNumbers(primeNumbers)));
            

        }

        public static List<int> FindPrimeNumbers(List<int> listtocheck)
        {
            int isPrime = 2;
            int position = 0;
            while (isPrime <= listtocheck.Count)
            {
                for (int i = 2; i <= listtocheck.Count; i++)
                {
                    if (listtocheck.Contains(isPrime * i)) listtocheck.Remove(isPrime * i);
                }
                position++;
                isPrime = listtocheck[position];
            }
            return listtocheck;
        }
    }
}
