namespace ch0511_Visitor.CarCheck
{
    public interface IVisitor
    {
        void visit(Wheel wheel);
        void visit(Engine engine);
        void visit(Body body);
        void visit(Car car);
    }
}
