using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FiveDifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[] numbers = new int[5];

           if(m>= n + 5)
            { 
                for (int i1 = n; i1 <= m; i1++)
                {
                    for (int i2 = n; i2 <= m; i2++)
                    {
                        for (int i3 = n; i3 <= m; i3++)
                        {
                            for (int i4 = n; i4 <= m; i4++)
                            {
                                for (int i5 = n; i5 <= m; i5++)
                                {
                                    if (n <= i1 && i1 < i2 && i2 < i3 && i3 < i4 && i4 < i5 && i5 <= m)
                                    { Console.WriteLine( "{0} {1} {2} {3} {4}",i1, i2, i3, i4, i5); }
                                }
                            }
                        }
                    } 
                }  
             }
            else { Console.WriteLine("No"); }

        }
    }
}
