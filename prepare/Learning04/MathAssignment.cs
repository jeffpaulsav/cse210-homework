using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    internal class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;


        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _problems = problems;
            _textbookSection = textbookSection;
        }

        public string GetMathInformation()
        {
            string summaryInfo = base.GetSummary();
            
            string mathInfo = _textbookSection + " " + _problems;

            return summaryInfo + "\n" + mathInfo;      
        }

    }
}
