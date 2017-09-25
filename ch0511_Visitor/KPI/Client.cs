namespace ch0511_Visitor.KPI
{
    class Client
    {
        public static void Test()
        {
            Employees elist = new KPI.Employees();
            elist.Attach(new Employee("张三", 25000.0, 14));
            elist.Attach(new Employee("李四", 35000.0, 16));
            elist.Attach(new Employee("王五", 45000.0, 21));

            IncomeVisitor v1 = new IncomeVisitor();
            VocationVisitor v2 = new VocationVisitor();
            elist.Accept(v1);
            elist.Accept(v2);
        }
    }
}
