using Develop02;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;
        Journal journal = new Journal();
                
        while (!quit)
        {
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write\n2.Display\n3.Load\n4.Save\n5.Quit");
            string user_respons = Console.ReadLine();
            switch (user_respons)
            {
                case "1":
                    {
                        journal.AddEntry();
                        break;
                    };
                case "2":
                    {
                        journal.DisplayAll();
                        break;
                    };
                case "3":
                    {
                        Console.Write("Enter filename you wish to load: ");
                        string filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                        break;
                    };
                case "4":
                    {
                        Console.Write("Please enter the file name: ");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        break;
                    };
                case "5":
                    {
                        quit = true;
                        break;
                    };
            }
        }
    }
}