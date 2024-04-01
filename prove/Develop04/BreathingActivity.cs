using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop04
{
    internal class BreathingActivity : Activity
    {
        public BreathingActivity() : base() { }

        public void Run() 
        {
            // call introduction message 
            base.DisplayStartingMessage("Breathing", "In this activity we will have timed breathing in and timed breathing out. ");

            // Call BreathActivity to do the activity itself
            BreathActivity();

            // Clear introduction message and question about wanted time
            Console.Clear();            
        }
        private int ActivityTime()
        {
            // base in this case will return how many seconds the user wants for this activity in milliseconds
            int time = base.GetComputerTime();
            
            return time;
        }
        private void BreathActivity()
        {
            // calling activity time also gives the name and descrition of the selected exercise 
            int timeOfActivity = ActivityTime();

            // get ready message and spinner demonstration
            Console.WriteLine("Get Ready...");

            // call spinner
            base.ShowSpinner(5);

            // get time now and time for end of activity
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(timeOfActivity);

            // loop for actual activity
            while (DateTime.Now < endTime) 
            {
                Console.Clear();
                Console.WriteLine("Breath In ");
                base.ShowCountDown(3);
                timeOfActivity -= 3;
                Console.Clear();
                Console.WriteLine("Breath Out ");
                base.ShowCountDown(4);
                timeOfActivity -= 4;
                Console.Clear();
            }
            // ending message and redirect
            base.DisplayEndingMessage();
        }

    }

}
