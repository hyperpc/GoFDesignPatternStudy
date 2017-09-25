using System;

namespace ch0507_Observer.AlarmSys
{
    class CheckList
    {
        public void byTheNumbers()
        {
            //template
            localize();
            isolate();
            identify();
        }

        protected void localize()
        {
            Console.WriteLine("建立边界");
        }
        protected virtual void isolate()
        {
            Console.WriteLine("隔离栅栏");
        }
        protected void identify()
        {
            Console.WriteLine("确认入侵源：猫");
        }
    }
}
