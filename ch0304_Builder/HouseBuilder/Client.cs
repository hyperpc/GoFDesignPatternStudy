using System;

namespace HouseBuilder
{
    public class Client
    {
        public static void Test()
        {
            Director director = new Director();
            IHouse house = director.BuildHouse(false);
            Console.WriteLine(house.Description());

            house = director.BuildHouse(true);
            Console.WriteLine(house.Description());
        }
    }
}
