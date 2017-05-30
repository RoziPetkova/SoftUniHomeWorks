using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            if (groupSize < 120)
                {
                      double hallPrice = groupSize <= 50 ? 2500
                                : (groupSize > 50 && groupSize <= 100 ? 5000
                                : (groupSize > 100 && groupSize <= 120 ? 7500
                                  : 0));
                      string hallName = groupSize <= 50 ? "Small Hall"
                                : (groupSize > 50 && groupSize <= 100 ? "Terrace"
                                : (groupSize > 100 && groupSize <= 120 ? "Great Hall"
                                : ""));

                      double discount = 0;
                      double totalPrice = 0;
                      double packagePrice = 0;

                      switch (package)
                {
                    case "Normal": packagePrice = 500; discount = 0.05; break;
                    case "Gold": packagePrice = 750; discount = 0.10; break;
                    case "Platinum": packagePrice = 1000; discount = 0.15; break;
                }

                totalPrice = (hallPrice + packagePrice - ((hallPrice + packagePrice) * discount)) / groupSize;

                Console.WriteLine("We can offer you the {0} \nThe price per person is {1:0.00}$", hallName, totalPrice);
            }
            else Console.WriteLine("We do not have an appropriate hall.");

        }
    }
}

