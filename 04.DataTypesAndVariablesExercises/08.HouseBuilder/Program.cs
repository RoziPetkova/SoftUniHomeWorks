using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstSum = long.Parse(Console.ReadLine());
            long secondtSum = long.Parse(Console.ReadLine());

            long intTotalSum = 0;
            long sbytesTotalSum = 0;

            if (firstSum / 4 < sbyte.MaxValue)
            {
                sbytesTotalSum = firstSum * 4;
                intTotalSum = secondtSum * 10;
            }
            else
            {
                sbytesTotalSum = secondtSum * 4;
                intTotalSum = firstSum * 10;
            }

            Console.WriteLine(sbytesTotalSum + intTotalSum);

        }
    }
}
