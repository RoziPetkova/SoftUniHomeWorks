﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    // ASDA% 50
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().
                         Split(' ').
                         Select(int.Parse).
                         ToArray();

            Dictionary<string, int> prices = new Dictionary<string, int>();
            prices.Add("jewelPrice", arr[0]);
            prices.Add("goldPrice", arr[1]);

            long earnedMoney = 0;
            long spendMobey = 0;

            while (true)                                    {
                string[] imput = Console.ReadLine().
                                  Split(' ').
                                  ToArray();
                if (imput.Contains("Jail")) break;

                earnedMoney =+ SumEarnedMoney(imput, prices["jewelPrice"], prices["goldPrice"]);
                spendMobey =+ SumSpendMoney(imput);
            }

            if (earnedMoney >= spendMobey) Console.WriteLine($"Heists will continue. Total earnings: {earnedMoney - spendMobey}.");
            else Console.WriteLine($"Have to find another job. Lost: {spendMobey - earnedMoney}.");


        }

        private static long SumSpendMoney(string[] imput)
        {
            
            int secondPart = int.Parse(imput[1]);
            long sum = secondPart;
            return sum;
        }

        private static long SumEarnedMoney(string[] imput, int jewelPr, int goldPr)
        {
            long sum = 0;
            string firstPart = imput[0];
            foreach (char character in firstPart)
            {
                sum = character == '%' ? sum + jewelPr :
                      character == '$' ? sum + goldPr: sum + 0;
            }

            return sum;
        }
    }
}
