using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//                miles	  1.6  	kilometers
//                inches  2.54	centimeters
//                feet    30	centimeters
//                yards   0.91	meters
//                gallons 3.8	liters

     
namespace _04.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            
      //    Dictionary<string, Dictionary<double, string>> dictionary2 = new Dictionary<string, Dictionary<double  , string>>()
      //{
      //    { "miles", new Dictionary <double, string>() { { 1.6, "multiplyBy" }, { 1, "kilometers" } }},
      //     { "inches", new Dictionary <double, string>() { {  2.54,"centimeters" } } } ,
      //     { "feet", new Dictionary <double, string>() { {  30,"centimeters" } } } ,
      //     { "yards", new Dictionary <double, string>() { { 0.91, "meters" } } } ,
      //     { "gallons", new Dictionary <double, string>() { { 3.8, "liters" } } }
      //};

            string initialUnit = Console.ReadLine();
            double initialValue = double.Parse(Console.ReadLine());

            double multiplyBy = initialUnit.Equals("miles") ? 1.6 :
                                initialUnit.Equals("inches") ? 2.54 :
                                initialUnit.Equals("feet") ? 30 :
                                initialUnit.Equals("yards") ? 0.91 :
                                initialUnit.Equals("gallons") ? 3.8 : 0;


            string outputUnit = initialUnit.Equals("miles") ? "kilometers" :
                                initialUnit.Equals("inches") ? "centimeters" :
                                initialUnit.Equals("feet") ? "centimeters" :
                                initialUnit.Equals("yards") ? "meters" :
                                initialUnit.Equals("gallons") ? "liters" : "";

            Console.WriteLine($"{initialValue} {initialUnit} = {initialValue * multiplyBy:0.00} {outputUnit}");
        }


       
    }

}


