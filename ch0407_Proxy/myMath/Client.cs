using System;

namespace ch0407_Proxy.myMath
{
    class Client
    {
        public static void Test()
        {
            MathProxy proxy = new MathProxy();
            Console.WriteLine("4 + 2 = {0}", proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = {0}", proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = {0}", proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = {0}", proxy.Div(4, 2));
        }
    }
}
