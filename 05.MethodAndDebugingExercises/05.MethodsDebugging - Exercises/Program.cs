using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MethodsDebugging___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);

        }

        public static void PrintGreeting (string input)
        {
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}
