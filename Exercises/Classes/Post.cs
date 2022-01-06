using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Classes
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; } = DateTime.Now;

        public int VoteCount { get; private set; }

        public int UpVote()
        {
            return VoteCount++;
        }

        public int DownVote()
        {
            return VoteCount--;
        }
    }
}
