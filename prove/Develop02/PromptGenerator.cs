using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Develop02
{
    public class PromptGenerator
    {
        public List<string> _prompts;
        string _givenPrompt;

        public string GetRandomPrompt()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 5);

            _prompts = new List<string>();

            _prompts.Add("Who was the most interesting person I interacted with today?");
            _prompts.Add("What was the best part of my day?");
            _prompts.Add("How did I see the hand of the Lord in my life today?");
            _prompts.Add("What was the strongest emotion I felt today?");
            _prompts.Add("If I had one thing I could do over today, what would it be?");

            _givenPrompt = _prompts[randomNumber];

            Console.WriteLine($"{_givenPrompt}");

            return _givenPrompt;
        }
    }
}
