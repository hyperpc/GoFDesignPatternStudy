using System;

namespace ch0406_Flyweight.Editor
{
    class CharacterA : Character
    {
        public CharacterA()
        {
            this.symbol = 'A';
            this.height = 100;
            this.width = 120;
            this.ascent = 70;
            this.descent = 0;
        }
        public override void Draw(int pointSize)
        {
            this.pointSize = pointSize;
            Console.Write(this.symbol);
        }
    }
}
