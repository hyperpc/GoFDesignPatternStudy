namespace ch0405_Facade.Mortgage
{
    class MortgageApp
    {
        int amount;
        private Bank bank = new Bank();
        private Loan loan = new Loan();
        private Credit credit = new Credit();
        public MortgageApp(int amount)
        {
            this.amount = amount;
        }
        public bool IsEligible(Customer customer)
        {
            if (!bank.SufficientSavings(customer))
                return false;

            if (!loan.GoodLoan(customer))
                return false;

            if (!credit.GoodCredit(amount, customer))
                return false;

            return true;
        }
    }
}
