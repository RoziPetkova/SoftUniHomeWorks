using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            byte numberOfLines = byte.Parse(Console.ReadLine());
            int positionBoat1 = 0;
            int positionBoat2 = 0;


            for (int i = 1; i <= numberOfLines; i++)
            {
                string moves = Console.ReadLine();

                if (moves == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                else
                {
                    if (i % 2 == 1)
                    {
                        positionBoat1 += moves.Length;
                        if (positionBoat1 >= 50) break;
                    }
                    else
                    {
                        positionBoat2 += moves.Length;
                        if (positionBoat2 >= 50) break;
                    }
                }

                Console.WriteLine(positionBoat1 > positionBoat2 ? boat1 : boat2);
            }
        }
    }
}

