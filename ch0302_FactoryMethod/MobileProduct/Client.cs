namespace MobileProduct
{
    class Client
    {
        public static void Test()
        {
            IMobile mobile;
            IMobileFactory factory;

            factory = new MotorolaFactory();
            mobile = factory.ProduceMobile();
            mobile.Call();

            factory = new NokiaFactory();
            mobile = factory.ProduceMobile();
            mobile.Call();
        }
    }
}
