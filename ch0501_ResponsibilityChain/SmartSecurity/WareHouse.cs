using System;

namespace ch0501_ResponsibilityChain.SmartSecurity
{
    public class WareHouse : SecurityZone
    {
        public WareHouse(string name) : base(name)
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
                Console.WriteLine("保安请马上去检查{0}的{1}", this.name, zone.name);
                if (GetParent() != null)
                    GetParent().fireAlarm(zone, sensor);
                return;
            }
            base.fireAlarm(zone, sensor);
        }
    }
}
