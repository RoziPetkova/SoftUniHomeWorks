using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
             char first = Char.Parse(Console.ReadLine());
             char second = Char.Parse(Console.ReadLine());
             char third = Char.Parse(Console.ReadLine());

            string newStr = "";

            for (char i = first; i <= second; i++)
            {
              for (char i2 = first; i2 <= second; i2++)
                {
                    for (char i3 = first; i3 <= second; i3++)
                    {
                        newStr = i.ToString() + i2.ToString() + i3.ToString();
                      if(newStr.Contains(third))
                            { continue; }
                        Console.Write(newStr+" ");
                    }
                }
            }          
        }
    }
}
