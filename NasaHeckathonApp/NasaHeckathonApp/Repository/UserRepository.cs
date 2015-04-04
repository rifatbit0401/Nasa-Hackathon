using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NasaHeckathonApp.Models;
using System.Data.Entity;

namespace NasaHeckathonApp.Repository
{
    public class UserRepository
    {
        private NasaDbContext _nasaDbContext;

        public UserRepository(NasaDbContext nasaDbContext)
        {
            _nasaDbContext = nasaDbContext;
        }

        public bool Add(User user)
        {
            _nasaDbContext.Users.Add(user);
            return _nasaDbContext.SaveChanges()>0;
        }

        public User GetUser(String userName)
        {
            return _nasaDbContext.Users.SingleOrDefault(u => u.UserName.Equals(userName));
        }
        public bool IsUserExist(String userName)
        {
           return _nasaDbContext.Users.Any(u => u.UserName.Equals(userName));
        }
        public bool IsUserExist(String userName, String password)
        {
            return _nasaDbContext.Users.Any(u => u.UserName.Equals(userName) & u.Password.Equals(password));
        }
        public User GetUser(int userId)
        {
            return _nasaDbContext.Users.SingleOrDefault(u => u.Id.Equals(userId));
        }
    }

}