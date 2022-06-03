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

            Console.WriteLine("Ok, let's play!");
            Console.WriteLine("Press 1 for Rock, 2 for Scissors and 3 for Paper!");
            Console.WriteLine("Do you understand the rules mother fucker! Type yes or no.");
            string player = Console.ReadLine();

            if (player == "yes")
            {
                Console.WriteLine("------------------------------------------------------");
                while (countWrongNumber != 2)
                {
                    player = Console.ReadLine();
                    int playerChoise;
                    bool num = int.TryParse(player, out playerChoise);
                    if (player == "end")
                    {
                        break;
                    }
                    else if (playerChoise == 1)
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
                        Console.WriteLine($"{player} what the fuck that means?");
                    }

                    if (playerChoise > 3 || playerChoise < 0)
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