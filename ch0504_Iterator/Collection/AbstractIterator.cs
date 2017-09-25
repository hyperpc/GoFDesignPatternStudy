namespace ch0504_Iterator.Collection
{
    abstract class AbstractIterator
    {
        public abstract Item First();
        public abstract Item Next();
        public abstract bool IsDone();
        public abstract Item CurrentItem();
    }
}
