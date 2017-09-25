using System;

namespace ch0403_Composite.Document
{
    class Character:IDocumentElement
    {
        int x, y;
        public Character(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine(string.Format("Draw a character at {0},{1}", x, y));
        }
    }
}
