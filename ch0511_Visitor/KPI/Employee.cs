namespace ch0511_Visitor.KPI
{
    class Employee : Element
    {
        string name;
        double income;
        int vocationDays;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double Income
        {
            get
            {
                return income;
            }

            set
            {
                income = value;
            }
        }

        public int VocationDays
        {
            get
            {
                return vocationDays;
            }

            set
            {
                vocationDays = value;
            }
        }

        public Employee(string name, double income, int vocationDays)
        {
            this.Name = name;
            this.Income = income;
            this.VocationDays = vocationDays;
        }
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
