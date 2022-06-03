using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPlayer = 0;
            int countComputer = 0;
            int countWrongNumber = 0;
            Random rnd = new Random();
            ConsoleKeyInfo player;

            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("Rules are: Press 1 for Rock, 2 for Scissors and 3 for Paper!");
            Console.WriteLine("The game will end when player or computer reaches 5 points");
            Console.WriteLine("or enter two times wrong number or enter two times symbol.");

            Console.WriteLine("------------------------------------------------------");
            while (countWrongNumber != 2)
            {
                player = Console.ReadKey(true);
                int playerChoise;
                bool num = int.TryParse(player.KeyChar.ToString(), out playerChoise);
                if (playerChoise == 1)
                {
                    Console.WriteLine("You choose ROCK.");
                    int computer = rnd.Next(1, 3);
                    if (computer == playerChoise)
                    {
                        Console.WriteLine("We both choose ROCK.");
                        Console.WriteLine("No one get point, let's play again.");
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("I choose SCISSORS.");
                        Console.WriteLine("You win this time.");
                        Console.WriteLine("Let's play again.");
                        countPlayer++;
                    }
                    else
                    {
                        Console.WriteLine("I choose PAPER.");
                        Console.WriteLine("I win this time.");
                        Console.WriteLine("Let's play again.");
                        countComputer++;
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else if (playerChoise == 2)
                {
                    Console.WriteLine("You choose SCISSORS.");
                    int computer = rnd.Next(1, 3);
                    if (computer == 1)
                    {
                        Console.WriteLine("I choose ROCK.");
                        Console.WriteLine("I win this time.");
                        Console.WriteLine("Let's play again.");
                        countComputer++;
                    }
                    else if (computer == playerChoise)
                    {
                        Console.WriteLine("We both choose SCISSORS.");
                        Console.WriteLine("No one get point, let's play again.");
                    }
                    else
                    {
                        Console.WriteLine("I choose PAPER.");
                        Console.WriteLine("You win this time.");
                        Console.WriteLine("Let's play again.");
                        countPlayer++;
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else if (playerChoise == 3)
                {
                    Console.WriteLine("You choose PAPER.");
                    int computer = rnd.Next(1, 3);
                    if (computer == 1)
                    {
                        Console.WriteLine("I choose ROCK.");
                        Console.WriteLine("You win this time.");
                        Console.WriteLine("Let's play again.");
                        countPlayer++;
                    }
                    else if (computer == 2)
                    {
                        Console.WriteLine("I choose SCISSORS.");
                        Console.WriteLine("I win this time.");
                        Console.WriteLine("Let's play again.");
                        countComputer++;
                    }
                    else
                    {
                        Console.WriteLine("We both choose PAPER.");
                        Console.WriteLine("No one get point, let's play again.");
                    }

                    Console.WriteLine("------------------------------------------------------");
                }
                else
                {
                    countWrongNumber++;
                    if (countWrongNumber == 1)
                    {
                        Console.WriteLine($"{player.KeyChar.ToString()} this symbol is not 1, 2 or 3?");
                        Console.WriteLine("You choose a wrong number. If you do that again I will end the game.");
                        Console.WriteLine("------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"{player.KeyChar.ToString()} this symbol is not 1, 2 or 3?");
                        Console.WriteLine("You choose 2 times wrong number, that's mean I end the game.");
                        break;
                    }

                }

                if (countComputer == 5 || countPlayer == 5)
                {
                    break;
                }

            }

            if (countPlayer != 0 || countComputer != 0)
            {
                if (countPlayer > countComputer)
                {
                    Console.WriteLine($"Congratulations you won with: {countPlayer} - {countComputer}");
                }
                else if (countPlayer < countComputer)
                {
                    Console.WriteLine($"I'm sorry but i won with: {countComputer} - {countPlayer}");
                }
                else
                {
                    Console.WriteLine($"We finish even: {countPlayer} - {countComputer}");
                }

            }
            else
            {
                Console.WriteLine("No one won a point: 0 - 0");
            }

        }
    }
}