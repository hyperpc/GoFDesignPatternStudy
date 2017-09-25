using System.Collections;

namespace ch0504_Iterator.Collection
{
    class Collection : AbstractCollection
    {
        private ArrayList items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }
    }
}
