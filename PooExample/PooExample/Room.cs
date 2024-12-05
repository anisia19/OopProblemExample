namespace PooExample;

public class Room
{
    protected int RoomNumber { get; set; }
    protected int Capacity { get; set; }
    protected int Tarrif { get; set; }

    public Room(int roomNumber, int capacity, int tarrif)
    {
        RoomNumber = roomNumber;
        Capacity = capacity;
        Tarrif = tarrif;
    }
}