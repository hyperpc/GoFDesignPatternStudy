using System;

namespace ch0501_ResponsibilityChain.SmartSecurity
{
    public class Building : SecurityZone
    {
        public Building(string name) : base(name)
        {
        }

        public override bool handleNotification(int measurement, Sensor sensor)
        {
            return false;
        }

        public override void fireAlarm(SecurityZone zone, Sensor sensor)
        {
            if (zone is Area)
            {
                Console.WriteLine("{0}栋大楼发生火警", name);
                if (GetParent() != null)
                    GetParent().fireAlarm(zone, sensor);
                return;
            }
            base.fireAlarm(zone, sensor);
        }
    }
}
