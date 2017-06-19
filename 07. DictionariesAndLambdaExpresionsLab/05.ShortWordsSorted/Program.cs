using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        //In SoftUni you can study Java, C#, PHP and JavaScript.
       // JAVA and c# developers graduate in 2-3 years. Go in!
        static void Main(string[] args)
        {
            char[] separators = new char[]{ '.',',',':',';','(',')','[',']',
                                            '\\','\"','\'','/','!','?',' '}; ;

            List<string> fullText = Console.ReadLine().
                                     ToLower().
                                     Split(separators).
                                     ToList();


            Console.WriteLine(string.Join(", ", fullText.Where(x => x.Length < 5).
                                                         Where(x => x != "").
                                                         OrderBy(x => x).
                                                         Distinct()));
        }
    }
}
