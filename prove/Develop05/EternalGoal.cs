using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class EternalGoal : Goal
    {
        private string _name;
        private string _description;
        private string _points;
        private bool _isComplete;

        public EternalGoal(string name, string description, string points) : base(name, description, points) 
        {   
            _name = name;
            _description = description;
            _points = points;
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
            string eternalGoal = $"Eternal goal: | {_name} | {_description} | {_points}";
            Console.WriteLine(eternalGoal);
            return eternalGoal;
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
