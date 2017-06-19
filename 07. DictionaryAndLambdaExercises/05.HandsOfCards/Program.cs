using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
// List<int> stoinosti = dataBase.Values
//     .Select(spisyk => spisyk.Distinct().Where(y => !y.Equals("")))
//     .Select(spisyk => spisyk.Select(karta => GetCardValue(karta)))
//     .Select(spisyk => spisyk.Aggregate((x1, x2) => x1 + x2)).ToList();
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> dataBase = new Dictionary<string, List<int>>();

            string input = Console.ReadLine();

            while (input != "JOKER")
            {
                string name = input.Split(':').ElementAt(0).ToString();
                List<int> cards = input.Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Skip(1).ToList()
                    .Distinct()
                    .Select(a => GetCardValue(a))
                    .ToList();

                if (!dataBase.ContainsKey(name))
                {
                    dataBase.Add(name, cards);
                }
                else
                    dataBase[name].AddRange(cards);

                input = Console.ReadLine();
            }
       
            foreach (var player in dataBase)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }
        }

        public static int GetCardValue (string card)
        {
            card.ToCharArray();

            int p = card[0] == '2' ? 2 :
                    card[0] == '3' ? 3 :
                    card[0] == '4' ? 4 :
                    card[0] == '5' ? 5 :
                    card[0] == '6' ? 6 :
                    card[0] == '7' ? 7 :
                    card[0] == '8' ? 8 :
                    card[0] == '9' ? 9 :
                    card[0] == 'J' ? 11 :
                    card[0] == 'Q' ? 12:
                    card[0] == 'K' ? 13:
                    card[0] == 'A' ? 14: 10;

            int cardType = card.Last().Equals('S') ? 4 :
                           card.Last().Equals('H') ? 3 :
                           card.Last().Equals('D') ? 2 :
                           card.Last().Equals('C') ? 1 : 0;

            int result = p * cardType;
            return result;
        }
    }
}

