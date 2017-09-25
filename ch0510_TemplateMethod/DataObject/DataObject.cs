namespace ch0510_TemplateMethod.DataObject
{
    abstract class DataObject
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process();
        public abstract void Disconnect();

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
