using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)

        {
            //– cheese 500, tomato sauce 150, salami600 and pepper50
            int n = int.Parse(Console.ReadLine());
            double cal = 0;
            double totalCal = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingredients = Console.ReadLine();
                ingredients = ingredients.ToLower();

                switch (ingredients)
                {
                    case "cheese": cal = 500; break;
                    case "tomato sauce": cal = 150; break;
                    case "salami": cal = 600; break;
                    case "pepper": cal = 50; break;
                    default: cal = 0; break;
                }
                totalCal =  totalCal+ cal; 
            }
            Console.WriteLine("Total calories: {0}",totalCal);
           
        }
    }
}
