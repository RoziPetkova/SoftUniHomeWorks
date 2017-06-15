 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoriMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().
                                Split(new[] { ' ' }, 
                                StringSplitOptions.RemoveEmptyEntries).
                                ToArray();
            long[] quantities = Console.ReadLine().
                                Split(' ').
                                Select(long.Parse).
                                ToArray();
            string[] prices = Console.ReadLine().
                                Split(' ').
                                ToArray();
            Dictionary<string, Tuple<long, string>> hashMap = new Dictionary<string, Tuple<long, string>>();

            for (int i = 0; i < products.Length; i++)
                hashMap.Add(products[i], new Tuple<long, string>(quantities[i], prices[i]));

            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "done") break;
                else
                Console.WriteLine($"{input} costs: {hashMap[input].Item2}; Available quantity: {hashMap[input].Item1}");
            }
        }
    }
}
