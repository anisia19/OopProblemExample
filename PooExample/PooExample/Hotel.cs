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
}