namespace ch0403_Composite.TreeNode
{
    public class Client
    {
        public static void Test()
        {
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));
            CompositeElement comp = new CompositeElement("Two Circle");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);
            PrimitiveElement l = new PrimitiveElement("Yelloow Line");
            root.Add(l);
            root.Display(1);
            root.Remove(l);
            root.Display(1);
        }
    }
}
