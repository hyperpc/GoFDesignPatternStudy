namespace ch0504_Iterator.Collection
{
    class Iterator : AbstractIterator
    {
        private Collection collection;
        private int current = 0;
        private int step = 1;
        public Iterator(Collection collection)
        {
            this.collection = collection;
        }
        public int Step
        {
            get { return step; }
            set { step = value; }
        }
        public override Item CurrentItem()
        {
            return (Item)collection[current];
        }

        public override Item First()
        {
            current = 0;
            return (Item)collection[current];
        }

        public override bool IsDone()
        {
            return current >= collection.Count ? true : false;
        }

        public override Item Next()
        {
            current += step;
            if (!IsDone())
                return (Item)collection[current];
            else
                return null;
        }
    }
}
