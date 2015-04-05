using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook.Model;
using Facebook.Repository;

namespace Facebook
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User{FirstName = "Abdus Satter", LastName = "Rifat", UserName = "iit", Password = "iit123"};
            UserRepository userRepository = new UserRepository();
            //userRepository.AddUser(user);
            user = userRepository.GetUserByUserName("iit");
            Console.WriteLine(user.FirstName);
            Console.ReadLine();
        }
    }
}
