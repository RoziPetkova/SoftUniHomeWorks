using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ArrayExercises
{
    //ssss aaaa gggg ffff hhhh 
    //sasa dssd ffff hhhh

    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondtArr = Console.ReadLine().Split(' ');

            int smallerArr = Math.Min(firstArr.Length, secondtArr.Length);
      
            // left to right
            int leftcommonParts = 0;
            for (int i = 0; i < smallerArr; i++)
            {
               if (firstArr[i] == secondtArr[i]) leftcommonParts++;
               if (firstArr[i] != secondtArr[i]) break;
            }

            // right to left
            int rightcommonParts = 0;
            for (int i = 0; i < smallerArr -1; i ++)
            {
                if (firstArr[firstArr.Length-1-i] == secondtArr[secondtArr.Length-i-1]) rightcommonParts++;
                if (firstArr[firstArr.Length-i-1] != secondtArr[secondtArr.Length - i - 1]) break;
            }


            Console.WriteLine(Math.Max(leftcommonParts, rightcommonParts));

        }
    }
}

