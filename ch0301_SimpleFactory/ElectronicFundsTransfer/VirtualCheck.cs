using System;

namespace EFT
{
    class VirtualCheck : EFT
    {
        public override void Process()
        {
            Console.WriteLine("虚拟支票处理中");
        }
    }
}
