using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._02._2022_lab_task
{

    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get;}
        public static int count = 0;

        public User()
        {
            count++;
            Id = count;
        }
    }

}
