namespace ch0502_Command.SwitchCommand
{
    public class FanOffCommand : ICommand
    {
        protected Fan myFan;
        public FanOffCommand(Fan f)
        {
            myFan = f;
        }
        public void execute()
        {
            myFan.notRotate();
        }
    }
}
