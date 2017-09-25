using System.Collections.Generic;

namespace HouseBuilder
{
    public class SingleFamilyHome : IHouse
    {
        private bool mblnBackyard;
        private List<Room> Rooms;
        public SingleFamilyHome()
        {
            Rooms = new List<Room>();

            Room room1 = new Room();
            room1.RoomName = "Master Room";
            Rooms.Add(room1);

            Room room2 = new Room();
            room2.RoomName = "Second Room";
            Rooms.Add(room2);

            Room room3 = new Room();
            room3.RoomName = "Third Room";
            Rooms.Add(room3);

            Room room4 = new Room();
            room4.RoomName = "Living Room";
            Rooms.Add(room4);

            Room room5 = new Room();
            room5.RoomName = "Guest Room";
            Rooms.Add(room5);

            mblnBackyard = true;
        }

        public string Description()
        {
            string description;
            description = string.Format("这是一间公寓，有{0}间房间，\n这间公寓有后院", Rooms.Count);
            for (int i = 0; i < Rooms.Count; i++)
                description += string.Format("\n房间{0}\t{1}", i + 1, Rooms[i].RoomName);

            return description;
        }

        public bool GetBackyard()
        {
            return mblnBackyard;
        }

        public long NoOfRooms()
        {
            return Rooms.Count;
        }
    }
}
