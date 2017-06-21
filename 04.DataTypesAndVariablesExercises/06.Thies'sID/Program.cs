using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Thief_sID
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            double maxValue = FindMaxValue(dataType);

            sbyte numberOfThies = sbyte.Parse(Console.ReadLine());
            long bestMach = 0;

            for (int i = 0; i < numberOfThies; i++)
            {
                long thiefID = long.Parse(Console.ReadLine());
                if (thiefID > bestMach && thiefID < maxValue) bestMach = thiefID;
            }


            Console.WriteLine(bestMach);





        }

        public static double FindMaxValue(string dataType)
        {
            double maxValue = dataType.Equals("sbyte") ? sbyte.MaxValue :
                              dataType.Equals("int") ? int.MaxValue :
                              dataType.Equals("long") ? long.MaxValue : 0;

            return maxValue;
        }
    }
}
