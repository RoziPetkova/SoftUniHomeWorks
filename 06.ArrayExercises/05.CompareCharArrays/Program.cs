using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();


            List<char> comparedArrays = ComparingArrays(firstArr, secondArr);
            List<char> seconCompareddArr = secondAfterComparing(firstArr, secondArr);

            foreach (char item in comparedArrays)
                Console.Write(item);

            Console.WriteLine();

            foreach (char item in seconCompareddArr)
             Console.Write(item);
        }
        public static List<char> ComparingArrays(char[] firstArr, char[] secondArr)
        {
            int minPositions = Math.Min(firstArr.Length, secondArr.Length);
            int index = 0;
            List<char> arrToReturn = new List<char>();

            while (index < minPositions && firstArr[index] == secondArr[index])
            {
                index++;
                continue;
            }

            if (index == minPositions)
                arrToReturn = minPositions == firstArr.Length ? firstArr.ToList() : secondArr.ToList();
            else if 
                (firstArr[index] != secondArr[index]) arrToReturn = firstArr[index] < secondArr[index] ? firstArr.ToList() : secondArr.ToList();

            return arrToReturn;
        }


        public static List<char> secondAfterComparing(char[] firstArr, char[] secondArr)
        { 
            List<char> arrToReturn = ComparingArrays(firstArr, secondArr).SequenceEqual(firstArr.ToList()) ? 
                secondArr.ToList(): firstArr.ToList();

            return arrToReturn;
        }
    }
}

