using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int evenOrOdd = Console.ReadLine() == "even" ? 0 : 1;
            byte lineCounter = byte.Parse(Console.ReadLine());


            string toConcatenate = "";
            for (int i = 1; i <= lineCounter; i++)
            {
                if (i % 2 == evenOrOdd)
                {
                    toConcatenate += Console.ReadLine() + delimiter;
                }
                else Console.ReadLine();
            }

            Console.WriteLine(toConcatenate.Remove(toConcatenate.Length - 1));
        }
    }
}
