namespace ch0402_Bridge.BusinessObject
{
    public class Client
    {
        public static void Test()
        {
            CustomersBusinessObject customers = new CustomersBusinessObject("广州客户名单");
            customers.DataObject = new CustomersDataObject();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.New("陈八");
            customers.ShowAll();
        }
    }
}
