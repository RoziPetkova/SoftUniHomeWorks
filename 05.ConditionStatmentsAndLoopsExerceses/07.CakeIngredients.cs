using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= int.MaxValue; i++)
            {
                string ing = Console.ReadLine();
               
                if (ing == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {i} ingredients.");
                    break;
                }
                Console.WriteLine($"Adding ingredient {ing}.");

            }
            

        }
    }
}
