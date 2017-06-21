using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0
{
    class Program
    {
        static void Main(string[] args)
        {
            const int tankCapacity = 255;
            int lines = int.Parse(Console.ReadLine());

            int waterInTank = 0;
            int singleAdd = 0;

            
            for (int i = 0; i < lines; i++)
            {
                singleAdd = int.Parse(Console.ReadLine());
                 waterInTank += singleAdd;  
                if (waterInTank > tankCapacity)
                {
                    waterInTank = waterInTank - singleAdd;
                    Console.WriteLine("Insufficient capacity!");
                }                
            }
             Console.WriteLine(waterInTank);
        }
    }
}
