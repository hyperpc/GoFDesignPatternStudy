namespace ch0511_Visitor.CarCheck
{
    class Client
    {
        public static void Test()
        {
            Car car = new Car();
            IVisitor visitor = new Engineer("工程师小王");
            car.Accept(visitor);
        }
    }
}
