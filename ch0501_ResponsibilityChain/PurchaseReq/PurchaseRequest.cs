namespace ch0501_ResponsibilityChain.PurchaseReq
{
    class PurchaseRequest
    {
        private int number;
        private double amount;
        private string purpose;
        public PurchaseRequest(int number, double amount, string purpose)
        {
            this.number = number;
            this.amount = amount;
            this.purpose = purpose;
        }
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string Purpase
        {
            get
            {
                return purpose;
            }
            set
            {
                purpose = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
    }
}
