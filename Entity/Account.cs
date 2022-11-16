namespace Sneakerz.Entity;

public class Account : AggressiveRoot<int>
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }
}