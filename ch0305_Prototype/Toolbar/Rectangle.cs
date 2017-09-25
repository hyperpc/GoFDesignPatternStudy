using System;

namespace Toolbar
{
    public class Rectangle : IToolbar
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
            Console.WriteLine("Draw a rectangle");
        }

        public string GetName()
        {
            return "Rectangle";
        }
    }
}
