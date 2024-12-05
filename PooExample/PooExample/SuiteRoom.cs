namespace PooExample;

public class SuiteRoom : Room
{
    protected string BonusItem { get; set; }

    public SuiteRoom(int roomNumber, int capacity, int tarrif, string bonusItem) 
        : base(roomNumber, capacity, tarrif)
    {
        BonusItem = bonusItem;
    }

    public override void CheckAvailability()
    {
        Console.WriteLine("Room is only available at the reception desk!");
    }

    public override void Something()
    {
        throw new NotImplementedException();
    }
}