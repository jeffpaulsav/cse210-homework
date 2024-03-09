using Develop02;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        Entry anEntry = new Entry();

        PromptGenerator randomPrompt = new PromptGenerator();
        randomPrompt.GetRandomPrompt();

        Console.WriteLine("Hello Develop02 World!");
    }
}