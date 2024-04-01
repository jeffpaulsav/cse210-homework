using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class ReflectingActivity : Activity
    {
        private int _time;

        private List<string> _prompts = new List<string>()
        {
        "Think of a time when you failed at something.",
        "Think a story about a time when you stepped out of your comfort zone and grew as a result",
        "Think a moment when you faced a tough decision and how you handled it",
        "Recall a story of an obstacle you overcame that made you feel proud",
        "Think of an experience that required you to be resourceful and creative in finding a solution.",
        "Think a difficult task or project you undertook and the lessons you learned from it.",
        "Think about a time when you persevered through adversity and emerged stronger.",
        "When did you last feel accomplished?",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        };

        private List<string> _questions = new List<string>()
        {
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was your motivation?",
        "Did your resilience and determination grow? ",
        "How did your problem-solving skills come into play? ",
        "Who helped you at this time?",
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        };

        public ReflectingActivity() : base() { }

        public void Run() 
        {
            // call the actual activity itself
            ReflectActivity();

            // Clear introduction message and question about wanted time
            Console.Clear();

            // display ending message?
            base.DisplayEndingMessage();
        }
        public void ReflectActivity()
        {
            // display starting message 
            base.DisplayStartingMessage("Reflecting", "This activity will help you reflect on times in your life when you " +
                "have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life. ");

            // get computertime
            int timeOfActivity = ActivityTime();

            // call DisplayPrompt to show initial question
            DisplayPrompt();

            // call DisplayQuestion to show the associated question
            DisplayQuestions();

            // recieve answers from user for a determined amount of time
            UserGivenAnswers(timeOfActivity);
        }
        public List<string> UserGivenAnswers(int time)
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
                }
            }
            return answers;
        }
        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            // get length of questions list and selects a random one
            int LengthOfPromptsList = _prompts.Count;
            int r = rnd.Next(LengthOfPromptsList);

            // return the random chosen question
            string randomPrompt = _prompts[r];
            return randomPrompt;
        }
        public string GetRandomQuestion()
        {
            Random rnd = new Random();
            // get length of questions list and selects a random one
            int LengthOfQuestionList = _questions.Count;
            int r = rnd.Next(LengthOfQuestionList);

            // return the random chosen question
            string randomPrompt = _questions[r];
            return randomPrompt;
        }
        public void DisplayPrompt() 
        {
            Console.WriteLine(GetRandomPrompt());
        }
        public void DisplayQuestions() 
        {
            Console.WriteLine(GetRandomQuestion());
        }
        public int ActivityTime()
        {
            // base in this case will return how many seconds the user wants for this activity in milliseconds
            _time = base.GetComputerTime();

            return _time;
        }

    }
}
