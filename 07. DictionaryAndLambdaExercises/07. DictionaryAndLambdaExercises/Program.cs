using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DictionaryAndLambdaExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dataBase = new Dictionary<string, string>();

            while (true)
            {
                List<string> input = Console.ReadLine().
                                  Split(' ').
                                  ToList();

                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "A")
                {
                    dataBase[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    SearchInDictionary(dataBase, input[1]);
                }
            }           
        }

        public static void SearchInDictionary(Dictionary<string, string> dataBase, string name)
        {
            if (dataBase.ContainsKey(name))
                Console.WriteLine($"{name} -> {dataBase[name]}");
            else
                Console.WriteLine($"Contact {name} does not exist.");

        }
    }
}
