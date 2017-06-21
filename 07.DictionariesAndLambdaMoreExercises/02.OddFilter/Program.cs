using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().
                            Split(' ')
                            .Select(int.Parse)
                            .ToList();

            List<int> filteredArr = ints.Where(x => x % 2 == 0)
                              .ToList();



           List<int> result = filteredArr.
                               Select(a => a > filteredArr.Average()? ++a : --a)
                              .ToList();


            Console.WriteLine(string.Join(" ", result));

        }
    }
}
