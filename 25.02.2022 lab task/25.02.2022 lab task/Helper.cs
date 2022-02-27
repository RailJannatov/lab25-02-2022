using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._02._2022_lab_task
{
    static class Helper
    {
        public static User[] AppendToArray(User[] users,User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return users;
        }
        public static User FindUser(User[] users, int id)
        {
            User res = new User();

            foreach (User user in users)
            {
                if (user.Id==id)
                {
                    res = user;
                }
            }
            return res;
        }
        public static void ShowUsers(User[] users)
        {

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.Surname} {user.UserName} {user.Password} {user.Id}");
            }
        }

    }
}
