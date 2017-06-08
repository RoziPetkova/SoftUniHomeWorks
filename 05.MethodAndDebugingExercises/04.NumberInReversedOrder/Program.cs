using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input =Console.ReadLine();
            string outPut = GetReversedNum(input);
            Console.WriteLine(outPut);
                
        }


        public static string GetReversedNum (string input)
        {
            string newStr = "";

            for (int i = input.Length -1 ; i >=0; i--)
            {
                newStr = newStr + input[i];
            }
            return newStr;            
        }
    }
}
