using System;

namespace ch0508_State.AccountState
{
    class RedState:State
    {
        double serviceFee;
        public RedState(State state)
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
            lowerLimit = -100.0;
            upperLimit = 0.0;
            serviceFee = 15.00;
        }

        public override void PayInterest()
        {
            
        }

        public override void StateChangeCheck()
        {
            if (balance > upperLimit)
                account.State = new SilverState(this);
        }

        public override void Withdraw(double amount)
        {
            amount -= serviceFee;
            Console.WriteLine("余额不足，支取失败");
        }
    }
}
