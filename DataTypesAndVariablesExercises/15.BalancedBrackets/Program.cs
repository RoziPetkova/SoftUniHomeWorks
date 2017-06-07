using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)

        {
            int input = int.Parse(Console.ReadLine());

            string checker = "";
            for (int i = 0; i < input; i++)
            {
                string strToCheck = Console.ReadLine();
                if (strToCheck == "(" || strToCheck == ")") checker = checker + strToCheck;                
            }

            int countOpening = 0;
            for (int i = 0; i < checker.Length; i++)
            { if(checker[i] == '(') countOpening++; }

            int countClosing = 0;
            for (int i = 0; i < checker.Length ; i++)
            { if(checker[i] == ')') countClosing++; }

            if (countClosing == countOpening && checker[checker.Length-1].Equals(")"))
            {
                Console.WriteLine("BALANCED");
            }
            else Console.WriteLine("UNBALANCED");
        }
    }
}
