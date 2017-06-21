using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Reverse
// Distinct
// Replace


namespace ManipilateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().
                                    Split(' ').
                                    ToList();

            // int numberComands = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> tokens = Console.ReadLine().
                                    Split(' ').
                                    ToList();
               string commands = tokens[0];

                if (commands == "END") break;
                switch (commands)
                {
                    case "Reverse":
                        strings.Reverse(); break;
                    case "Distinct":
                       strings = strings.Distinct().ToList(); break;
                    case "Replace":
                        int position = int.Parse(tokens[1]);
                        string newInput = tokens[2];
                        if(position < 0 || position >= strings.Count())
                        {
                            Console.WriteLine("Invalid input!");
                            break;
                        }
                        strings[position] = newInput;
                        break;
                    default: Console.WriteLine("Invalid input!");
                        break;
                }
              //  if (i > 10) break;
            }
                    Console.Write(string.Join(", ", strings));
              
        }
    }
}
