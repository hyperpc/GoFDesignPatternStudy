using System;
using System.Collections;

namespace CarShop
{
    class Vehicle
    {
        private string type;
        private Hashtable parts = new Hashtable();

        public Vehicle(string type)
        {
            this.type = type;
        }

        public object this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n----------------------");
            Console.WriteLine("车辆类类型 ：" + type);
            Console.WriteLine("     框架 ：" + parts["frame"]);
            Console.WriteLine("     发动机 ：" + parts["engine"]);
            Console.WriteLine("     #轮子数 ：" + parts["wheels"]);
            Console.WriteLine("     #车门数 ：" + parts["doors"]);
        }
    }
}
