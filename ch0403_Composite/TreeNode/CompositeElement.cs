using System;
using System.Collections;

namespace ch0403_Composite.TreeNode
{
    class CompositeElement : DrawingElement
    {
        private ArrayList elements = new ArrayList();
        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent) + "+ " + name);
            foreach (DrawingElement e in elements)
                e.Display(indent + 2);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }
    }
}
