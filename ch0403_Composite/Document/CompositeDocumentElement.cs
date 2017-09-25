using System.Collections.Generic;

namespace ch0403_Composite.Document
{
    public class CompositeDocumentElement : IDocumentElement
    {
        private List<IDocumentElement> documents = new List<IDocumentElement>();
        public virtual void Draw()
        {
            foreach (IDocumentElement e in documents)
                e.Draw();
        }

        public void Add(IDocumentElement doc)
        {
            documents.Add(doc);
        }
    }
}
