﻿namespace ch0508_State.AccountState
{
    class SilverState : State
    {
        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }
        public SilverState(State state)
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
            interest = 0.0;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void StateChangeCheck()
        {
            if (balance < lowerLimit)
                account.State = new RedState(this);
            else if (balance > upperLimit)
                account.State = new GoldState(this);
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }
    }
}
