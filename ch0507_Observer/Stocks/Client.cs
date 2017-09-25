namespace ch0507_Observer.Stocks
{
    class Client
    {
        public static void Test()
        {
            Investor s = new Investor("张三");
            Investor b = new Investor("李四");
            IBM ibm = new IBM("IBM", 120.00);
            ibm.Attach(s);
            ibm.Attach(b);
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;
        }
    }
}
