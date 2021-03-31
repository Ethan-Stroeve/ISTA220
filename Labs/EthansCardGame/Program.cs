using System;

namespace EthansCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new pack
            int[] newPack = new int[52];
            for (int i = 0; i < newPack.Length; i++)
            {
                newPack[i] = i;
            }
            printPack(newPack);
            //shuffle pack
            Random r = new Random();
            for (int i = 0; i < newPack.Length; i++)
            {
                // pick randomm number between 0 and 51
                int rn = r.Next(52);
                // swap i for the random number
                int temp = newPack[i];
                newPack[i] = newPack[rn];
                newPack[rn] = temp;
            }
            //print pack x2
            printPack(newPack);
        }

        private static void printPack(int[] newPack)
        {
            string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
            foreach (int i in newPack)
            {
                Console.WriteLine($"{values[i % 13]} of {suits[i / 13]}");
            }
        }
    }
}
