using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string userGuess = Console.ReadLine();
                int userGuessInt = int.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine($"You guessed it! It was {secretNumber}.");
                    return;
                }
                else if (userGuessInt < secretNumber)
                {
                    Console.WriteLine("Nope that wasn't it. Guess higher.");
                }
                else if (userGuessInt > secretNumber)
                {
                    Console.WriteLine("Nope that wasn't it. Guess lower.");
                }
            }




        }
    }
}
