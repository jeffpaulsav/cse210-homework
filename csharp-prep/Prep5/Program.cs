using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string userNumberString = Console.ReadLine();
        int userNumber = int.Parse(userNumberString);
        return userNumber;
    }

    static int SquareNumber(int givenNumber)
    {
        int squaredNumber = givenNumber * givenNumber;
        return squaredNumber;
    }

    static void DisplayResult()
    {
        Console.WriteLine($"{PromptUserName()}, your favorite number squared is {SquareNumber(PromptNumber())}");
    }

}