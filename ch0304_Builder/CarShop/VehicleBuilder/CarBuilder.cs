namespace CarShop
{
    class CarBuilder : VehicleBuilder
    {
        public override void BuildDoors()
        {
            vehicle["doors"] = "4";
        }

        public override void BuildEngine()
        {
            vehicle["engine"] = "2500 cc";
        }

        public override void BuildFrame()
        {
            vehicle = new Vehicle("轿车");
            vehicle["frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            vehicle["wheels"] = "4";
        }
    }
}
