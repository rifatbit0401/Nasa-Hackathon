using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facebook.Model
{
    class User
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String DateOfBirth { get; set; }
        public List<User> Friends { get; set; }
        public List<Status> Statuses { get; set; }

        public User()
        {
            Id = Guid.NewGuid().ToString();
            Friends=new List<User>();
            Statuses=new List<Status>();
        }

        
    }
}
