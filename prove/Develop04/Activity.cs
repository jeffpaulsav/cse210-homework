using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    public class Activity
    {
        private string _name;
        private string _description;
        private string _duration;

        public Activity() { }

        public void DisplayStartingMessage(string _name, string _description) 
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the {_name} Activity. ");
            Console.WriteLine($"{_description} \n");
        }

        public int GetComputerTime()
        {
            Console.WriteLine("How long, in seconds, would you like for your session? ");
            string userRawTimeResponse = Console.ReadLine();
            int userRefinedTimeResponse = int.Parse(userRawTimeResponse);
            int computerTime = userRefinedTimeResponse;

            return computerTime;
        }

        public void DisplayEndingMessage() 
        {
            // end message ?????
            Console.WriteLine("Good Job! You have completed this round of the activity. We will redirect you now. ");
            Thread.Sleep(2500);
        }

        public void ShowSpinner(int seconds) 
        {
            List<string> animationStrings = new List<string> 
            { "|", "/", "-", "\\", "|", "/", "-", "\\", "|"};

            foreach (string s in animationStrings) 
            {
                Console.Write(s);
                Thread.Sleep(800);
                Console.Write("\b \b");
            }
        }
        public void ShowCountDown(int seconds) 
        {
            while (seconds != 0)
            {
                Console.Write($"{seconds}");
                Thread.Sleep(1000);
                seconds--;
                Console.Write("\b");
            }
            Console.Clear();
        }
    }
}
