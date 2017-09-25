namespace ch0508_State.AccountState
{
    class GoldState : State
    {
        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        public GoldState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }
        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void StateChangeCheck()
        {
            if (balance < 0.0)
                account.State = new RedState(this);
            else if (balance < lowerLimit)
                account.State = new SilverState(this);
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }
    }
}
