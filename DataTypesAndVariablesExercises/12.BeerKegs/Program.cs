using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte nLines = byte.Parse(Console.ReadLine());

            string bigestKeg = "";
            double volume = double.MinValue;
            
            while (nLines > 0)
            {              
                string currentModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double singleKegVolume = Math.PI * radius * radius * height;
                if (singleKegVolume > volume)
                {
                    volume = singleKegVolume;
                    bigestKeg = currentModel;
                }
                nLines--;
            }
            Console.WriteLine(bigestKeg);

        }
    }
}
