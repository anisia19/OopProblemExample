using System.Net.Sockets;

namespace PooExample;
public class Program
{ 
    public static void Main(string[] args)
    {
        Hotel hotel = new Hotel("Suricata", "United States, Long Island, My dad's house");

        List<Room> rooms = new List<Room>()
        {
            new StandardRoom(1234, 1, 123, true),
            new StandardRoom(8888, 2, 123, false),
            
            // invalid room for checking the functionality of the CheckingRoomDetails
            new SuiteRoom(12459, 3, 900, "Jacuzzi"),
            
            new SuiteRoom(1578, 4, 456, "Piscina")
        };
        
        foreach (Room room in rooms)
        {
            try
            {
                room.CheckRoomDetails();
                hotel.AddRoom(room);
            }
            catch (InvalidRoomNumber ex)
            {
                Console.WriteLine(ex);
            }
            catch (InvalidTariff ex)
            {
                Console.WriteLine(ex);
            }
            catch (InvalidCapacity ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        Console.WriteLine(hotel);
    }
}

