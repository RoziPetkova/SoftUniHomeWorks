using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequanceOfEqualElements
{
    class Program
    // 4 5 1 2 3 4 5
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int maxLenght = 0;
            int currentLenght = 0;
            int index = 0;
            List<int> numberValue = new List<int>();


            for (int i = 1; i < arr.Length; i++)
            {
                currentLenght = arr[i] > arr[i - 1] ? currentLenght + 1 : 0;

                if (currentLenght > maxLenght)
                {
                    maxLenght = currentLenght;
                    index = i - maxLenght;
                }
            }

            for (int i = index; i < index + maxLenght + 1; i++)
            {
                numberValue.Add(arr[i]);
            }

            foreach (int item in numberValue)
            {
                Console.Write(item + " ");
            }
        }
    }
}
