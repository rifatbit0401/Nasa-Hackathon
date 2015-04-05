using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.Model;
using MongoDB.Driver.Builders;

namespace Facebook.Repository
{
    class UserRepository : MongoDbConnector
    {

        public bool AddUser(User user)
        {
            Collection.Insert(user);
            return true;
        }

        public bool UpdateUser(User user)
        {
            Collection.Save(user);
            return true;
        }


        public User GetUserByUserId(String userId)
        {
            var user=Collection.FindOneAs<User>(Query.EQ("UserId", userId));
            return user;
        }

        public User GetUserByUserName(String userName)
        {
            var user = Collection.FindOneAs<User>(Query.EQ("UserName", userName));
            return user;
        }




    }
}
