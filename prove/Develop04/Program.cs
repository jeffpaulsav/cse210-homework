using Develop04;
using System;


class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;
        while (continueProgram)
        {
            
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Please a select an option: ");

            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case 4:
                    Activity activity = new Activity();
                    continueProgram = false;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;

            }
        }
    }
}