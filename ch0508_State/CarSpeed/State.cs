using System;

namespace ch0508_State.CarSpeed
{
    public abstract class State
    {
        public virtual void pull(Car wrapper)
        {
            wrapper.SetState(new Off());
            Console.WriteLine("turning off");
        }
    }
}
