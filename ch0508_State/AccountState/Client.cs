namespace ch0508_State.AccountState
{
    class Client
    {
        public static void Test()
        {
            Account account = new Account("张三");
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.0);
            account.Withdraw(1100.0);
        }
    }
}
