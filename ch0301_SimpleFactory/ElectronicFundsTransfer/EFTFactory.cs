namespace EFT
{
    class EFTFactory
    {
        public EFT CreateEFT(string type)
        {
            switch (type.ToLower())
            {
                case "virtualcheck":
                    return new VirtualCheck();
                case "mastercard":
                    return new MasterCard();
                default:
                    return null;
            }
        }
    }
}
