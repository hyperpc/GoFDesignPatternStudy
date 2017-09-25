using System;

namespace ch0405_Facade.Mortgage
{
    class Loan
    {
        public bool GoodLoan(Customer customer)
        {
            Console.WriteLine("Check loan for {0}", customer.Name);
            return true;
        }
    }
}
