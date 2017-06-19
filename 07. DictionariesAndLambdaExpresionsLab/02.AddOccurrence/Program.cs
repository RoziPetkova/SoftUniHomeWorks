using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AddOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().
                            ToLower().
                            Split(' ').
                            ToArray();


            Dictionary<string, int> newDictionary = new Dictionary<string, int>();

            foreach (var item in words)
            {
                if (!newDictionary.ContainsKey(item))
                    newDictionary.Add(item, 1);
                else
                    newDictionary[item]++;
            }


            List<string> counts = newDictionary.Keys.Where(x => newDictionary[x] % 2 != 0).ToList();
           

            Console.WriteLine(string.Join (", ", counts));

        }
    }
}
