using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());
           GetMasterNumbers(input);
        }

        public static void GetMasterNumbers(int maxValue)
        {
            int i = 100;
            while (i <= maxValue)
            {
                i++;
                if (IsNumSimetric(i) && IsSumOfDigitsDivBySeven(i)
                    && ContainsEvenDigit(i))
                    Console.WriteLine(i);
            }
           
                         
        }

        public static bool IsNumSimetric(long maxValue)
        {
            string firstStr = maxValue.ToString();
            string secondStr = "";
            for (int i = firstStr.Length - 1; i >=0; i--)
            {
                secondStr = secondStr + firstStr[i];
            }

            if (secondStr.Equals(firstStr)) return true;
            else return false;          
        }


        public static bool IsSumOfDigitsDivBySeven(long maxValue)
        {
            int sum = 0;
            while (maxValue != 0)
            {
                sum += (int) maxValue % 10;
                maxValue /= 10;
            }
            if (sum % 7 == 0) return true;
            else return false;
        }

        public static bool ContainsEvenDigit (long maxValue)
        {
            string number = maxValue.ToString();
            for (int i = 0; i < number.Length-1; i++)
            {
               string singleDigit = number[i].ToString();
               double singleNumber = double.Parse(singleDigit);

                if (singleNumber% 2 == 0) return true;
            }

            return false;
        }
    }
}
