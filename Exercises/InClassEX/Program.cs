using System;
using System.Collections.Generic;

namespace InClassEX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class List Exercise(Live)");
            while (true)
            {
                Console.WriteLine("\nEnter 'Q' to quit.");
                string Quit = Console.ReadLine();
                if (Quit == "Q" || Quit == "q")
                    Environment.Exit(0);
                else
                    Shuffle();
            }

        }

        private static void Shuffle()
        {
            Console.WriteLine("This is method Shuffle");
            List<string> Letters = new List<string>();
            foreach(string letter in new string[6] { "a", "b", "c", "d", "e", "f"})
            {
                Letters.Add(letter);
                Console.Write(letter);
            }
            Console.WriteLine("----------");

            List<string> RLetters = new List<string>();
            Random r = new Random();
            while(Letters.Count > 0)
            {
                int Alex = r.Next(Letters.Count);
                RLetters.Add(Letters[Alex]);
                Letters.RemoveAt(Alex);
            }
            foreach(string Letter in RLetters)
            {
                Console.Write(Letter);
            }

        }
    }
}
