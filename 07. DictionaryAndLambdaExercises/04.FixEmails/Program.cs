using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> table = new Dictionary<string, string>();

            string name = Console.ReadLine();
            while (name != "stop")
            {
               string email = Console.ReadLine();

                if (!table.ContainsKey(name))
                    table[name] = email;
                name = Console.ReadLine();
            }

            Dictionary<string, string> result = table
                        .Where(x => !(x.Value.EndsWith("us") || x.Value.EndsWith("uk")))
                         .ToDictionary (x => x.Key, x => x.Value);
                        
                foreach (var resourse in result)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
