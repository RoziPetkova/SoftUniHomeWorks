using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                long.Parse(input);
                Console.WriteLine("integer");
            }

            catch (Exception)
            {
                try
                {
                    decimal.Parse(input);
                    Console.WriteLine("floating-point");
                }

                catch (Exception)
                {

                }

            }
        }


    }
}

