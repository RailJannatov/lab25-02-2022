using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._02._2022_lab_task
{
    class UserOperation : IAccount
    {
        public User[] Users = { };

        public void CreateAccount(string name, string surname, string username, string password)
        {
            User user = new User();
            user.Name = name;
            user.Surname = surname;
            user.UserName = username;
            user.Password = password;
            Users = Helper.AppendToArray(Users, user);

        }
    }
}
