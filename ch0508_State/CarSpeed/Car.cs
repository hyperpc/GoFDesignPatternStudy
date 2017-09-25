using System;

namespace ch0508_State.CarSpeed
{
    public class Car
    {
        private State current;
        public Car()
        {
            current = new Off();
            Console.WriteLine("新车产出，空挡中");
        }
        public void SetState(State s) { current = s; }
        public void pull() { current.pull(this); }
    }
}
