namespace CarShop
{
    class ScooterBuilder : VehicleBuilder
    {
        public override void BuildDoors()
        {
            vehicle["doors"] = "0";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "none";
        }

        public override void BuildFrame()
        {
            vehicle = new Vehicle("单脚滑行车");
            vehicle["frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "2";
        }
    }
}
