using Develop03;
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", 3, 16);
        Reference multiVerseReference = new Reference("John", 3, 16, 17);

        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        string scriptureString = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        string bookString = "John";
        int chapterInt = 3;
        int verse1Int = 16;

        Reference reference1 = new Reference(bookString, chapterInt, verse1Int);
        Scripture newScripture = new Scripture(reference, scriptureString);

        Console.Clear();

        Console.WriteLine(reference1.GetDisplayText());
        Console.WriteLine(newScripture.GetDisplayText());
        Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit:");

        string userInput = Console.ReadLine().ToLower();

        while (userInput != "quit" && !newScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Random random = new Random();
            int numWordsToHide = random.Next(3, 10);

            for (int i = 0; i < numWordsToHide; i++)
            {
                newScripture.HideRandomWords();
            }

            Console.WriteLine(reference1.GetDisplayText());
            Console.WriteLine(newScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit:");
            userInput = Console.ReadLine().ToLower();
        }

        if (newScripture.IsCompletelyHidden())
        {
            Console.WriteLine("All Done! ");
        }
    }
}