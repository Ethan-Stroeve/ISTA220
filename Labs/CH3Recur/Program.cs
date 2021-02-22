using System;

namespace CH3Recur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recurssion example");
            long sumofnumbers = SumOfNumbers(10);
            Console.WriteLine(sumofnumbers);
            long productofnumbers = ProductOfNumbers(12);
            Console.WriteLine(productofnumbers);
        }

        private static long ProductOfNumbers(long n)
        {
            Console.WriteLine($"calling ProductOfNumbers({n})");
            if (n == 1)
                return 1;
            else
                return n * ProductOfNumbers(n - 1);
        }

        private static long SumOfNumbers(long n)
        {
            Console.WriteLine($"calling SumOfNumbers({n})");
            if (n == 0)
                return 0;
            else
                return n + SumOfNumbers(n - 1);
        }
    }
}
