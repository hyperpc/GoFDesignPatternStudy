using System;

namespace MobileProduct
{
    class NokiaFactory : IMobileFactory
    {
        public IMobile ProduceMobile()
        {
            Console.Write("Nokia工厂制造了");
            return new Nokia();
        }
    }
}
