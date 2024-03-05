using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 10);
        int guessNumber = 1000000;

        while (guessNumber != magicNumber)
        {
            string newGuess;
            Console.WriteLine("What is your guess? ");
            newGuess = Console.ReadLine();
            guessNumber = int.Parse(newGuess);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Too High ");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Too Low ");
            }
        }

        Console.WriteLine("You've guessed the number! ");
        
    }
}