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

            double hip1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double hip2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            Console.WriteLine(GetDistance(x1, y1, x2, y2));



            //  double xdiff = Math.Abs(x1 - x2);
            //  double ydiff = Math.Abs(y1 - y2);
            //
            //  if (xdiff <= ydiff)
            //  {
            //      if (Math.Abs(x1-0) <= Math.Abs(x2- 0))
            //      {
            //          Console.WriteLine($"({x1}, {y1}");
            //      }
            //      else
            //      {
            //          Console.WriteLine($"({x2}, {y2}");
            //      }
            //  }
            //  else
            //      if (Math.Abs(y1 - 0) <= Math.Abs(y2 - 0))
            //  {
            //      Console.WriteLine($"({x1}, {y1})");
            //  }
            //       else
            //  {
            //      Console.WriteLine($"({x2}, {y2})");
            //  }


        }

        public static string GetDistance (double x1, double y1, double x2, double y2)
        {
            double hip1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double hip2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (hip1 < hip2)
            {
                return ($"({x1}, {y1})");
            }
            else
            {
                return ($"({x2}, {y2})");
            }
        }
    }
}
