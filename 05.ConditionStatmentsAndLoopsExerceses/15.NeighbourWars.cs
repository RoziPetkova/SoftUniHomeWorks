using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
       {
            int PeshosHealPoints = 100;
            int GoshosHealPoints = 100;
            int counter = 0;

            int damagePesho = int.Parse(Console.ReadLine());
            int damageGosho = int.Parse(Console.ReadLine());

            bool pdied = PeshosHealPoints <= 0 ? true : false;
            bool gdied = GoshosHealPoints <= 0 ? true : false;


         //  while ( !pdied || !gdied)
         //  {
         //      counter++;
         //      if (counter % 2 == 0)
         //      {
         //          PeshosHealPoints -= damageGosho;
         //          if ( pdied || gdied) break;
         //          Console.WriteLine
         //          ("Gosho used Thunderous fist and reduced Pesho to {0} health.", PeshosHealPoints);                   
         //      }
         //      else
         //      {
         //          GoshosHealPoints -=damagePesho;
         //          if (pdied || gdied) break;
         //          Console.WriteLine
         //          ("Pesho used Roundhouse kick and reduced Gosho to {0} health.", GoshosHealPoints);
         //         
         //      }
         //      if (counter % 3 == 0)
         //      {
         //          GoshosHealPoints += 10;
         //          PeshosHealPoints += 10;
         //      };
         //      
         //  }

            string nameOfTheWinner = PeshosHealPoints > GoshosHealPoints ? "Pesho" : "Gosho";
            Console.WriteLine("{0} won in {1}th round.", nameOfTheWinner, counter );
        }
    }
}

