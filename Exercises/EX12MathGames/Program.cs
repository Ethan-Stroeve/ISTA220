using System;

namespace EX12MathGames
{
    class Program : whiteboar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to math Games");
            doflippyaddything("a");
            //Mathcalc A = new Mathcalc();

        }
    }

    class Mathcalc
    {
        public double NumofProblem { get; set; }
        public double Score { get; set; }
        public int num1 { get; set; }
        public int num2 { get; set; }
        public int Answer { get; set; }

        Random r = new Random();
        public Mathcalc()
        {
            Console.WriteLine(@"To add, enter 1,
To subtract, enter 2,
To multiply, enter 3,
To divide, enter 4.");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter number of problems you wish to do");
            NumofProblem = int.Parse(Console.ReadLine());
            if (userInput == "1")
            {
                Console.WriteLine($"you are testing addition and you have {NumofProblem} problems");
                add();
            }
            else if (userInput == "2")
            {
                Console.WriteLine($"you are testing subtraction and you have {NumofProblem} problems");
                subtract();
            }
            else if (userInput == "3")
            {
                Console.WriteLine($"you are testing multiplication and you have {NumofProblem} problems");
                multiply();
            }
            else if (userInput == "4")
            {
                Console.WriteLine($"you are testing division and you have {NumofProblem} problems");
                divide();
            }
        }

        public void add()
        {
            for (int i = 1; i < NumofProblem + 1; i++)
            {
                num1 = r.Next(1, 30);
                num2 = r.Next(1, 30);
                Console.WriteLine($"{i}. {num1} + {num2} =");
                Answer = int.Parse(Console.ReadLine());
                if(Answer == num1 + num2)
                {
                    Console.WriteLine("Correct");
                    Score += 1;
                }
                else
                {
                    Console.WriteLine($"Sorry the answer is {num1 + num2}");
                }
            }
            Console.WriteLine($"you got {Score} out of {NumofProblem} correct your grade is { (Score / NumofProblem) *100}");
        }
        public void subtract()
        {
            for (int i = 1; i < NumofProblem + 1; i++)
            {
                num1 = r.Next(1, 30);
                num2 = r.Next(1, 30);
                Console.WriteLine($"{i}. {num1} - {num2} =");
                Answer = int.Parse(Console.ReadLine());
                if (Answer == num1 - num2)
                {
                    Console.WriteLine("Correct");
                    Score += 1;
                }
                else
                {
                    Console.WriteLine($"Sorry the answer is {num1 - num2}");
                }
            }
            Console.WriteLine($"you got {Score} out of {NumofProblem} correct your grade is { (Score / NumofProblem) * 100}");
        }

        public void multiply()
        {
            for (int i = 1; i < NumofProblem + 1; i++)
            {
                num1 = r.Next(1, 30);
                num2 = r.Next(1, 30);
                Console.WriteLine($"{i}. {num1} * {num2} =");
                Answer = int.Parse(Console.ReadLine());
                if (Answer == num1 * num2)
                {
                    Console.WriteLine("Correct");
                    Score += 1;
                }
                else
                {
                    Console.WriteLine($"Sorry the answer is {num1 * num2}");
                }
            }
            Console.WriteLine($"you got {Score} out of {NumofProblem} correct your grade is { (Score / NumofProblem) * 100}");
        }
        public void divide()
        {
            for (int i = 1; i < NumofProblem + 1; i++)
            {
                num1 = r.Next(1, 30);
                num2 = r.Next(1, 30);
                Console.WriteLine($"{i}. {num1} / {num2} =");
                decimal Answer = decimal.Parse(Console.ReadLine());
                decimal decround = decimal.Round((decimal)num1 / (decimal)num2, 2);
                if (Answer == decround)
                {
                    Console.WriteLine("Correct");
                    Score += 1;
                }
                else
                {
                    Console.WriteLine($"Sorry the answer is {decround}");
                }
            }
            Console.WriteLine($"you got {Score} out of {NumofProblem} correct your grade is { (Score / NumofProblem) * 100}");
        }
    }
}
