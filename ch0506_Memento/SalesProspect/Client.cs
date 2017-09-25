namespace ch0506_Memento.SalesProspect
{
    class Client
    {
        public static void Test()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "张主任";
            s.Phone = "(020)12560990";
            s.Budget = 25000.0;
            s.Show();
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            s.Name = "陈经理";
            s.Phone = "(020)12097111";
            s.Budget = 1000000.0;
            s.Show();
            s.RestoreMemento(m.Memento);
            s.Show();
        }
    }
}
