using System;

namespace ch0405_Facade.TeaMaker
{
    class Client
    {
        public static void Test()
        {
            TeaMaker maker = new TeaMaker();
            TeaCup cup = maker.makeTeaCup();
            Console.WriteLine(cup.ToString());
        }
    }
}
