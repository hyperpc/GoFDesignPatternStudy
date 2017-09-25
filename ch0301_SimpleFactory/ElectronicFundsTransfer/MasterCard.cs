using System;

namespace EFT
{
    class MasterCard : EFT
    {
        public override void Process()
        {
            Console.WriteLine("万事达卡处理中");
        }
    }
}
