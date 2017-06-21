using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MakeAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte nLines = byte.Parse(Console.ReadLine());
            //
            //string character = "";
            //string fullstring = "";
            //for (int i = 0; i < nLines; i++)
            //{
            //    character = Console.ReadLine();
            //    fullstring = fullstring + character;
            //
            //}
            //
            //Console.WriteLine("The word is: {0}", fullstring);
            byte wordSize = byte.Parse(Console.ReadLine());
            char[] wordLetters = new char[wordSize];

            for (int i = 0; i < wordSize; i++)
            {
                wordLetters[i] = char.Parse(Console.ReadLine());
            }

            string word = new string(wordLetters);
            Console.WriteLine($"The word is: {word}");
        }
    }
}
