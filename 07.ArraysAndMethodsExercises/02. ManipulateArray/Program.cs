using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {

            List <int> list = Console.ReadLine().
                        Split(' ').
                        Select(int.Parse).
                        ToList();
            int num = int.Parse(Console.ReadLine());

            List<int> list2 = GetDigitsFromLastToFist(list, num);


            if (list2.Count != 0)
            {
                long sum = 0;
                for (int i = 0; i < list2.Count; i++)
                {
                    sum += list2[i];
                }
                Console.WriteLine(sum);
            }

            else Console.WriteLine("No occurrences were found!");
            
        }

        public static List<int> GetDigitsFromLastToFist(List<int> list, int num)
        {
            List<int> result = new List<int>();
            for (int i = list.Count-1; i >=0; i--)
            {
                if (num == list[i])
                {
                    result = list.GetRange(0, i);
                    break;
                }
            }
            return result;
        }
    }
}
