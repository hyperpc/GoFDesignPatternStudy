namespace EFT
{
    class Client
    {
        public static void Test()
        {
            EFT eft;
            EFTFactory factory = new EFTFactory();
            eft = factory.CreateEFT("VirtualCheck");
            eft.Process();
            eft = factory.CreateEFT("MasterCard");
            eft.Process();
        }
    }
}
