using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _startVerse;
        private int _endVerse;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }

        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            if (_endVerse> 0) 
            {
                return $"{_book} {_chapter}: {_verse}-{_endVerse}";
            }
            else
            {
                return $"{_book} {_chapter}:{_verse}";
            }
        }
    }
}
