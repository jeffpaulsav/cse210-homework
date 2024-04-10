using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation1
{
    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        List<Comment> _comments = new List<Comment>();

        // class constructor
        public Video(string title, string author, int length) 
        {
            _author = author;
            _length = length;
            _title = title;
        }

        // add comment class to comment list 
        public void AddComment(string commenttext, string author)
        {
            Comment comment = new Comment(commenttext, author);
            _comments.Add(comment);
        }

        // display video details given
        public void DisplayVideoDetails()
        {
            // blank line for separation
            Console.WriteLine();

            // print title author and length of video
            Console.WriteLine($"'{_title}' by {_author}, {_length} seconds long. ");

            // iterate through list of comments and print the comment
            foreach (Comment comment in _comments) 
            {
                Console.Write($"{comment.GetSetComments} : {comment.GetSetCommentor} \n");
            }
        }

    }
}
