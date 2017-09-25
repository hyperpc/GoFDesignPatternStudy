using System;
using System.Collections;

namespace ch0507_Observer.AlarmSys
{
    class SensorSys
    {
        private ArrayList listeners = new ArrayList();
        public void register(IAlarmListener listener)
        {
            listeners.Add(listener);
        }
        public void soundAlarm()
        {
            Console.WriteLine("传感器系统检测有入侵的情况");
            foreach (var e in listeners)
                ((IAlarmListener)e).Alarm();
        }
    }
}
