namespace PooExample;

public class StandardRoom : Room
{
    protected bool Availability { get; set; }

    public StandardRoom(int roomNumber, int capacity, int tarrif, bool availability) 
        : base(roomNumber, capacity, tarrif)
    {
        Availability = availability;
    }
}