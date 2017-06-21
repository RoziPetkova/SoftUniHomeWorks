using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
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
            
           
            int i = n;

            for ( i = n; i >=1 ; i--)
            {
               for (int j = 1; j <=m; j++)
                {
                  
                    counter++;
                    sum = sum + 3* (i * j);
                    if (sum >= sumMax)
                    {
                        Console.WriteLine("{0} combinations\nSum: {1} >= {2}", counter, sum, sumMax);
                        break;
                    }
                }
                if (sum >= sumMax) {break;}
            }
            if (i == 0 && sum < sumMax)
            {
                Console.WriteLine("{0} combinations\nSum: {1}", counter, sum);
            }
        }
    }
}
