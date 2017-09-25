using System;

namespace ch0507_Observer.Stocks
{
    class Investor : IInvestor
    {
        private string name;
        private string observerState;
        private Stock stock;
        public Investor(string name)
        {
            this.name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("通知到股民{0} {1}最新股价为：{2:C}", name, stock.Symbol, stock.Price);
        }
    }
}
