using System;

namespace ch0403_Composite.Document
{
    public class Image : IDocumentElement
    {
        int x, y;
        public Image(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine(string.Format("Draw a image at {0},{1}", x, y));
        }
    }
}
