using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {

            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(GetLAstDigit(input));

        }

        public static string GetLAstDigit (long number)
        {
            long lastDigit = Math.Abs(number % 10);
            string lastDigitInSring = lastDigit == 1 ? "one" :
                                      lastDigit == 2 ? "two" :
                                      lastDigit == 3 ? "three" :
                                      lastDigit == 4 ? "four" :
                                      lastDigit == 5 ? "five" :
                                      lastDigit == 6 ? "six" :
                                      lastDigit == 7 ? "seven" :
                                      lastDigit == 8 ? "eight" :
                                      lastDigit == 9 ? "nine" : "zero";
      
            return lastDigitInSring;
        }

     //  public static string GetLAstdNum(string input)
     //  {
     //      string newStr = "";
     //      newStr = newStr + input[input.Length-1];
     //       long lastDigit = number % 10;
     //         string lastDigitInSring = lastDigit == 1 ? "one" :  
     //                                   lastDigit == 2 ? "two" :
     //                                   lastDigit == 3 ? "three" :
     //                                   lastDigit == 4 ? "four" :
     //                                   lastDigit == 5 ? "five" :
     //                                   lastDigit == 6 ? "six" :
     //                                   lastDigit == 7 ? "seven" :
     //                                   lastDigit == 8 ? "eight" :
     //                                   lastDigit == 9 ? "nine" : "zero";
     //      return newStr;
        }
    }


