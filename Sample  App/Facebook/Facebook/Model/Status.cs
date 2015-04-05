using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facebook.Model
{
    class Status
    {
        public String Id { get; set; }
        public String StatusText { get; set; }
        public String Date { get; set; }
        public List<Comment> Comments { get; set; }
        public List<User> Tags { get; set; }

        public Status()
        {
            Id = Guid.NewGuid().ToString();
            Comments = new List<Comment>();
            Tags = new List<User>();
        }
    }
}
