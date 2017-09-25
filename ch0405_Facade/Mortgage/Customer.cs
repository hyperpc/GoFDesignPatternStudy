namespace ch0405_Facade.Mortgage
{
    class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return name; }
        }
    }
}
