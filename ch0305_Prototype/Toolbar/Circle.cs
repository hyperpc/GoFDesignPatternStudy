using System;

namespace Toolbar
{
    public class Circle : IToolbar
    {
        public object Clone()
        {
            object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Clone not support");
            }
            return clone;
        }

        public void Draw()
        {
            Console.WriteLine("Draw a circle");
        }

        public string GetName()
        {
            return "Circle";
        }
    }
}
