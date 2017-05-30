using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ThriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string num2 = "";

            for (int i = 1; i <= num1; i++)
            {
                num2 = "";
                for (int j = 1; j <= i; j++)
                {
                    num2 = num2 + " " + i; 
                }
                
                Console.WriteLine(num2);
            }


        }
    }
}
