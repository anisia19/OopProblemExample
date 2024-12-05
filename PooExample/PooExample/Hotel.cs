namespace PooExample;

public class Hotel
{
    protected string HotelName { get; set; }
    protected string HotelAddress { get; set; }
    protected List<Room> HotelRooms;

    public Hotel(string hotelName, string hotelAddress)
    {
        HotelName = hotelName;
        HotelAddress = hotelAddress;
        HotelRooms = new List<Room>();
    }
    public override string ToString()
    {
        var rez = $"Hotel: {HotelName}, Hotel Address: {HotelAddress}";
        foreach (Room r in HotelRooms)
        {
            rez += $"\n{r.ToString()}";
        }

        return rez;
    }

    public void AddRoom(Room room)
    {
        HotelRooms.Add(room);
    }
}