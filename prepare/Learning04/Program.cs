using Learning04;
using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(mathAssignment.GetMathInformation());
        Console.WriteLine("\n");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}