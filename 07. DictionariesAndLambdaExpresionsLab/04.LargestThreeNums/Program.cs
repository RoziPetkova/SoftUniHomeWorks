using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LargestThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().
                            Split(' ').
                            Select(double.Parse).
                            ToList();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending (x => x).Take(3)));
        }
    }
}
