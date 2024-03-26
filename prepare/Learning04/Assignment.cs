﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    abstract class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment() { }

        public Assignment(string studentName, string topic)
        {
            _studentName = studentName;
            _topic = topic;
        }

        public string GetSummary()
        {
            return _studentName + " - " + _topic;
        }
    }
}
