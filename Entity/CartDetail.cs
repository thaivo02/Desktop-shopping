namespace Sneakerz.Entity;

public class CartDetail : AggressiveRoot<int>
{
    public int Amount { get; set; }
    public int ItemId { get; set; }
    public int CardId { get; set; }
}