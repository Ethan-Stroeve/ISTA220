using System;

namespace EX7Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 7 Roulette");

            int[] array1 = new int[37];
            Console.WriteLine($"{(string.Join(", ", setarray(array1)))}");


            static int[] setarray(int[] arr)
            {
                for (int i = 0; i < 37; i++)
                {
                   arr[i] = i;

                }return arr;

            }

        }
    }
}
