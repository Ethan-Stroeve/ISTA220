using System;

namespace Recurssionlab
{
    class Program
    {
        static void Main(string[] args)
        {

           int initial = 5;
            Console.WriteLine($" Calling   recurr1 ({ initial })");
           int recur = recurr1(initial);
            Console.WriteLine($" recurr1  is { recur }");
            Console.WriteLine($" Calling   recurr2 ({ initial })");
            recur = recurr2(1, initial);
            Console.WriteLine($" recurr2  is { recur }");
            
        }

        private static int recurr1(int initial)
        {
            Console.WriteLine(initial);
            if (initial <= 1)
             return 1;
            else
             return initial * recurr1(--initial);
        }

        private static int recurr2(int product, int initial)
        {
            
            Console.WriteLine(initial);
            if (initial <= 1)
              return product;
             else
             return recurr2(product * initial, --initial);
             
        }
    }
}
