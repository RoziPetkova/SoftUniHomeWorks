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
            Dictionary<string, long> table = new Dictionary<string, long>();

            string key = Console.ReadLine();

            while (key != "stop")
            {
                long value = long.Parse(Console.ReadLine());
               
                if (!table.ContainsKey(key))
                     table[key] = value;
                else
                     table[key] += value;
                key = Console.ReadLine();
            }

            foreach (var resourse in table)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
