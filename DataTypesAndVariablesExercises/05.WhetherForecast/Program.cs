using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WhetherForecast
{
    class Program
    {
        static void Main(string[] args)
        {

            // If the number can fit in sbyte (for C#) or byte (for Java) – the weather will be¬¬ “Sunny”
            // If the numbers can fit in int – the weather will be “Cloudy”
            // If the number fits in long – the weather will be “Windy”
            // If it is floating point number – the weather will be “Rainy”
            

            string wetherNumber = Console.ReadLine();

            try
            {
                sbyte sByte = sbyte.Parse(wetherNumber);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int sByte = int.Parse(wetherNumber);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long sByte = long.Parse(wetherNumber);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal sByte = decimal.Parse(wetherNumber);
                            Console.WriteLine("Rainy");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(":P");
                        }
                    }
                }
            }
        }
    }
}
