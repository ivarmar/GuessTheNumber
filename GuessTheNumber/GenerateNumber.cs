using System;

namespace GuessTheNumber
{
    internal class GenerateNumber
    {
        public void GuessTheNumber()
        {
            

            do
            {
                Console.WriteLine("Guess the correct number from 0 to 100!");

                Random rand = new Random();
                var correctNumber = rand.Next(0, 101);
                int wrongGuesses = 0;
                int userNumber;
                bool guessedCorrectly = false;

                do
                {
                    Console.Write("Enter your guess: ");
                    userNumber = int.Parse(Console.ReadLine());

                    if (userNumber == correctNumber)
                    {
                        Console.WriteLine($"Congratulations! You guessed it correctly: {correctNumber}");
                        guessedCorrectly = true;
                    }
                    else if (userNumber < correctNumber)
                    {
                        Console.WriteLine("Sorry, you need to guess higher.");
                        wrongGuesses++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you need to guess lower.");
                        wrongGuesses++;
                    }

                    

                } while (!guessedCorrectly);

                Console.WriteLine($"Number of wrong guesses: {wrongGuesses}");
                Console.Write("Do you want to play again? (y/n): ");

            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}



