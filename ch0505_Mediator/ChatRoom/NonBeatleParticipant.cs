using System;

namespace ch0505_Mediator.ChatRoom
{
    class NonBeatleParticipant : Participant
    {
        public NonBeatleParticipant(string name) : base(name)
        {
        }
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}
