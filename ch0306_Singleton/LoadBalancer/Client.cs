using System;

namespace LoadBalancer
{
    class Client
    {
        public static void Test()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();
            if (b1 == b2 && b2 == b3 && b3 == b4)
                Console.WriteLine("Same Instance");

            Console.WriteLine(b1.Server);
            Console.WriteLine(b2.Server);
            Console.WriteLine(b3.Server);
            Console.WriteLine(b4.Server);
        }
    }
}
