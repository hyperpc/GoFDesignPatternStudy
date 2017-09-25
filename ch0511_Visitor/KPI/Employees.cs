using System.Collections;

namespace ch0511_Visitor.KPI
{
    class Employees
    {
        private ArrayList employees = new ArrayList();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Employee e in employees)
                e.Accept(visitor);
        }
    }
}
