using System;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");


        int total = 0;
        float average = 0;
        int check = 0;
        int enteredNumber = 1;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");

        while (enteredNumber != 0)
        {
            Console.WriteLine("Enter Number: ");
            string enteredString = Console.ReadLine();
            enteredNumber = int.Parse(enteredString);
            numbers.Add(enteredNumber);
        }

        numbers.RemoveAt(numbers.Count - 1);

        foreach (int number in numbers)
        {
            total = total + number;
        }

        foreach (int number in numbers)
        {
            average = total / numbers.Count;
        }

        foreach (int number in numbers)
        {
            Console.Write(number + ", ");
        }

        foreach(int number in numbers)
        {
            if (number > check)
            {
                check = number;
            }
        }
        
        Console.WriteLine($"Total: {total} ");
        Console.WriteLine($"Average: {average} ");
        Console.WriteLine($"The Largest Number is: {check} ");
    }
}