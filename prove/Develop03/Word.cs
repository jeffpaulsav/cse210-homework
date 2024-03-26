using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Develop03
{
    public class Word
    {
        private string _content;
        private bool _isHidden;

        public Word(string content)
        {
           _content = content;
           _isHidden = false;
        }
        public string Content
        {
            get { return _content; }
            set
            {
                if (_content is string)
                { _content = value; }
                else 
                { _content = null; }
            }
        }
        public bool IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        public void Hide()
        {
            _content = new string('_', _content.Length);
            _isHidden = true;
        }
               
        public bool isHidden() 
        {
            bool containsUnderscore = GetDisplayText().Any(char.IsLetter);

            if (containsUnderscore == true)
            {
                return true;
            }
            else return false;
        }

        public string GetDisplayText()
        {
            return _content;
        }
    }
}

