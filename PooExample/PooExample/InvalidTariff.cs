namespace PooExample;

public class InvalidTariff : Exception
{
    public InvalidTariff() : base("Invalid Tariff!") { }
}