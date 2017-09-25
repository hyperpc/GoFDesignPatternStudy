using System;

namespace ch0403_Composite.TreeNode
{
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            Console.WriteLine("Cannot Add");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + " draw a {0}", name);
        }

        public override void Remove(DrawingElement d)
        {
            Console.WriteLine("Cannot Remove");
        }
    }
}
