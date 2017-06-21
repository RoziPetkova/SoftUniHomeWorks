using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumMax = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i  = n; i <=m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                   
                    counter++;
                    sum =(i + j);
                    if (sum == sumMax)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", j, i, sum);
                        break;
                    }
                }
                if (sum == sumMax) { break; }
            }
            if (sum != sumMax)
            {
                Console.WriteLine(" {0} combinations - neither equals {1}", counter, sumMax);
            }
        }
    }
}
