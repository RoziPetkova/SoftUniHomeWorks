using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nLines = byte.Parse(Console.ReadLine());

            int sum = 0;
            while (nLines > 0)
            {
                sum = char.Parse(Console.ReadLine());
                nLines--;
            }

            Console.WriteLine(sum);
        }
    }
}
