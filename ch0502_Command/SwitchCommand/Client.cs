namespace ch0502_Command.SwitchCommand
{
    public class Client
    {
        public static void Test()
        {
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            Switch ts = new Switch(lightOn, lightOff);
            ts.flipUp();
            ts.flipDown();

            Fan tFan = new Fan();
            FanOnCommand fanOn = new FanOnCommand(tFan);
            FanOffCommand fanOff = new FanOffCommand(tFan);
            ts = new Switch(fanOn, fanOff);
            ts.flipUp();
            ts.flipDown();
        }
    }
}
