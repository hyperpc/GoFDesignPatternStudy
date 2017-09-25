namespace ch0502_Command.SimpleCalculator
{
    public class Client
    {
        public static void Test()
        {
            User user = new User();
            user.Computer('+', 100);
            user.Computer('-', 50);
            user.Computer('*', 10);
            user.Computer('/', 2);
            user.Undo(4);
            user.Redo(3);
        }
    }
}
