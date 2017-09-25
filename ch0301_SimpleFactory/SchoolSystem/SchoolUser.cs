using System;

namespace SchoolSystem
{
    public class SchoolUser
    {
        public string FName;
        public string LName;
        public string UserType;
        public void Show()
        {
            Console.WriteLine("First Name : " + FName);
            Console.WriteLine("Last Name : " + LName);
            Console.WriteLine("User Type : " + UserType);
        }
    }
}
