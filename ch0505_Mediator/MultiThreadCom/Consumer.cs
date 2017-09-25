using System;

namespace ch0505_Mediator.MultiThreadCom
{
    public class Consumer : myThread
    {
        private Mediator med;
        private int id;
        private static int num = 1;
        public Consumer(Mediator m)
        {
            med = m;
            id = num++;
        }
        public void run()
        {
            while (true)
            {
                Console.Write("c{0}-{1} ", id, med.retrieveMsg());
            }
        }
    }
}
