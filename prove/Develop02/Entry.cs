using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop02
{
    public class Entry
    {
        public DateTime _date;
        public string _promptText;
        public string _entryText;

        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_promptText} \n Entry: {_entryText} ");
        }
    }
}
