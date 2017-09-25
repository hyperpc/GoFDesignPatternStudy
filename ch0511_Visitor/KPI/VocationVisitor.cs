using System;

namespace ch0511_Visitor.KPI
{
    class VocationVisitor : Visitor
    {
        public override void Visit(Element element)
        {
            Employee employee = (Employee)element;
            employee.VocationDays += 3;
            Console.WriteLine("{0}新的假期天数:{1}", employee.Name, employee.VocationDays);

        }
    }
}
