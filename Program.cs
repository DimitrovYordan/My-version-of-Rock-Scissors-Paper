using System;

namespace RockScissorsPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you wanna play with me? Write yes or no.");
            string player = Console.ReadLine();

            int countPlayer = 0;
            int countComputer = 0;
            int countWrongNumber = 0;
            Random rnd = new Random();

            if (player == "yes")
            {
                Console.WriteLine("Ok, let's play!");
                Console.WriteLine("Press 1 for Rock, 2 for Scissors and 3 for Paper!");
                Console.WriteLine("Do you understand the rules mother fucker!");
                player = Console.ReadLine();

                if (player == "yes")
                {
                    Console.WriteLine("------------------------------------------------------");
                    while (countWrongNumber != 2)
                    {
                        int playerChoose = int.Parse(Console.ReadLine());

                        if (playerChoose == 1)
                        {
                            Console.WriteLine("You choose ROCK.");
                            int computer = rnd.Next(1, 3);
                            if (computer == playerChoose)
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
                        else if (playerChoose == 2)
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
                            else if (computer == playerChoose)
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
                        else if (playerChoose == 3)
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

                        if (playerChoose > 3 || playerChoose < 0)
                        {
                            countWrongNumber++;
                            if (countWrongNumber == 1)
                            {
                                Console.WriteLine("You stupid ASS you choose a wrong number. If you do that again I will end the game.");
                            }
                            else if (countWrongNumber == 2)
                            {
                                Console.WriteLine("You stupid ASS you choose 2 times wrong number, that's mean I end the game.");
                                break;
                            }

                        }

                    }
                }
                else if (player == "no")
                {
                    Console.WriteLine("HA HA HA LOSER");
                }
                else
                {
                    Console.WriteLine($"{player} what the fuck that means?");
                }

            }
            else if (player == "no")
            {
                Console.WriteLine("Bye");
            }
            else
            {
                Console.WriteLine($"{player} what the fuck that means?");
            }

            if (countPlayer != 0 || countComputer != 0)
            {
                if (countPlayer > countComputer)
                {
                    Console.WriteLine($"Congratulations you won with: {countPlayer} - {countComputer}");
                }
                else if (countPlayer < countComputer)
                {
                    Console.WriteLine($"I'm sorry LOSER but i won with: {countComputer} - {countPlayer}");
                }
                else
                {
                    Console.WriteLine($"Fuck this shit we are even: {countPlayer} - {countComputer}");
                }

            }

        }
    }
}