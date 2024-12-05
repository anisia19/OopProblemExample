namespace PooExample;

public class StandardRoom : Room
{
    protected bool Availability { get; set; }

    public StandardRoom(int roomNumber, int capacity, int tarrif, bool availability) 
        : base(roomNumber, capacity, tarrif)
    {
        Availability = availability;
    }

    public override void CheckAvailability()
    {
        if (Availability == true)
        {
            Console.WriteLine($"Room {RoomNumber} is available");
        }
        else
        {
            Console.WriteLine($"Room {RoomNumber} is not available");
        }
    }
}