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
    public bool CheckRoomDetails()
    {
        if (RoomNumber >= 10000 || RoomNumber < 1000)
        {
            Console.WriteLine("Invalid Room Number");
            return false;
        }

        if (Capacity < 1 || Capacity > 5)
        {
            Console.WriteLine("Invalid Capacity");
            return false;
        }

        if (Tarrif < 0)
        {
            Console.WriteLine("Invalid Tarrif");
            return false;
        }
        return true;
    }

    public override string ToString()
    {
        return $"Room Number {RoomNumber}, Capacity {Capacity}, Tarrif {Tarrif}";
    }
}