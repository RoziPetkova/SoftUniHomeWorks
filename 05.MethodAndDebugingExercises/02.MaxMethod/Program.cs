using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetBigger (GetBigger(num1, num2), num3));  
                  

        }

        public static int GetBigger(int num1, int num2)
        {
            if (num1 > num2) return num1;
            else return num2;
        }
    }
}
