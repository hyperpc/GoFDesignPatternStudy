namespace ch0511_Visitor.CarCheck
{
    public class Body
    {
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
