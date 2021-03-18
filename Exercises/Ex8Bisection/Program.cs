using System;

namespace Ex8Bisection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 08");
            Console.WriteLine("Pick a number 1-10");
            Bisect a = new Bisect();
            a.Math();
            RandomNumGen aa = new RandomNumGen();
            int C = aa.RandomNumber(1, 1000);
            Console.WriteLine("Guess My number 1-1000");
            int Userinput = -1;
            Guessing();
            ComputerGuess guess = new ComputerGuess();
            Console.WriteLine("Think of a number and I'll try to guess it");
            guess.Math();

            void Guessing()
            {

                while (Userinput != C)
                {
                    int Userinput = int.Parse(Console.ReadLine());
                    if (Userinput == C)
                    {
                        Console.WriteLine("You guessed correct");
                        break;
                    }
                    if (Userinput > C)
                    {
                        Console.WriteLine("You guessed too high");
                    }
                    if (Userinput < C)
                    {
                        Console.WriteLine("You guessed too low");
                    }
                }
            }

        }
    }

    public class Bisect
    {
        int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int input = int.Parse(Console.ReadLine());
        bool guessing = true;

        public void Math()
        {
            int min = 0;
            int max = list.Length;
            while (guessing == true)
            {
                int guess = (max + min) / 2;
                if (input == guess)
                {
                    Console.WriteLine($"the number is {guess}");
                    guessing = false;
                }
                if (input > guess)
                {
                    Console.WriteLine($"I guess {guess} guess to low");
                    min = guess;
                }
                if (input < guess)
                {
                    Console.WriteLine($"I guess {guess} guess to high");
                    max = guess;

                }

            }
        }

    }

    class RandomNumGen
    {

        public Random num = new Random();

        public int RandomNumber(int min, int max)
        {
            return num.Next(min, max);
        }

    }

    class ComputerGuess
    {
        bool guessing = true;

        public void Math()
        {
            int LoopCount = 0;
            int GuessAttempts = 0;
            int TotalGuessAttempts = 0;
            int min = 0;
            int max = 100;
            while (guessing == true)
            {
                GuessAttempts++;
                int guess = (max + min) / 2;
                Console.WriteLine($"My guess is {guess}. Type H if its too high, L for to low or C for correct");
                string HL = Console.ReadLine();

                if (HL == "C")
                {
                    Console.WriteLine($"I win! The number is {guess} It took me {GuessAttempts} attempts. Type yes if you wish to play again or no if you want to quit");
                    string KeepPlaying = Console.ReadLine();
                    if (KeepPlaying == "yes")
                    {
                        LoopCount += 1;
                        TotalGuessAttempts += GuessAttempts;
                        GuessAttempts = 0;
                        min = 0;
                        max = 100;
                    }
                    else
                    {
                        LoopCount += 1;
                        TotalGuessAttempts += GuessAttempts;
                        Console.WriteLine($"It took me an average of {TotalGuessAttempts / LoopCount} attempts to guess the number");
                        guessing = false;
                    }
                }
                if (HL == "L")
                {
                    min = guess;
                }
                if (HL == "H" || HL.ToLower() == "h")
                {
                    max = guess;
                }
                else
                {
                    throw new ArgumentException("You entered an invalid command");
                    // TODO cycle through or restart prog
                }

            }
        }
    }
}
