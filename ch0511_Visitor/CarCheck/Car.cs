namespace ch0511_Visitor.CarCheck
{
    public class Car
    {
        private Engine engine = new Engine();
        private Body body = new Body();
        private Wheel[] wheels = { new Wheel("左前轮"), new Wheel("右前轮"), new Wheel("左后轮"), new Wheel("右后轮") };

        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
            engine.Accept(visitor);
            body.Accept(visitor);
            for (int i = 0; i < wheels.Length; i++)
                wheels[i].Accept(visitor);
        }
    }
}
