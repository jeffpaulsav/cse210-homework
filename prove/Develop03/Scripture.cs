using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
        private List<Word> _words = new List<Word>();
        private Reference _reference;
        private HashSet<int> _hiddenIndexes = new HashSet<int>();

        public Scripture(Reference reference, string wholeScriptureText) 
        {            
            _reference = reference;

            foreach (string word in wholeScriptureText.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public string GetDisplayText()
        {
            return string.Join(" ", _words.Select(word => word.GetDisplayText()));
        }

        public bool IsCompletelyHidden()
        {
            if (_hiddenIndexes.Count == _words.Count)
                return true;
            else 
                return false;
        }

        public void HideRandomWords() // Hide 3 words, no need to get complicated 
        {
            Random rnd = new Random();
            int index = 0;

            do
            {
                index = rnd.Next(0,_words.Count);
            }
            while (!_hiddenIndexes.Add(index));
            _words[index].Hide();
        }

    }
}
