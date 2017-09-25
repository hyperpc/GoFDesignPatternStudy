using System;

namespace MobileProduct
{
    public class MotorolaFactory : IMobileFactory
    {
        public IMobile ProduceMobile()
        {
            Console.Write("Motorola工厂制造了");
            return new Motorola();
        }
    }
}
