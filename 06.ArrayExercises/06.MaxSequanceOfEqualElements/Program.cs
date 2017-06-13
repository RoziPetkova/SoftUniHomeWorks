using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequanceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int number = 0;
            int numberValue = 0;
            int currentnumber = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                currentnumber = arr[i] == arr[i + 1] ? (currentnumber+1) : 0;
                
                if (currentnumber > number)
                {
                    number = currentnumber;
                    numberValue = arr[i];
                }
            }

            while (number +1 > 0)
            { 
                Console.Write(numberValue + " ");
                number--;
            }
          
        }
    }
}
