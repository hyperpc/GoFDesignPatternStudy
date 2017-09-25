using System;

namespace ch0508_State.CarSpeed
{
    class Off:State
    {
        public override void pull(Car wrapper)
        {
            wrapper.SetState(new Low());
            Console.WriteLine("挂低挡");
        }
    }
}
