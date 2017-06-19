using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PhoneBookUpdate
{
    class Program
    {
        static void Main(string[] args)
        {

           SortedDictionary<string, string> dataBase = new SortedDictionary<string, string>();

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
                else if (input[0] == "ListAll")
                {
                    foreach (var item in dataBase)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                   
                }
            }
        }

        public static void SearchInDictionary(SortedDictionary<string, string> dataBase, string name)
        {
            if (dataBase.ContainsKey(name))
                Console.WriteLine($"{name} -> {dataBase[name]}");
            else
                Console.WriteLine($"Contact {name} does not exist.");

        }
    }
}
