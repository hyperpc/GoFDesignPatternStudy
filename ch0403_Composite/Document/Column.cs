using System;

namespace ch0403_Composite.Document
{
    public class Column:CompositeDocumentElement
    {
        public override void Draw()
        {
            Console.WriteLine("Column Content : ");
            base.Draw();
        }
    }
}
