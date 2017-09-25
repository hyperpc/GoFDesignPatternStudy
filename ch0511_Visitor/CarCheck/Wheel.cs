namespace ch0511_Visitor.CarCheck
{
    public class Wheel
    {
        private string name;
        public Wheel(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.visit(this);
        }
    }
}
