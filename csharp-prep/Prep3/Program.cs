using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.WriteLine("What is your guess? ");
        guessNumber = Console.ReadLine();

        while guessNumber != magicNumber
            {
                Console.WriteLine("What is your guess? ")
            }

        Console.WriteLine("You've guessed the number? ")
        
    }
}