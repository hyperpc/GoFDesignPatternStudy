using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0508_State.CarSpeed
{
    class Client
    {
        public static void Test()
        {
            Car car = new Car();
            car.pull();
            car.pull();
            car.pull();
            car.pull();
        }
    }
}
