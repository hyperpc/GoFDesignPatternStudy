namespace ComputerWorld
{
    public class Dell : ComputerFactory
    {
        public Dell()
        {
            cpu = new AMD();
            hd = new Maxtor();
            mb = new MSIK7N2G();
        }
    }
}
