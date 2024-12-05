namespace PooExample;

public abstract class Room
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
    public abstract void CheckAvailability();
    //verificarea conditiilor (nr camera, capacitate, tarif)
    public void CheckRoomDetails()
    {
        if (RoomNumber >= 10000 || RoomNumber < 1000)
        {
            throw new InvalidRoomNumber();
        }

        if (Capacity < 1 || Capacity > 5)
        {
           throw new InvalidCapacity();
        }

        if (Tarrif < 0)
        {
            throw new InvalidTariff();
        }
    }

    public override string ToString()
    {
        return $"Room Number {RoomNumber}, Capacity {Capacity}, Tarrif {Tarrif}";
    }
    
    public abstract void Something();
}