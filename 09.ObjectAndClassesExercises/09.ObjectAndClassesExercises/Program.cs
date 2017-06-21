using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//    All days that are Saturday or Sunday.
//    All days that are official holidays in Bulgaria:
//    New Year Eve(1 Jan)
//    Liberation Day(3 March)
//    Worker’s day(1 May)
//    Saint George’s Day(6 May)
//    Saints Cyril and Methodius Day(24 May)
//    Unification Day(6 Sept)
//    Independence Day(22 Sept)
//    National Awakening Day(1 Nov)
//    Christmas(24, 25 and 26 Dec)
//    All days not mentioned above are working and should count.

namespace _09.ObjectAndClassesExercises
{
    class Program
    {
        static void Main(string[] args)
        {
           

            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

          //  List<DateTime> sequance = new List<DateTime>();


            List<DateTime> holyDays = new List<DateTime>()
            { new DateTime (DateTime.Now.Year, 01, 01),
              new DateTime(DateTime.Now.Year, 03, 03 ),
              new DateTime(DateTime.Now.Year, 05, 01),
              new DateTime(DateTime.Now.Year, 05, 06),
              new DateTime(DateTime.Now.Year, 05, 24),
              new DateTime(DateTime.Now.Year, 09, 06),
              new DateTime(DateTime.Now.Year, 09, 22),
              new DateTime(DateTime.Now.Year, 11, 01),
              new DateTime(DateTime.Now.Year, 12, 24),
              new DateTime(DateTime.Now.Year, 12, 25),
              new DateTime(DateTime.Now.Year, 12, 26) };

            int counter = 0;

            List<DateTime> currentList = new List<DateTime>();
            currentList.Add(firstDate);
            DateTime nextDay ; 
            for (DateTime day = firstDate; day <= secondDate; day = nextDay)
            {
                nextDay = day.AddDays(1);
                currentList.Add(nextDay);
            }



            for (int i = 0; i <currentList.Count; i++)
            {
                if (currentList[i].DayOfWeek == "Saturday")
                {

                }
            }


            Console.WriteLine(counter);
            
        }
    }
}
