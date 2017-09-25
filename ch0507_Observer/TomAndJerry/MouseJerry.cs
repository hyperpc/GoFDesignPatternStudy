using System;

namespace ch0507_Observer.TomAndJerry
{
    public class MouseJerry : IObserver
    {
        private string name;
        private CatTom cat;
        public MouseJerry(string name, ISubject subj)
        {
            this.name = name;
            subj.AimAt(this);
        }
        public void Response()
        {
            Console.WriteLine(name + "努力潜逃中！");
        }
    }
}
