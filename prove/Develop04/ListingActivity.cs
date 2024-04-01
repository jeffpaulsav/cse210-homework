using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ListingActivity : Activity
    {
        private int _count = 0;
        private int _time;
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this week?",
            "Who are some of your personal heroes?",
            "When have you felt the Holy Ghost in this week?",
            "When did you know that God love you?",
            "When you felt a deep spiritual connection or sense of divine presence in your life?",
            "How has your faith or spirituality played a role in providing comfort or guidance during challenging times in your life?",
        };

        public ListingActivity() : base() { }

        public void Run() 
        {
            // call the actual activity itself
            ListActivity();

            // Clear introduction message and question about wanted time
            Console.Clear();
        }
        public void ListActivity() 
        {
            // opening activity message saying what it is
            base.DisplayStartingMessage("Listing Activity", "This activity will help you see all " +
                "the good items in your life by considering answers to questions. ");

            // get computertime
            int timeOfActivity = ActivityTime();

            // call getrandomprompt to get the question for the user 
            Console.WriteLine(GetRandomPrompt());

            // call getlistfromuser to recieve the answers from user
            GetListFromUser(timeOfActivity);
                        
            // display how many entries the user had
            Console.WriteLine($"Wow you had {_count} entries this time!");
            Thread.Sleep(3000);

            // display ending message?
            base.DisplayEndingMessage();
        }
        private int ActivityTime()
        {
            // base in this case will return how many seconds the user wants for this activity in milliseconds
            _time = base.GetComputerTime();

            return _time;
        }
        public string GetRandomPrompt() 
        {
            Random rnd = new Random();
            // get length of questions list and selects a random one
            int LengthOfQuestionList = _prompts.Count;
            int r = rnd.Next(LengthOfQuestionList);

            // return the random chosen question
            string randomPrompt = _prompts[r];
            return randomPrompt;
        }
        public List<string> GetListFromUser(int time) 
        {
            int timeOfActivity = time;

            List<string> answers = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(timeOfActivity);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Enter your answer:");
                string answer = Console.ReadLine();

                if (!string.IsNullOrEmpty(answer))
                {
                    answers.Add(answer);
                    _count++;
                }
            }
            return answers;
        }
    }
}
