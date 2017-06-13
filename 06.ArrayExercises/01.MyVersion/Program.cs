using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MyVersion
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
            List<string> commondPart = new List<string>();

            // left to right
            int leftcommonParts = 0;
            for (int i = 0; i < smallerArr; i++)
            {
                if (firstArr[i] == secondtArr[i])
                {
                    commondPart.Add(firstArr[i]);
                    leftcommonParts++;
                }
                if (firstArr[i] != secondtArr[i]) break;
            }


            // right to left
            int rightcommonParts = 0;
            for (int i = 0; i < smallerArr - 1; i++)
            {
                if (firstArr[firstArr.Length - 1 - i] == secondtArr[secondtArr.Length - i - 1])
                {
                    commondPart.Add(firstArr[firstArr.Length-i-1]);
                    rightcommonParts++;
                }
                if (firstArr[firstArr.Length - i - 1] != secondtArr[secondtArr.Length - i - 1]) break;
            }


          string str = leftcommonParts > rightcommonParts ? "The largest common end is at the right: "
                                  : rightcommonParts > leftcommonParts ? "The largest common end is at the left: "
                                  : "No common words at the left and right";
          Console.WriteLine(str);
              Console.Write(string.Join(" ", commondPart));
          
        }
    }
}

