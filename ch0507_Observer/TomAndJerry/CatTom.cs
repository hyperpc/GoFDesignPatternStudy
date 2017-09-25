using System;
using System.Collections;

namespace ch0507_Observer.TomAndJerry
{
    public class CatTom : ISubject
    {
        private ArrayList observers;
        public CatTom()
        {
            this.observers = new ArrayList();
        }
        public void AimAt(IObserver obs)
        {
            this.observers.Add(obs);
        }
        public void Cry()
        {
            Console.WriteLine("猫叫了");
            foreach (IObserver obs in observers)
                obs.Response();
        }
    }
}
