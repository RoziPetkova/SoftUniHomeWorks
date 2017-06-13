using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> abc = new Dictionary<char, int>();
            List<char> inchars = Console.ReadLine().ToList();

            int counter = 0;
            for (char ch = 'a'; ch <= 'z'; ch++, counter++)
            {
                if (!abc.ContainsKey(ch))
                {
                    abc.Add(ch, counter);
                }
            }

            foreach (char ch in inchars)
            {
                int toPrint = abc[ch];
                Console.WriteLine("{0} -> {1}", ch, toPrint);
            }


        }
    }
}

