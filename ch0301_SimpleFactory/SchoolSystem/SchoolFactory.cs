namespace SchoolSystem
{
    public class SchoolFactory
    {
        public SchoolUser GetSchoolUser(string user, string password)
        {
            if (user == "Principal" && password == "Principal")
                return new SchoolPrincipal();

            if (user == "Teacher" && password == "Teacher")
                return new SchoolTeacher();

            return null;
        }
    }
}
