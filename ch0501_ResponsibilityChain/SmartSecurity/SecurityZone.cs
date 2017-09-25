using System;

namespace ch0501_ResponsibilityChain.SmartSecurity
{
    public abstract class SecurityZone
    {
        private SecurityZone parent;
        public string name;
        public SecurityZone(string name)
        {
            this.name = name;
        }
        public SecurityZone GetParent()
        {
            return parent;
        }
        public void SetParent(SecurityZone zone)
        {
            this.parent = zone;
        }
        public void Notify(int measurement, Sensor sensor)
        {
            if (!handleNotification(measurement, sensor) && parent != null)
                parent.Notify(measurement, sensor);
        }

        public abstract bool handleNotification(int measurement, Sensor sensor);

        public virtual void fireAlarm(SecurityZone zone, Sensor sensor)
        {
            Console.WriteLine(this.name + sensor.position + "水喷洒器打开了");
            if (parent != null)
                parent.fireAlarm(zone, sensor);
        }
    }
}
