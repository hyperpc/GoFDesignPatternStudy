using System;

namespace ch0511_Visitor.KPI
{
    class IncomeVisitor : Visitor
    {
        public override void Visit(Element element)
        {
            Employee employee = (Employee)element;
            employee.Income *= 1.10;
            Console.WriteLine("{0}新的薪水:{1:C}", employee.Name, employee.Income);
        }
    }
}
