namespace ch0502_Command.SwitchCommand
{
    public class LightOffCommand : ICommand
    {
        protected Light myLight;
        public LightOffCommand(Light l)
        {
            myLight = l;
        }
        public void execute()
        {
            myLight.turnOff();
        }
    }
}
