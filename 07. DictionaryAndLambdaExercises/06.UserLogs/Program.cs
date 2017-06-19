using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> dataBase = new SortedDictionary<string, Dictionary<string, int>>();

            string line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split(' ');
                string IP = tokens[0].Remove(0, 3);
                string userName = tokens[2].Remove(0, 5);

                if (!dataBase.ContainsKey(userName))
                    dataBase[userName] = new Dictionary<string, int>();
                if (!dataBase[userName].ContainsKey(IP))
                    dataBase[userName][IP] = 0;

                dataBase[userName][IP] += 1;

                line = Console.ReadLine();
            }

            foreach (var key1 in dataBase.Keys)
            {
                Console.WriteLine(key1 + ":");
                var value1 = dataBase[key1];
                bool first = true;
                foreach (var key2 in value1.Keys)
                {
                    if (!first) Console.Write(", ");
                    Console.Write($"{key2} => {value1[key2]}");
                    first = false;
                }
                Console.Write(".");
                Console.WriteLine();
            }
            
        }
    }
}

