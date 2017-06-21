using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WordsInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();


            string secondWord = PluralWorsd(firstWord);


            Console.WriteLine(secondWord );
      
        }


        public static String PluralWorsd(string firstWord)
        {
            string secondWord = firstWord;
            bool endsWithY = firstWord.EndsWith("y");
            bool endsWithSomeStuff1 = firstWord.EndsWith("ch");
            bool endsWithSomeStuff2 = firstWord.EndsWith("o");
            bool endsWithSomeStuff3 = firstWord.EndsWith("s");
            bool endsWithSomeStuff4 = firstWord.EndsWith("sh");
            bool endsWithSomeStuff5 = firstWord.EndsWith("x");
            bool endsWithSomeStuff6 = firstWord.EndsWith("z");

            if (endsWithY)
            {
                secondWord = firstWord.Remove(firstWord.Length - 1, 1);
                secondWord += "ies";
            }
            else if (endsWithSomeStuff1 || endsWithSomeStuff2 || endsWithSomeStuff3 || endsWithSomeStuff4
                || endsWithSomeStuff5 || endsWithSomeStuff6)
            {
                secondWord = firstWord + "es";
            }
            else { secondWord = firstWord + "s"; }

            return secondWord;
        }
             
    }
}
