namespace ch0506_Memento.SalesProspect
{
    class ProspectMemory
    {
        private Memento memento;
        public Memento Memento
        {
            set { memento = value; }
            get { return memento; }
        }
    }
}
