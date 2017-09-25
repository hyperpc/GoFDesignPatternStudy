using System;

namespace ch0402_Bridge.BusinessObject
{
    class CustomersBusinessObject:BusinessObject
    {
        public CustomersBusinessObject(string group):base(group)
        {
        }

        public override void ShowAll()
        {
            Console.WriteLine();
            Console.WriteLine("----------------");
            base.ShowAll();
            Console.WriteLine("----------------");
        }
    }
}
