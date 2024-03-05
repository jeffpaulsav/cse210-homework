using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade? ");
        float grade = Console.ReadLine();
        string letter;

        if (grade >= 90)
            {
                letter = "A"
                Console.WriteLine($"You got an {letter}! ");
            }
        else if (grade >= 80)
            {
                letter = "B"
                Console.WriteLine($"You got an {letter}! ");
            }
        else if (grade >= 70)
            {
                letter = "C"
                Console.WriteLine($"You got an {letter}! ");
            }
        else if (grade >= 60)
            {
                letter = "D"
                Console.WriteLine($"You got an {letter}! ");
            }
        else
            {
                letter = "F"
                Console.WriteLine($"You did not pass. Got an {letter}. ");
            }

        if grade >= 70 
            {
                Console.WriteLine("You've passed the class! ")
            }
        else
            {
                Console.WriteLine("Try the class again. ")
            }
    }
}