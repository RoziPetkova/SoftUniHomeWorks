using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.DecryptingMessages
{
    class Program
    {
        static void Main(string[] args)
        {

            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            string word = "";

            while (numberOfLines > 0)
            {
                char character = char.Parse(Console.ReadLine());
                int symbol = (int)character + key;
                char newSymbol = (char)symbol;

                word += newSymbol.ToString();
                numberOfLines--;
            }

            Console.WriteLine(word);

        }
    }
}
