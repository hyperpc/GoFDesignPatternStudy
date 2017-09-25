namespace ch0502_Command.SwitchCommand
{
    public class FanOnCommand : ICommand
    {
        protected Fan myFan;
        public FanOnCommand(Fan f)
        {
            myFan = f;
        }
        public void execute()
        {
            myFan.startRotate();
        }
    }
}

