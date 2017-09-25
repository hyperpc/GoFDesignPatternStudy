using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0508_State.CarSpeed
{
    class Low:State
    {
        public override void pull(Car wrapper)
        {
            wrapper.SetState(new Medium());
            Console.WriteLine("挂中挡");
        }
    }
}
