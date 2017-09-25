namespace ch0405_Facade.Mortgage
{
    class Client
    {
        public static void Test()
        {
            MortgageApp mortgage = new Mortgage.MortgageApp(12500);
            mortgage.IsEligible(new Customer("Gabrielle McKinsey"));

        }
    }
}
