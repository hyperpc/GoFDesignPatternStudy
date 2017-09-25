namespace ch0406_Flyweight.Editor
{
    class Client
    {
        public static void Test()
        {
            char[] documents = { 'A', 'B', 'Z', 'Z', 'A', 'A' };
            CharacterFactory f = new CharacterFactory();
            int pointSize = 12;
            foreach (char c in documents)
            {
                Character character = f.GetCharacter(c);
                character.Draw(pointSize);
            }
        }
    }
}
