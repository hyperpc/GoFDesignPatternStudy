namespace ch0507_Observer.AlarmSys
{
    class Client
    {
        public static void Test()
        {
            SensorSys ss = new SensorSys();
            ss.register(new Gates());
            ss.register(new Lighting());
            ss.register(new Surveillance());
            ss.soundAlarm();
        }
    }
}
