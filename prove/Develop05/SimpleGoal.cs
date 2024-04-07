using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Develop05
{
    public class SimpleGoal : Goal
    {
        private bool _isComplete;
        private string _name;
        private string _description;
        private string _points;

        public SimpleGoal(string name, string description, string points) : base(name, description, points) 
        {
            _name = name;
            _description = description;
            _points = points;
        }

        public override void RecordEvent() 
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Did you accomplish this simple goal? (Yes/No) ");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes")
                {
                    _isComplete = true;
                    break;
                }

                else 
                { _isComplete = false; break; }

            }
        }

        public override string IsComplete()
        {
            if (_isComplete) 
            {
                return "X";
            }
            else
            { return "_"; }
        }

        public override int GetScore()
        {
            if (_isComplete)
            {
                int point = int.Parse(_points);
                return point;
            }
            else
            { return 0; }
        }

        public override string GetStringRepresentation() 
        // this is meant to make the class as a whole into a printable string that can be saved on the document
        { 
            string simpleGoal = $"[ {IsComplete()} ] Simple goal: | {_name} | {_description} | {_points} |";
            Console.WriteLine(simpleGoal);
            return simpleGoal ;
        }
     


    }
}
