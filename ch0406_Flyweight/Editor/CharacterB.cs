using System;

namespace ch0406_Flyweight.Editor
{
    class CharacterB : Character
    {
        public CharacterB()
        {
            this.symbol = 'B';
            this.height = 100;
            this.width = 140;
            this.ascent = 72;
            this.descent = 0;
        }
        public override void Draw(int pointSize)
        {
            this.pointSize = pointSize;
            Console.Write(this.symbol);
        }
    }
}
