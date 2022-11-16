namespace Sneakerz.Entity;

public class Receipt : AggressiveRoot
{
    public int UserId { get; set; }
    public double Total { get; set; }
    public long Time { get; set; }
}