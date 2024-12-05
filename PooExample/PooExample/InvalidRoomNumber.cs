namespace PooExample;

public class InvalidRoomNumber : Exception
{
    public InvalidRoomNumber() : base("Invalid Room Number!") { }
}