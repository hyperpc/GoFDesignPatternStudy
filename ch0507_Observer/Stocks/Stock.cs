using System.Collections;

namespace ch0507_Observer.Stocks
{
    abstract class Stock
    {
        protected string symbol;
        protected double price;
        private ArrayList investors = new ArrayList();

        public string Symbol
        {
            get
            {
                return symbol;
            }

            set
            {
                symbol = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
                Notify();
            }
        }

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void Attach(Investor investor)
        {
            investors.Add(investor);
        }
        public void Detach(Investor investor)
        {
            investors.Remove(investor);
        }
        public void Notify()
        {
            foreach (Investor investor in investors)
                investor.Update(this);
        }
    }
}
