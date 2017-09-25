using System;

namespace ch0505_Mediator.MultiThreadCom
{
    public class Producer : myThread
    {
        private Mediator med;
        private int id;
        private static int num = 1;
        public Producer(Mediator m)
        {
            med = m;
            id = num++;
        }
        public void run()
        {
            int num;
            while (true)
            {
                med.storeMsg(num = new Random().Next() * 100);
                Console.Write("p{0}-{1} ", id, num);
            }
        }
    }
}
