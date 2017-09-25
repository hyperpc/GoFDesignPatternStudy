namespace CarShop
{
    class Client
    {
        public static void Test()
        {
            Shop shop = new Shop();
            VehicleBuilder b1 = new ScooterBuilder();
            VehicleBuilder b2 = new CarBuilder();
            VehicleBuilder b3 = new MotorCycleBuilder();

            shop.Construct(b1);
            b1.Vehicle.Show();

            shop.Construct(b2);
            b2.Vehicle.Show();

            shop.Construct(b3);
            b3.Vehicle.Show();
        }
    }
}
