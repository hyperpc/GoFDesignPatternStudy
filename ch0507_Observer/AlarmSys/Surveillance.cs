using System;

namespace ch0507_Observer.AlarmSys
{
    class Surveillance : CheckList, IAlarmListener
    {
        public void Alarm()
        {
            Console.WriteLine("自动监视系统启动：");
            byTheNumbers();
        }
        protected override void isolate()
        {
            Console.WriteLine("摄像枪瞄准");
        }
    }
}
