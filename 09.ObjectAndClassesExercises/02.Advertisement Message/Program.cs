using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string[] Phrases = new string[]
            { "Excellent product.", "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };
            string[] Events = new string[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };
             string[] Authors = new string[] { "Diana",
                 "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
           string[] Cities = new string[]{ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            var rnd = new Random();


            for (int i = 0; i < num; i++)
            {
                int num1 = rnd.Next(Phrases.Length);
                int num2 = rnd.Next(Phrases.Length);
                int num3 = rnd.Next(Phrases.Length);
                int num4 = rnd.Next(Phrases.Length);

                Console.WriteLine($"{Phrases[num1]} {Events[num2]} {Authors[num3]} – {Cities[num4]}.");
                
            }

            

        }
    }
}
