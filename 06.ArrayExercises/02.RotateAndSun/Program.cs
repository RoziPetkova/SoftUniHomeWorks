using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toRotate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int times = int.Parse(Console.ReadLine());

            int[] sum = new int[toRotate.Length];
            int[] rotated = Rotate(toRotate, times);

            while (times - 1 >= 0)
            {      
                for (int j = 0; j <= sum.Length - 1; j++)
                {
                    sum[j] = sum[j] + rotated[j];
                    
                }
                rotated = Rotate(rotated, times - 2);
                times--;
            }

            Console.Write(string.Join(" ", sum));
        }

        public static int[] Rotate(int[] toRotate, int times)
        {
            int[] rotated = new int[toRotate.Length];

          
                for (int i = 0; i <= toRotate.Length - 1; i++)
                {
                    if (i == 0) { rotated[0] = toRotate[toRotate.Length - 1]; }
                    else { rotated[i] = toRotate[i - 1]; }
                }
            return rotated;
        }
}
}

