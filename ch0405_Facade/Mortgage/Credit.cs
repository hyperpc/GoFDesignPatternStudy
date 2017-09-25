using System;

namespace ch0405_Facade.Mortgage
{
    class Credit
    {
        public bool GoodCredit(int amount, Customer customer)
        {
            Console.WriteLine("Check credit for {0}", customer.Name);
            return true;
        }
    }
}
