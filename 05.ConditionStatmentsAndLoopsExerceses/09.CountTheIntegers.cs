using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            try
            {
                for (counter = 0; counter < int.MaxValue; counter++)
                {
                    int num = int.Parse(Console.ReadLine());
                }
                
            }
            catch(Exception ex)  {
                Console.WriteLine(counter);
            }


        }
    }
}
