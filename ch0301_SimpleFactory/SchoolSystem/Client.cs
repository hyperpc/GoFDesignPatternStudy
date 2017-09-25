using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    class Client
    {
        public static void Test()
        {
            SchoolUser user;
            SchoolFactory factory = new SchoolFactory();
            user = factory.GetSchoolUser("Principal", "Principal");
            Console.WriteLine("----------校长登录----------\n");
            user.Show();
            user = factory.GetSchoolUser("Teacher", "Teacher");
            Console.WriteLine("----------教师登录----------\n");
            user.Show();
        }
    }
}
