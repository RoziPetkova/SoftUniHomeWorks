using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DictionariesAndLambdaMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> time = Console.ReadLine()
                                .Split(' ')
                                .ToList();

            List<DateTime> istOfTimes = time.Select(x => DateTime.ParseExact(x, "HH:mm", CultureInfo.InvariantCulture)).ToList();
            
            
            string format = "HH:mm";
            bool isFirst = true;

            foreach (var item in istOfTimes.OrderBy(x => x))
            {
                string separator = isFirst == false ? ", " : null;
                Console.Write(separator  + item.ToString(format));
                isFirst = false;
            }
                                  
        }
    }
}
