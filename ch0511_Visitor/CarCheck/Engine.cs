namespace ch0511_Visitor.CarCheck
{
    public class Engine
    {
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
