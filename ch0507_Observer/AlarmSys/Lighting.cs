using System;

namespace ch0507_Observer.AlarmSys
{
    class Lighting : IAlarmListener
    {
        public void Alarm()
        {
            Console.WriteLine("自动打开灯");
        }
    }
}
