using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook.Model
{
    class Comment
    {
        public String Id { get; set; }
        public String CommentText { get; set; }
        public List<User> Tags { get; set; }
        public User CommentProvider { get; set; }

        public Comment()
        {
            Id = Guid.NewGuid().ToString();
            Tags=new List<User>();
        }
    }
}
