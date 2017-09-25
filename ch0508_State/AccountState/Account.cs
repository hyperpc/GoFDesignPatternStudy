using System;

namespace ch0508_State.AccountState
{
    class Account
    {
        private State state;
        private string owner;
        public Account(string owner)
        {
            this.owner = owner;
            state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return state.Balance; }
        }
        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("存入 {0:C} --- ", amount);
            Console.WriteLine("现存金额= {0:C}", this.Balance);
            Console.WriteLine("状态 = {0}", this.State);
            Console.WriteLine(string.Empty);
        }
        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            Console.WriteLine("支取 {0:C} --- ", amount);
            Console.WriteLine("现存金额= {0:C}", this.Balance);
            Console.WriteLine("状态 = {0}", this.State);
            Console.WriteLine(string.Empty);
        }
        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine("银行支付利息 --- ");
            Console.WriteLine("现存金额= {0:C}", this.Balance);
            Console.WriteLine("状态 = {0}", this.State);
            Console.WriteLine(string.Empty);

        }
    }
}
