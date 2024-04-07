using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Develop05
{
    public class ChecklistGoal : Goal
    {
        private int _amountCompleted = 0;
        private string _target;
        private string _bonus;
        private string _name;
        private string _description;
        private string _points;
        private bool _isComplete;

        public ChecklistGoal(string name, string description, string points, string bonusPoints, string attempts) : base(name, description, points) 
        {
            _name = name;
            _description = description;
            _points = points;
            _bonus = bonusPoints;
            _target = attempts;
        }

        public override void RecordEvent()
        {
            throw new NotImplementedException();
        }

        public override string IsComplete()
        {
            throw new NotImplementedException();
        }

        public override string GetStringRepresentation()
        // this is meant to make the class as a whole into a printable string that can be saved on the document
        {
            string checklistGoal = $"Checklist goal: | {_name} | {_description} | {_points} | {_bonus} | {_target} | ";
            Console.WriteLine(checklistGoal);
            return checklistGoal;
        }

        public string GetDetailsString()
        {
            throw new NotImplementedException();
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


    }
}
