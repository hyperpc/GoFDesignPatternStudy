using System;

namespace ch0505_Mediator.ChatRoom
{
    class BeatleParticipant : Participant
    {
        public BeatleParticipant(string name) : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}
