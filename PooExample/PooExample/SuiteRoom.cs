namespace PooExample;

public class SuiteRoom : Room
{
    protected string BonusItem { get; set; }

    public SuiteRoom(int roomNumber, int capacity, int tarrif, string bonusItem) 
        : base(roomNumber, capacity, tarrif)
    {
        BonusItem = bonusItem;
    }
}