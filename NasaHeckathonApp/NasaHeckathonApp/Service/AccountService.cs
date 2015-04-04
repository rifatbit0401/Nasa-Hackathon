using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NasaHeckathonApp.View_Models;
using NasaHeckathonApp.Repository;
using NasaHeckathonApp.Models;

namespace NasaHeckathonApp.Service
{
    public class AccountService
    {
        private UserRepository _userRepository;

        public AccountService()
        {
            _userRepository = new UserRepository(new NasaDbContext());
        }

        public bool SignUp(SignUpInfo signUpInfo)
        {
            if (_userRepository.IsUserExist(signUpInfo.UserName))
            {
                return false;
            }

            User user = new User
                            {
                                UserName = signUpInfo.UserName,
                                Password = signUpInfo.Password,
                                FirstName = signUpInfo.FirstName,
                                LastName = signUpInfo.LastName
                            };

            return _userRepository.Add(user);
        }

        public bool IsAuthenticated(LoginInfo loginInfo)
        {
            return _userRepository.IsUserExist(loginInfo.UserName,loginInfo.Password);
        }

        public User GetUser(String userName)
        {
            return _userRepository.GetUser(userName);
        }

    }
}