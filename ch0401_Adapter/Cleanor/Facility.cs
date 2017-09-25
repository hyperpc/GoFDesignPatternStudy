using System;

namespace ch0401_Adapter.Cleanor
{
    public class Facility : IExtra
    {
        public void makeClean()
        {
            Console.WriteLine("Care Facility");
        }

        public void takeCare()
        {
            Console.WriteLine("Clean Facility");
        }
    }
}
