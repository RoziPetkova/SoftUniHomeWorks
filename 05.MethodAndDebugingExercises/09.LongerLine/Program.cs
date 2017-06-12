using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double firstLine = GetLenght(x1, y1, x2, y2);
            double secondLine = GetLenght(x3, y3, x4, y4);

            string output = Math.Max(firstLine, secondLine) == firstLine ? GetDistance(x1, y1, x2, y2) : GetDistance(x3, y3, x4, y4);

            Console.WriteLine(output);




        }

        public static double GetLenght(double x1, double y1, double x2, double y2)
        {

            double xSide = Math.Max(x1, x2) - Math.Min(x1, x2);
            double ySide = Math.Max(y1, y2) - Math.Min(y1, y2);


            double hip1 = Math.Sqrt(Math.Pow(xSide, 2) + Math.Pow(ySide, 2));
            return hip1;
        }

        public static string GetDistance(double x1, double y1, double x2, double y2)
        {
            double hip1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double hip2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (hip1 < hip2)
            {
                return ($"({x1}, {y1})") + ($"({x2}, {y2})");
            }
            else
            {
                return ($"({x2}, {y2})") + ($"({x1}, {y1})");
            }
        }
    }
}
