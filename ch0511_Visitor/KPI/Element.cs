namespace ch0511_Visitor.KPI
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
