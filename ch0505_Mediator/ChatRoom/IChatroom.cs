namespace ch0505_Mediator.ChatRoom
{
    interface IChatroom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}
