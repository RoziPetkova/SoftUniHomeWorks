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
            List<long> quantities = Console.ReadLine().
                                Split(' ').
                                Select(long.Parse).
                                ToList();
            double[] prices = Console.ReadLine().
                                Split(' ').
                                Select(double.Parse).
                                ToArray();

            quantities = AddItemsToList(quantities, products);
            
            Dictionary<string, Tuple<long, double>> hashMap = new Dictionary<string, Tuple<long, double>>();
            for (int i = 0; i < products.Length; i++)
                    hashMap.Add(products[i], new Tuple<long, double>(quantities[i], prices[i]));


              

            PrintingResults(hashMap);

           
        }
        public static void PrintingResults(Dictionary<string, Tuple<long, double>> hashMap)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string productName = input[0];                          
                if (productName == "done")  break; 
                
                long wantedQuantiti = long.Parse(input[1]);
                long nowWeHave = hashMap[productName].Item1 - wantedQuantiti;
                hashMap[productName].Item1 = nowWeHave;
                   if (hashMap[productName].Item1 == 0)
                {
                    Console.WriteLine($"We do not have enough {productName}");
                }
                else
                    Console.WriteLine($"{productName} x {wantedQuantiti} costs {wantedQuantiti * hashMap[productName].Item2:f2}");
                
                    
            }
        }

        public static List<long> AddItemsToList (List<long> quantities, string[] products )
            {
            while (quantities.Count!= products.Length)
                {
                quantities.Add(0);
                }
            return quantities;
            }
    }

}
