using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                        Split(' ').
                        Select(int.Parse).
                        ToArray();
            int k = arr.Length / 4;

            List<int> firstRow = arr.Take(k).Reverse().ToList();
            firstRow.AddRange(arr.Reverse().Take(k).ToList());
            List<int> secondRow = arr.Skip(k).Take(2 * k).ToList();

            List<int> sumArr = firstRow.Select(( x, index ) => x + secondRow[index]).ToList();

            Console.WriteLine(string.Join(" ", sumArr));

        }
    }
}
