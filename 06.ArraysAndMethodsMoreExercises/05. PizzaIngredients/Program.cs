using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allIngredients = Console.ReadLine().
                                        Split(' ').
                                        ToArray();
            int ingLenght = int.Parse(Console.ReadLine());


            int counter = 0;
            List<string> pizzaIng = new List<string>();
            foreach (string ing in allIngredients)
            {
                if (ing.Length == ingLenght)
                {
                    Console.WriteLine($"Adding {ing}.");
                    pizzaIng.Add(ing);
                    counter++;
                }
            }

            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", pizzaIng)}.");
        }
    }
}
