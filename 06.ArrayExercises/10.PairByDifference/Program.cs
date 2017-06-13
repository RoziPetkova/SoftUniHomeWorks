using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PairByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());

            Dictionary<int, int> trainee = new Dictionary<int, int>();

            int counter = arr.Length - 1;
            while (counter >= 0)
            {
                foreach (int num in arr)
                {
                    if (num + difference == arr[counter]) trainee.Add(num, arr[counter]);
                }

                counter--;
            }

            Console.WriteLine(trainee.Count);
       }
    }
}
