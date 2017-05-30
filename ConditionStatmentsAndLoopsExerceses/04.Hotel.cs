using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double doublePrice = 0;
            double SuitePrice = 0;
            double totalPriceD = nights * doublePrice;
            double totalPriceStudio = nights * studioPrice;
            double totalPriceSuite = nights * SuitePrice;



            switch (month)
            { case "May" :                        
                case "October": studioPrice = 50; doublePrice = 65; SuitePrice = 75;
                    if (nights > 7 ) studioPrice = studioPrice - (studioPrice * 0.05);
                    totalPriceD = nights * doublePrice;
                    totalPriceStudio = nights * studioPrice;
                    totalPriceSuite = nights * SuitePrice;
                    if (month == "October" && nights > 7) totalPriceStudio = (nights - 1) * studioPrice;
                    break;
                case "June":
                case "September": studioPrice = 60; doublePrice = 72; SuitePrice = 82;
                    
                    if (nights > 14) doublePrice = doublePrice - (doublePrice * 0.10);
                    totalPriceD = nights * doublePrice;
                    totalPriceStudio = nights * studioPrice;
                    totalPriceSuite = nights * SuitePrice;
                    if ( month == "September" && nights > 7) totalPriceStudio = (nights - 1) * studioPrice;
                    break;
                default: studioPrice = 68; doublePrice = 77; SuitePrice = 89;
                    if (nights > 14)
                    {
                        SuitePrice = SuitePrice - (SuitePrice * 0.15);
                    }
                        
                    totalPriceSuite = nights * SuitePrice; 
                    totalPriceD = nights * doublePrice;
                    totalPriceStudio = nights * studioPrice;
                break; }
          

            Console.WriteLine("Studio: {0:0.00} lv.", totalPriceStudio);
            Console.WriteLine("Double: {0:0.00} lv.", totalPriceD);
            Console.WriteLine("Suite: {0:0.00} lv.", totalPriceSuite);


        }
    }
}
