namespace ch0505_Mediator.ChatRoom
{
    public class Client
    {
        public static void Test()
        {
            Chatroom c = new Chatroom();
            Participant George = new BeatleParticipant("George");
            Participant Paul = new BeatleParticipant("Paul");
            Participant Ringo = new BeatleParticipant("Ringo");
            Participant John = new BeatleParticipant("John");
            Participant Yoko = new NonBeatleParticipant("Yoko");
            c.Register(George);
            c.Register(Paul);
            c.Register(Ringo);
            c.Register(John);
            c.Register(Yoko);

            Yoko.Send("John", "Hi John!");
            Paul.Send("Ringo", "All you need is love");
            Ringo.Send("George", "My sweet Lord");
            Paul.Send("John", "Can't you buy me love");
            John.Send("Yoko", "My sweet love");
            
        }
    }
}
