namespace ch0502_Command.SwitchCommand
{
    public class Switch
    {
        private ICommand UpCommand, DownCommand;
        public Switch(ICommand up, ICommand down)
        {
            UpCommand = up;
            DownCommand = down;
        }
        public void flipUp()
        {
            UpCommand.execute();
        }
        public void flipDown()
        {
            DownCommand.execute();
        }
    }
}
