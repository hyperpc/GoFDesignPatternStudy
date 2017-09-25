using System;

namespace MobileProduct
{
    class Client
    {
        public static void Test()
        {
            try
            {
                IMobile mobile;
                MobileFactory factory = new MobileFactory();
                mobile = factory.GetMobile("nokia");
                mobile.Call();
                mobile = factory.GetMobile("motorola");
                mobile.Call();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
