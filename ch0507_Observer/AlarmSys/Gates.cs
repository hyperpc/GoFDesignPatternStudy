using System;

namespace ch0507_Observer.AlarmSys
{
    class Gates : IAlarmListener
    {
        public void Alarm()
        {
            Console.WriteLine("自动关上门");
        }
    }
}
