using System;

namespace CopyShallow1
{
    class Client1
    {
        public static void Test()
        {
            Lay1_1 obj1 = new Lay1_1();
            obj1.x = 1;
            obj1.lay2 = new Lay1_2();
            obj1.lay2.y = 1;
            Lay1_1 obj2 = obj1.Clone();
            obj2.x = 2;
            obj2.lay2.y = 2;

            Console.WriteLine("obj1.x={0},\t obj1.lay2.y={1}", obj1.x,obj1.lay2.y);
            Console.WriteLine("obj2.x={0},\t obj2.lay2.y={1}", obj2.x, obj2.lay2.y);
        }
    }
}
