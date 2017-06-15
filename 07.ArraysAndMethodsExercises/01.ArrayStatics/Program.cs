using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndMethodsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                        Split(' ').
                        Select(int.Parse).
                        ToArray();

            int maxNumer = int.MinValue;
            int minNumber = int.MaxValue;
            long sum = 0;
            
            int counter = 0;                 
            while (counter < arr.Length)
            {
                sum = sum + arr[counter];               
                maxNumer = maxNumer < arr[counter] ? arr[counter] : maxNumer;
                minNumber = minNumber > arr[counter] ? arr[counter] : minNumber;
                counter++;
            }

            double averageValue = 1.0;
            averageValue = (double)sum / arr.Length;
            Console.WriteLine($"Min = {minNumber}"
                            + $"\nMax = {maxNumer}"
                            + $"\nSum = {sum}"
                            + $"\nAverage = {averageValue}");
        }
    }
}
