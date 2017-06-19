using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DictionariesAndLambdaExpresionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().
                                Split(' ').
                                Select(double.Parse).
                                ToArray();

            SortedDictionary<double, int> newDictionary = new SortedDictionary<double, int>();

            foreach (var item in numbers)
            {
                if (!newDictionary.ContainsKey(item))
                    newDictionary.Add(item, 0);

                newDictionary[item]++;
                
            }

            foreach (var item in newDictionary.Keys)
            {
                Console.WriteLine($"{item} -> {newDictionary[item]}");
            }
        }
    }
}
