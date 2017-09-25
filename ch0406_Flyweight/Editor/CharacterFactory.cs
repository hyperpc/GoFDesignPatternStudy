using System.Collections;

namespace ch0406_Flyweight.Editor
{
    class CharacterFactory
    {
        private Hashtable charaters = new Hashtable();
        public Character GetCharacter(char key)
        {
            Character character = (Character)charaters[key];
            if(character==null)
                switch (key)
                {
                    case 'A':
                        character = new CharacterA();
                        break;
                    case 'B':
                        character = new CharacterB();
                        break;
                    case 'Z':
                        character = new CharacterZ();
                        break;
                }

            return character;
        }
    }
}
