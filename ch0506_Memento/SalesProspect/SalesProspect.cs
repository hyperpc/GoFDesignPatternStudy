using System;

namespace ch0506_Memento.SalesProspect
{
    class SalesProspect
    {
        private string name;
        private string phone;
        private double budget;

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

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public double Budget
        {
            get
            {
                return budget;
            }

            set
            {
                budget = value;
            }
        }

        public Memento SaveMemento()
        {
            return new Memento(name, phone, budget);
        }

        public void RestoreMemento(Memento memento)
        {
            name = memento.Name;
            phone = memento.Phone;
            budget = memento.Budget;
        }
        public void Show()
        {
            Console.WriteLine("\n销售期望 ---- ");
            Console.WriteLine("名字: {0}", name);
            Console.WriteLine("电话: {0}", phone);
            Console.WriteLine("预算: {0:C}", budget);
        }
    }
}
