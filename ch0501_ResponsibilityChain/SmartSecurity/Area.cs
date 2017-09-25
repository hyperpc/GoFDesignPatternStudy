namespace ch0501_ResponsibilityChain.SmartSecurity
{
    public class Area : SecurityZone
    {
        public Area(string name) : base(name)
        {
        }

        public override bool handleNotification(int measurement, Sensor sensor)
        {
            if (sensor is TemperatureSensor)
            {
                if (measurement > 150)
                {
                    fireAlarm(this, sensor);
                    return true;
                }
            }
            return false;
        }
    }
}
