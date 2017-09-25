
//using System.Runtime.Remoting.Contexts;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ch0505_Mediator.MultiThreadCom
{
    //[Synchronization(SynchronizationAttribute.REQUIRED,true)] //work on class
    public class Mediator
    {
        private int number;
        private bool slotFull = false;
        [MethodImpl(MethodImplOptions.Synchronized)]//work on method
        public void storeMsg(int num)
        {
            while (slotFull == true)
            {
                try
                {
                    Thread.Sleep(2000);
                }
                catch (ThreadInterruptedException ex)
                { }
            }
            slotFull = false;
            number = num;
            //notifyAll();
        }


        [MethodImpl(MethodImplOptions.Synchronized)]//work on method
        public int retrieveMsg()
        {
            while (slotFull == false)
            {
                try
                {
                    Thread.Sleep(2000);
                }
                catch (ThreadInterruptedException ex)
                { }
            }
            slotFull = false;
            //notifyAll();
            return number;
        }
    }
}
