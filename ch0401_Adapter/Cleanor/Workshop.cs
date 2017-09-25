using System;

namespace ch0401_Adapter.Cleanor
{
    public class Workshop : IClean
    {
        public void makeClean()
        {
            Console.WriteLine("Clean Workshop");
        }
    }
}
