using System;

namespace ch0511_Visitor.CarCheck
{
    public class Engineer : IVisitor
    {
        protected string name;
        public Engineer(string name)
        {
            this.name = name;
        }
        public void visit(Body body)
        {
            Console.WriteLine("检查车身");
        }

        public void visit(Car car)
        {
            Console.WriteLine("{0}检查全车",name);
        }

        public void visit(Engine engine)
        {
            Console.WriteLine("检查发动机");
        }

        public void visit(Wheel wheel)
        {
            Console.WriteLine("检查{0}",wheel.GetName());
        }
    }
}
