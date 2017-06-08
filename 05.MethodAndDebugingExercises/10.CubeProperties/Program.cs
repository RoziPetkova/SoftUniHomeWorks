using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            string searchfor = Console.ReadLine();
            Console.WriteLine("{0:F2}", GetCubeProperty(searchfor, input));

        }
        // (face, space, volume or area).

        public static double GetCubeProperty (string whatIwantToCalc, double side)
        {
            if (whatIwantToCalc == "face") return GetFaceDiagonal(side);
            else if(whatIwantToCalc == "space") return GetSpaceDiagonal(side);
            else if(whatIwantToCalc == "volume") return GetVolume(side);
            else return GetSurfaceArea(side);            
        }


        public static double GetFaceDiagonal (double side)
        {
            return Math.Sqrt( 2 * (side * side));
        }
        public static double GetSpaceDiagonal (double side)
        {
            return Math.Sqrt(3 * (side * side));
        }
        public static double GetVolume(double side)
        {
            return (side*side*side);
        }
        public static double GetSurfaceArea (double side)
        {
            return 6 * (side * side);
        }
    }
}
