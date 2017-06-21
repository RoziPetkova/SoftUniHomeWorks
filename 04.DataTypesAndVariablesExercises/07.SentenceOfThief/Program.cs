using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SentenceOfThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            sbyte numberOfThiefs = sbyte.Parse(Console.ReadLine());
            double bestMach = FingThiefID(dataType, numberOfThiefs);
            int sentance = (int)CalculateTheSentence(bestMach);
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

        public static double FindMinValue(string dataType)
        {
            double minValue = dataType.Equals("sbyte") ? sbyte.MinValue :
                              dataType.Equals("int") ? int.MinValue :
                              dataType.Equals("long") ? long.MinValue : 0;
            return minValue;
        }

        public static long FingThiefID (string dataType, int numberOfThiefs)
        {
            long bestMach = (long)FindMinValue(dataType);
            long maxValue = (long)FindMaxValue(dataType);
            for (int i = 0; i < numberOfThiefs; i++)
            {
                long thiefID = long.Parse(Console.ReadLine());
                if (thiefID > bestMach && thiefID <= maxValue) bestMach = thiefID;
            }
            return bestMach;
        }

        public static double CalculateTheSentence(double thiefsID)
        {
            double sentance = 0;
            if (thiefsID < 0)
                sentance = Math.Ceiling(thiefsID / sbyte.MinValue);
            
            else if (thiefsID >= 0)
                sentance = Math.Ceiling(thiefsID / sbyte.MaxValue);        

            return Math.Abs(sentance);

        }
    }

}

