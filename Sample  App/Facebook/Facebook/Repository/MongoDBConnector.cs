using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.Model;
using MongoDB.Driver;

namespace Facebook.Repository
{
    class MongoDbConnector
    {
        protected MongoCollection Collection;
        public MongoDbConnector()
        {
            Collection =
                new MongoClient("mongodb://localhost").GetServer().GetDatabase("Facebook").GetCollection<User>("User");
        }
    }
}
