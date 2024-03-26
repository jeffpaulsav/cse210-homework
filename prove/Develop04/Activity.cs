using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    abstract class Activity
    {
        private string _name;
        private string _description;
        private string _duration;

        protected Activity() { }

        public void DisplayStartingMessage() { }

        public void DisplayEndingMessage() { }

        public void ShowSpinner(int seconds) { }

        public void ShowCountDown(int seconds) { }



    }
}
