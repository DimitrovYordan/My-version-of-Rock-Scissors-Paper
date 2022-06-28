using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPlayer = 0;
            int countComputer = 0;
            Random rnd = new Random();
            ConsoleKeyInfo player;

            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("Rules are: Press 1 for Rock, 2 for Scissors and 3 for Paper!");
            Console.WriteLine("The game will end when player press q.");
            Console.WriteLine("------------------------------------------------------");
            while (true)
            {
                player = Console.ReadKey(true);
                if (player.KeyChar == 'q')
                {
                    Console.WriteLine("Do you realy want to exit the game?");
                    Console.WriteLine("Press y for yes, n for no.");
                    Console.WriteLine("------------------------------------------------------");
                    player = Console.ReadKey(true);
                    if (player.KeyChar == 'y')
                    {
                        PrintResult(countPlayer, countComputer);
                        break;
                    }
                    else if (player.KeyChar == 'n')
                    {
                        Console.WriteLine("Press new number.");
                        Console.WriteLine("------------------------------------------------------");
                        continue;
                    }

                }

                if (player.Key == ConsoleKey.Escape)
                {
                    break;
                }

                int playerChoise;
                bool num = int.TryParse(player.KeyChar.ToString(), out playerChoise);
                if (playerChoise == 1)
                {
                    Console.Write("You choose ROCK.");
                    for (int i = 0; i < 28; i++)
                    {
                        Console.Write(" ");
                        if (i == 27)
                        {
                            Console.WriteLine("SCORE:");
                        }
                    }
                    
                    int computer = rnd.Next(1, 4);
                    if (computer == playerChoise)
                    {
                        Console.WriteLine("I choose ROCK.");
                        Console.Write("We both choose ROCK.                        ");
                        PrintResultEven(countPlayer, countComputer);
                        Console.WriteLine("No one get point, let's play again.");
                    }
                    else if (computer == 2)
                    {
                        countPlayer++;
                        Console.WriteLine("I choose SCISSORS.");
                        Console.Write("You win this time.                          ");
                        PrintResultGreen(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }
                    else
                    {
                        countComputer++;
                        Console.WriteLine("I choose PAPER.");
                        Console.Write("I win this time.                            ");
                        PrintResultRed(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else if (playerChoise == 2)
                {
                    Console.Write("You choose SCISSORS.");
                    for (int i = 0; i < 24; i++)
                    {
                        Console.Write(" ");
                        if (i == 23)
                        {
                            Console.WriteLine("SCORE:");
                        }
                    }

                    int computer = rnd.Next(1, 4);
                    if (computer == 1)
                    {
                        countComputer++;
                        Console.WriteLine("I choose ROCK.");
                        Console.Write("I win this time.                            ");
                        PrintResultRed(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }
                    else if (computer == playerChoise)
                    {
                        Console.WriteLine("I choose SCISSORS.");
                        Console.Write("We both choose SCISSORS.                    ");
                        PrintResultEven(countPlayer, countComputer);
                        Console.WriteLine("No one get point, let's play again.");
                    }
                    else
                    {
                        countPlayer++;
                        Console.WriteLine("I choose PAPER.");
                        Console.Write("You win this time.                          ");
                        PrintResultGreen(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else if (playerChoise == 3)
                {
                    Console.Write("You choose PAPER.");
                    for (int i = 0; i < 27; i++)
                    {
                        Console.Write(" ");
                        if (i == 26)
                        {
                            Console.WriteLine("SCORE:");
                        }
                    }
                    int computer = rnd.Next(1, 4);
                    if (computer == 1)
                    {
                        countPlayer++;
                        Console.WriteLine("I choose ROCK.");
                        Console.Write("You win this time.                          ");
                        PrintResultGreen(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }
                    else if (computer == 2)
                    {
                        countComputer++;
                        Console.WriteLine("I choose SCISSORS.");
                        Console.Write("I win this time.                            ");
                        PrintResultRed(countPlayer, countComputer);
                        Console.WriteLine("Let's play again.");
                    }
                    else
                    {
                        Console.WriteLine("I choose PAPER.");
                        Console.Write("We both choose PAPER.                       ");
                        PrintResultEven(countPlayer, countComputer);
                        Console.WriteLine("No one get point, let's play again.");
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine($"{player.KeyChar} this symbol is not 1, 2 or 3?");
                    Console.WriteLine("------------------------------------------------------");

                }

            }

        }

        static void PrintResultRed(int countPlayer, int countComputer)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{countPlayer} - {countComputer}");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void PrintResultGreen(int countPlayer, int countComputer)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{countPlayer} - {countComputer}");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void PrintResultEven(int countPlayer, int countComputer)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"{countPlayer} - {countComputer}");
            Console.ResetColor();
            Console.WriteLine();
        }

        static void PrintScore(int countPlayer, int countComputer)
        {
            for (int i = 0; i < 22; i++)
            {
                Console.Write(" ");
                if (i == 21)
                {
                    Console.WriteLine($"{countPlayer} - {countComputer}");
                }
            }
        }

        static void PrintResult(int countPlayer, int countComputer)
        {
            if (countPlayer > countComputer)
            {
                Console.Write("Congratulations you won with:               ");
                PrintResultGreen(countPlayer, countComputer);
            }
            else if (countPlayer < countComputer)
            {
                Console.Write("I'm sorry but i won with:                   ");
                PrintResultRed(countPlayer, countComputer);
            }
            else
            {
                Console.Write("We finish even:                             ");
                PrintResultEven(countPlayer, countComputer);
            }
        }
    }
}