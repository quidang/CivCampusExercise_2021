namespace CivCampusExercise_2021.models
{
    public class Room
    {
        public uint Capacity { get; set; }
        public int RoomNo { get; set; }
        public string RoomId { get; set; }

        public Room(uint capacity, int roomNo, string roomId)
        {
            Capacity = capacity;
            RoomNo = roomNo;
            RoomId = roomId;
        }

    }
}