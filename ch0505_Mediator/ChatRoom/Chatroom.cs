using System.Collections;

namespace ch0505_Mediator.ChatRoom
{
    class Chatroom : IChatroom
    {
        private Hashtable participants = new Hashtable();
        public void Register(Participant participant)
        {
            if (participants[participant.Name] == null)
                participants[participant.Name] = participant;
            participant.Chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            Participant pto = (Participant)participants[to];
            if (pto != null)
                pto.Receive(from, message);
        }
    }
}
