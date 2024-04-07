using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop05
{
    public class GoalManager2
    {
        private List<Goal> _goals = new List<Goal> ();
        private int _score;

        public GoalManager2() { }

        public void Start()
        {
            bool continueMainMenu = true;
            while (continueMainMenu)
            {
                // 
                Console.Clear();
                Console.WriteLine("Menu Options:\n");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Record event");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Please a select an option: ");

                // 
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        CreateGoal();
                        break;

                    case 2:
                        ListGoalDetails();
                        break;

                    case 3:
                        RecordEvent();
                        break;

                    case 4:
                        continueMainMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }

        public void CreateGoal()
        {
            bool continueGoalMenu = true;
            while (continueGoalMenu)
            {
                // 
                Console.Clear();
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                Console.WriteLine("What type of goal do you want to work on? ");

                // 
                int selection = int.Parse(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        // consult user on goal information
                        Console.Clear();
                        Console.WriteLine("What is the name of your goal?");
                        string simpleName = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal?");
                        string simpleDescription = Console.ReadLine();
                        Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                        string simplePoints = Console.ReadLine();
                        // create new Goal object to put into list of Goal

                        SimpleGoal simplegoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);

                        _goals.Add(simplegoal);
                        continueGoalMenu = false;
                        break;

                    case 2:
                        // consult user on goal information
                        Console.Clear();
                        Console.WriteLine("What is the name of your goal?");
                        string eternalName = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal?");
                        string eternalDescription = Console.ReadLine();
                        Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                        string eternalPoints = Console.ReadLine();
                        // create new Goal object to put into list of Goal

                        EternalGoal eternalgoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);  

                        _goals.Add(eternalgoal);
                        continueGoalMenu = false;
                        break;

                    case 3:
                        // consult user on goal information
                        Console.Clear();
                        Console.WriteLine("What is the name of your goal?");
                        string checklistName = Console.ReadLine();
                        Console.WriteLine("What is a short description of your goal?");
                        string checklistDescription = Console.ReadLine();
                        Console.WriteLine("What is the amount of points recieved for accomplishing this goal?");
                        string checklistPoints = Console.ReadLine();
                        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                        string checklistAttempts = Console.ReadLine();
                        Console.WriteLine("What is the bonus for accomplishing this goal");
                        string checklistBonusPoints = Console.ReadLine();
                        // create new Goal object to put into list of Goal

                        ChecklistGoal checklistgoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, checklistBonusPoints, checklistAttempts);

                        _goals.Add(checklistgoal);
                        continueGoalMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;

                }
            }
        }


        public void ListGoalDetails()
        {
            Console.WriteLine("\nList of Goals:\n");
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet. Create some to get started!\n");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The goals are:\n");
                // 
                foreach (Goal goal in _goals)
                {
                    // call the overrided GetStringRepresentation methods in each goal to 
                    goal.GetStringRepresentation();
                }

                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);

            }
        }

        public void RecordEvent()
        // very important to implement !!!!!
        {
            Console.WriteLine("Which Goal would you like to report on? (int) ");
            string index = Console.ReadLine();
            int numindex = int.Parse(index);

            Goal goalFromList = _goals[numindex - 1];

            goalFromList.RecordEvent();

            Console.WriteLine("Awesome Work So Far ");
            Console.Clear();

        }

        public void AddScore()
        {
            foreach (Goal goal in _goals) 
            {
                goal.GetScore();
            }
        }

    }
}
