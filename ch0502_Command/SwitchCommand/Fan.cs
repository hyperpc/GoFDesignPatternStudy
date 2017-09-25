using System;

namespace ch0502_Command.SwitchCommand
{
    public class Fan
    {
        public void startRotate()
        {
            Console.WriteLine("Fan is rotating");
        }
        public void notRotate()
        {
            Console.WriteLine("Fan is not rotating");
        }
    }
}
