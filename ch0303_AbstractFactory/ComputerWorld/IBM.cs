namespace ComputerWorld
{
    public class IBM : ComputerFactory
    {
        public IBM()
        {
            cpu = new Intel();
            hd = new WestDigit();
            mb = new MSI865PE();
        }
    }
}
