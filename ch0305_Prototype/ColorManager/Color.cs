using System;

namespace ColorManager
{
    class Color : ColorPrototype
    {
            private int red,green,blue;
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
        public override ColorPrototype Clone()
        {
            //shallow copy
            return (ColorPrototype)this.MemberwiseClone();
        }
        public void Display()
        {
            Console.WriteLine("RGB values is : {0}, {1}, {2}", red, green, blue);
        }
    }
}
