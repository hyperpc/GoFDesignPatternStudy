using System;

namespace ch0403_Composite.Document
{
    public class Page : CompositeDocumentElement
    {
        public override void Draw()
        {
            Console.WriteLine("Page Content : ");
            base.Draw();
        }
    }
}
