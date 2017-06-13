using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            int separator = input.Length / 4;


            List<int> firstRow1 = new List<int>();
            List<int> firstRow2 = new List<int>();
            List<int> secondRow = new List<int>();

            for (int i = 1; i <= input.Length; i++)
            {
                if (i <= separator) firstRow1.Add(int.Parse(input[i-1]));
                else if (i > separator * 3) firstRow2.Add(int.Parse(input[i - 1]));
                else secondRow.Add(int.Parse(input[i - 1]));
            }

            firstRow1.Reverse();
            firstRow2.Reverse();
            List<int> firstRow = new List<int>();
            firstRow = firstRow1; firstRow.AddRange(firstRow2);

            int[] sum = new int[separator * 2];
            for (int i = 0; i < separator *2; i++)
            {
                sum[i] = firstRow.ElementAt(i) + secondRow.ElementAt(i);
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
