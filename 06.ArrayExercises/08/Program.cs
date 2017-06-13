using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (var currentNumber in arr)
            {
                if (!map.ContainsKey(currentNumber))
                    map.Add(currentNumber, 0);

                map[currentNumber]++;
            }

            int biggestVal = int.MinValue;
            int biggestKey = int.MinValue;

            foreach (var element in map)
                if (element.Value > biggestVal)
                {
                    biggestKey = element.Key;
                    biggestVal = element.Value;
                }

            Console.WriteLine(biggestKey);
        //   int currentNumber = 0;
        //   int mostFrequentNum = 0;
        //   int currentcounter = 0;
        //   int counter = 0;
        //
        //   foreach (var currentNumber in arr)
        //   {
        //       for (int i = 0; i < arr.Length; i++)
        //       {
        //           if (i == currentNumber) counter++;
        //       }
        //
        //       if (currentcounter > counter) mostFrequentNum = currentNumber;
        //   }

        }
    }
}
