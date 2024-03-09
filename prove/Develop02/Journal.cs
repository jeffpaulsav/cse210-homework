using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop02
{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        
        public void AddEntry()
        {
            PromptGenerator generatedPrompt = new PromptGenerator();
            Random random = new Random();

            string prompt = generatedPrompt.GetRandomPrompt();
            Console.WriteLine(prompt);
            string user_answer = Console.ReadLine();
            DateTime time = DateTime.Now;
            
            Entry userLog = new Entry();
            userLog._promptText = prompt;
            userLog._entryText = user_answer;
            userLog._date = time;
            
            _entries.Add(userLog);
        }

        public void DisplayAll()
        {
            foreach (Entry entry in _entries) 
            {
                entry.Display();
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter outPutFile = new StreamWriter(filename))
            {
                _entries.ForEach(log => {
                    outPutFile.WriteLine(log._date + ": " + log._promptText + ": " + log._entryText);
                });
            }
        }

        public void LoadFromFile(string filename) 
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            Entry log = new Entry();
            CultureInfo info = new CultureInfo("en-Us");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] != "")
                {
                    log = new Entry();
                    string[] array = lines[i].Split(": ");
                    log._date = DateTime.Parse(array[0], info);
                    log._promptText = array[1];
                    log._entryText = array[2];
                    _entries.Add(log);
                }
            }
        }


    }
}
