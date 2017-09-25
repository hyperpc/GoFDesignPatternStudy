using System;

namespace ch0406_Flyweight.Editor
{
    class CharacterZ : Character
    {
        public CharacterZ()
        {
            this.symbol = 'Z';
            this.height = 100;
            this.width = 100;
            this.ascent = 62;
            this.descent = 0;
        }
        public override void Draw(int pointSize)
        {
            this.pointSize = pointSize;
            Console.Write(this.symbol);
        }
    }
}
