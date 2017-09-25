using System;

namespace ch0508_State.CarSpeed
{
    class High : State
    {
        public override void pull(Car wrapper)
        {
            wrapper.SetState(new Off());
            Console.WriteLine("挂空挡");
        }
    }
}
