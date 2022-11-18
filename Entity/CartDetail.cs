namespace Sneakerz.Entity;

public class CartDetail : AggressiveRoot<int>
{
    public int Amount { get; set; }
    public string ItemId { get; set; }
    public int CardId { get; set; }
    public double Size { get; set; }
}