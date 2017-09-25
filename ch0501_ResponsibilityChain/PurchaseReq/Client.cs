namespace ch0501_ResponsibilityChain.PurchaseReq
{
    public class Client
    {
        public static void Test()
        {
            Director Larry = new Director("Larry");
            VicePresident Sam = new VicePresident("Sam");
            President Tammy = new President("Tammy");
            Larry.SetReporter(Sam);
            Sam.SetReporter(Tammy);
            PurchaseRequest reqx = new PurchaseRequest(2034, 350.00, "Project X");
            PurchaseRequest reqy = new PurchaseRequest(2035, 32590.10, "Project Y");
            PurchaseRequest reqz = new PurchaseRequest(2036, 122100.00, "Project Z");
            Larry.ProcessRequest(reqx);
            Larry.ProcessRequest(reqy);
            Larry.ProcessRequest(reqz);
        }
    }
}
