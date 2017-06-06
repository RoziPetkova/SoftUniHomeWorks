using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DataTypesAndVariables_MoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            GetDateTypeBoundaries(dataType);

        }


        public static void GetDateTypeBoundaries(string dataType)
        {
            string minValue = "";
            string maxValue = "";

            Dictionary<string, Dictionary<string, string>> dictionary =
                new Dictionary<string, Dictionary<string, string>>
                {
                      { "int", new Dictionary<string, string> () {
                          { minValue, int.MinValue.ToString()}, { maxValue, int.MaxValue.ToString()} } },
                      { "uint", new Dictionary<string, string> () {
                          { minValue, uint.MinValue.ToString()}, { maxValue, uint.MaxValue.ToString()} } },
                      { "byte", new Dictionary<string, string> () {
                          { minValue, byte.MinValue.ToString()}, { maxValue, byte.MaxValue.ToString()} } },
                      { "sbyte", new Dictionary<string, string> () {
                         { minValue, sbyte.MinValue.ToString()}, { maxValue, sbyte.MaxValue.ToString()} } },
                      { "long", new Dictionary<string, string> (){
                         { minValue, long.MinValue.ToString()}, { maxValue, long.MaxValue.ToString()} } },
                };
            Console.WriteLine(dictionary[dataType][minValue]);
            Console.WriteLine(dictionary[dataType][maxValue]);
        }
    }
}




