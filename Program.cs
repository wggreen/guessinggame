using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 11);
            bool isCorrect = false;

            while (!isCorrect)
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string userGuess = Console.ReadLine();
                int userGuessInt = int.Parse(userGuess);

                if (userGuessInt == secretNumber)
                {
                    Console.WriteLine($"You guessed it! It was {secretNumber}.");
                    isCorrect = true;
                }
                else if (userGuessInt < secretNumber && userGuessInt > 0)
                {
                    Console.WriteLine("Nope that wasn't it. Guess higher.");
                }
                else if (userGuessInt > secretNumber && userGuessInt < 11)
                {
                    Console.WriteLine("Nope that wasn't it. Guess lower.");
                }
                else if (userGuessInt != secretNumber)
                {
                    Console.WriteLine("You lose! You get nothing! Good day sir!");
                }
                else if (userGuessInt < 1 || userGuessInt > 10)
                {
                    Console.WriteLine("Your guess must be between 1 and 10. Guess again.");
                }
            }




        }
    }
}
