using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyShallow1
{
    class Lay1_2
    {
        public int y;
        public Lay1_2 Copy()
        {
            return this.MemberwiseClone() as Lay1_2;
        }
    }
}
