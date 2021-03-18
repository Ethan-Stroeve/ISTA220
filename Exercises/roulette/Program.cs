using System;
using System.Threading;

namespace roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayRoulette();
        }
        static void PlayRoulette()
        {
            Random random = new Random();
            var r = new Random();
            string[] color = { "Red", "Black" }; 
            int choice; 
            int attempts = 0; 
            long bet;
            long money = 1000; 

            while (money != 0) 
            {

                intro();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                WriteBlinkingText("Press [Enter] to Start", 700);
                WaitForKey(ConsoleKey.Enter);
                Console.Clear();


                while (money != 0) 
                {
                    intro();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\nMoney: $" + money);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\tAttempts: " + attempts);
                    Console.WriteLine();

                   
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nMake a choice");
                    Console.WriteLine("================");
                    Console.WriteLine("1. Evens \n2. Odds \n3. Low's (1-18)" +
                        "\n4. High's (19-36) \n5. Red \n6. Black \n7. 1st Column" +
                        "\n8. 2nd Column \n9. 3rd Column");
                    Console.WriteLine("================");
                    choice = Convert.ToInt32(Console.ReadLine());
                    bool check = choice <= 9 && choice >= 1;

                   
                    if (check == false)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nYou did not enter a valid bet.\n");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Press [enter] to continue");
                        WaitForKey(ConsoleKey.Enter); 
                        Console.Clear();
                        continue;
                    }
                    else 
                    {
                        betAmount();

                        
                        while (bet > money)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nYou don't enough to bet that much money!\n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Press [enter] to continue");
                            WaitForKey(ConsoleKey.Enter);

                            betAmount();
                        }

                        money -= bet; 
                        int roll = random.Next(0, 36);
                        string randomColor = color[r.Next(color.Length)]; 
                        bool even = roll % 2 == 0;
                        if (((choice == 1) && (even == true)) || ((choice == 2) && (even == false)) || ((choice == 5) && (randomColor == "Red")) || ((choice == 6) && (randomColor == "Black")))
                        {
                            winner2();
                        }
                        else if ((choice == 3) && ((roll > 0) && (roll < 19)))
                        {
                            winner2();
                        }
                        else if ((choice == 4) && ((roll > 18) && (roll < 37)))
                        {
                            winner2();
                        }
                        else if (((choice == 7) && (roll > 0 && roll < 13)) || ((choice == 8) && (roll > 12 && roll < 25)) || ((choice == 9) && (roll > 24 && roll < 37)))
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 3));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress [enter] to continue");
                            money += (bet * 3);
                            attempts++;
                            WaitForKey(ConsoleKey.Enter);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nLOSER! -$" + (bet));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\nPress [enter] to continue");
                            attempts++;
                            WaitForKey(ConsoleKey.Enter);

                            if (money == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\nYou're out of money.");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine("Thank you for playing Deluxe Roulette! Come again!");
                                Console.WriteLine("\nPress [enter] to continue");
                                WaitForKey(ConsoleKey.Enter);
                                Console.Clear();
                                PlayRoulette(); 
                            }
                        }
                        void winner2()
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nThe roulette rolled: " + randomColor + " " + roll);
                            Console.WriteLine("\nWINNER! $" + (bet * 2));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Press [enter] to continue");
                            money += (bet * 2); 
                            attempts++;  
                            WaitForKey(ConsoleKey.Enter);
                        }
                        void betAmount()
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("How much do you want to bet?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bet = Convert.ToInt32(Console.ReadLine());

                        }
                    }
                    Console.Clear();
                }
                try
                {
                    PlayRoulette();
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                }
            }

            static void intro()
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("$ $ $ $ ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(" Roulette");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(" $ $ $ $\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

          
            static void WaitForKey(ConsoleKey key)
            {
                while (Console.ReadKey(true).Key != key)
                { }
            }

            static void WriteBlinkingText(string text, int delay)
            {
                bool visible = true;
                while (!Console.KeyAvailable)
                {
                    Console.Write("\r" + (visible ? text : new String(' ', text.Length)));
                    Thread.Sleep(delay);
                    visible = !visible;
                }
            }
        }
    }
}
