using System;

namespace ch0508_State.CarSpeed
{
    class Medium : State
    {
        public override void pull(Car wrapper)
        {
            wrapper.SetState(new High());
            Console.WriteLine("挂高挡");
        }
    }
}
