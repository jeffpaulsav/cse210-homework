﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning04
{
    internal class WritingAssignment : Assignment
    {
        private string _title;

        public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        } 

        public string GetWritingInformation()
        {
            string summaryInfo = base.GetSummary();

            string writeInfo = _title;

            return summaryInfo + " \n" + writeInfo;
        }

    }
}
