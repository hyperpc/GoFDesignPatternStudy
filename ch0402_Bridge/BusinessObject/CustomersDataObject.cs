using System;
using System.Collections;

namespace ch0402_Bridge.BusinessObject
{
    class CustomersDataObject:DataObject
    {
        private ArrayList customers = new ArrayList();
        private int current = 0;
        public CustomersDataObject()
        {
            customers.Add("张三");
            customers.Add("李四");
            customers.Add("王五");
            customers.Add("张六");
            customers.Add("赵七");
        }

        public override void PriorRecord()
        {
            if (current > 0)
                current--;
        }

        public override void NextRecord()
        {
            if(current<=customers.Count-1)
                current++;
        }

        public override void NewRecord(string name)
        {
            customers.Add(name);
        }

        public override void DeleteRecord(string name)
        {
            customers.Remove(name);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }

        public override void ShowAllRecords()
        {
            foreach(string name in customers)
                Console.WriteLine(" " + name);
        }
    }
}
