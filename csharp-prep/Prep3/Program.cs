using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is your magic number? ");
        // string userNumber = Console.ReadLine();
        // int magicNumber = int.Parse(userNumber);
        string wantPlay = "Y";

        while (wantPlay == "Y")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int guesses = 0;
            int numberGuess = 0;
            do
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                numberGuess = int.Parse(userGuess);
                guesses++;

                if (numberGuess == magicNumber)
                {
                    Console.WriteLine($"You guessed it! You had {guesses} tries.");
                    Console.Write("Do you want to play again? (Y/N): ");
                    wantPlay = Console.ReadLine();
                }
                else if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            } while (numberGuess != magicNumber);

        }
    }
}