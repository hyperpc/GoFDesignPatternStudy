namespace ch0501_ResponsibilityChain.SmartSecurity
{
    public class Client
    {
        public static void Test()
        {
            Area a = new Area("经理室");
            WareHouse w = new WareHouse("仓库(B)");
            TemperatureSensor t_sensor_corner = new TemperatureSensor("右边角");
            a.SetParent(w);
            Building b = new Building("#2");
            w.SetParent(b);
            a.Notify(200, t_sensor_corner);
        }
    }
}
