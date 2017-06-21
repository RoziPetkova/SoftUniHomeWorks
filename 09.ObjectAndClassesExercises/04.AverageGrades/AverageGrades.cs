using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04.AverageGrades;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            List<Student> listOfStudents = new List<Student>();

            for (int i = 0; i < num; i++)
            {
                Student student = new Student();
                var line = Console.ReadLine().Split(' ');
                student.Name = line[0];
                List<double> allGrades = line.Skip(1)
                                         .Select(double.Parse)
                                         .ToList();
                student.Grades = allGrades;
                listOfStudents.Add(student);
            }


            listOfStudents.OrderBy(x => x.Name)
                           .ThenByDescending(x => x.AverageGRade)
                           .Where(x => x.AverageGRade >= 5.00)
                           .ToList()
                           .ForEach(x => Console.WriteLine("{0} -> {1:f2}", x.Name, x.AverageGRade));
           
        }
    }
}
