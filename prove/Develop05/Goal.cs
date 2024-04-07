using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public abstract class Goal
    {
        private string _shortName;
        private string _desctription;
        private string _points;
        
        public Goal(string name, string description, string points)
        {
            _shortName = name;
            _desctription = description;
            _points = points;
        }

        public abstract void RecordEvent();

        public abstract string IsComplete();

        public abstract string GetStringRepresentation();

        public abstract int GetScore();

    }
}
