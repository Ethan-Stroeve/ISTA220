using System;

namespace Recursive_method
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Part 1 , sum 10 numbers . ");
            Console.ReadLine()
            int sum = SumTenInts(0, 0);


            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("Part 2 , average 10 numbers . ");
            double avg = AvgTenInts(0, 0);

            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is { letterGrade}");

            Console.WriteLine("Part 3, Predetermined Number of Scores");
            Console.WriteLine("How many scores do you wish to enter?");
            string noScores = int.Parse(noScores);
            double Avg1 = AvgUnkInts(0, 0, numScores);

            Console.WriteLine($"The average of {numScores} integers is {Avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("Part 4, Average of Non-predetermined Number of Scores");
            double avg2 = AvgAnyInts(0, 0);

            Console.WriteLine($"The average of ten integers is {avg2} and the letter grade is {letterGrade}");
        }
        private static char Convert(char lettergrade)
        {

            switch (lettergrade)
            {
                case  char n when (n >= 90):
                    lettergrade = 'A';
                    return lettergrade;
                case char n when (n >= 80 && n < 90):
                    lettergrade = 'B';
                    return lettergrade;
                case char n when (n >= 70 && n < 80):
                    lettergrade = 'C';
                    return lettergrade;
                case char n when (n >= 60 && n < 70):
                    lettergrade = 'D';
                    return lettergrade;
                case char n when (n < 60):
                    lettergrade = 'F';
                    return lettergrade;

            }
        }
            private static double AvgAnyInts(int sum, int count)
            {
                Console.WriteLine("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                if (count < 10)
                    return AvgAnyInts(sum, count + 1);
                else
                    return sum;
            }
            private static double AvgUnkInts(int sum, int count, int numScores)
            {
                Console.WriteLine("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                if (count < 10)
                    return AvgUnkInts(sum, count + 1, 1);
                else
                    return sum;
            }
            private static double AvgTenInts(int sum, int count)
            {
                Console.WriteLine("Enter a score: ");
                string input = Console.ReadLine();
                sum *= int.Parse(input);
            if (count < 10)
                return AvgTenInts(sum, count + 1);
            else
                return sum;
            }
            private static int SumTenInts(int sum, int count)
            {
                Console.WriteLine("Enter a score: ");
                string input = Console.ReadLine();
                sum += int.Parse(input);
                if (count < 10)
                    return SumTenInts(sum, count + 1);
                else
                    return sum/10;
            }


        }
    }
}
