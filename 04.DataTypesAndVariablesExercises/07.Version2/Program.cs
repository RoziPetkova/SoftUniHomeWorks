using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Version2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            double maxValue = FindMaxValue(dataType);

            sbyte numberOfThies = sbyte.Parse(Console.ReadLine());
            long bestMach = FindMinValue(dataType);

            for (int i = 0; i < numberOfThies; i++)
            {
                long thiefID = long.Parse(Console.ReadLine());
                if (thiefID > bestMach && thiefID <= maxValue) bestMach = thiefID;
            }

            double sentance = 0;
            if (bestMach < 0)
                sentance = Math.Ceiling((double)bestMach / sbyte.MinValue);

            else if (bestMach >= 0)
                sentance = Math.Ceiling((double)bestMach / sbyte.MaxValue);

            string years = sentance > 1 ? "years" : "year";
            Console.WriteLine("Prisoner with id {0} is sentenced to {1} {2}", bestMach, sentance, years);


        }

        public static double FindMaxValue(string dataType)
        {
            double maxValue = dataType.Equals("sbyte") ? sbyte.MaxValue :
                              dataType.Equals("int") ? int.MaxValue :
                              dataType.Equals("long") ? long.MaxValue : 0;

            return maxValue;
        }

        public static long FindMinValue(string dataType)
        {
            long minValue = dataType.Equals("sbyte") ? sbyte.MinValue :
                              dataType.Equals("int") ? int.MinValue :
                              dataType.Equals("long") ? long.MinValue : 0;
            return minValue;
        }
    }

}

