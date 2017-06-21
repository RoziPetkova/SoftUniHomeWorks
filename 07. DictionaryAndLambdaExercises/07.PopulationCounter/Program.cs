using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> population = new Dictionary<string, Dictionary<string, long>>();

            List<string> line = Console.ReadLine().Split('|').ToList();
            //"city|country|population". 

            while (line[0].ToLower() != "report")
            {
                string city = line.ElementAt(0);
                string country  = line.ElementAt(1);
                string populationStr = line.ElementAt(2);
                long populationNum = long.Parse(populationStr);
               

                if (!population.ContainsKey(country))               
                    population[country] = new Dictionary<string, long>();
                if (!population[country].ContainsKey(city))
                    population[country][city] = populationNum;


                line = Console.ReadLine().Split('|').ToList();
                
            }


            foreach (var state in population.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");

                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }

        }
    }
}
