using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Foundation1
{
    public class Comment
    {
        // initialize the only 2 aspects of a comment
        private string _comment;
        private string _commentor;

        // only constructor for both aspects
        public Comment(string comment, string commentor) 
        { 
            _comment = comment;
            _commentor = commentor;
        }

        // get and set for _comment
        public string GetSetComments
        {
            get {  return _comment; }  
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _comment = value;
                }
                else
                {
                    _comment = "Unknown";
                }
            }
        }

        // get and set for _commentor
        public string GetSetCommentor
        {
            get { return _commentor; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _commentor = value;
                }
                else
                {
                    _commentor = "Unknown";
                }
            }
        }


    }
}
