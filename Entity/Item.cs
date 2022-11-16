using Microsoft.EntityFrameworkCore;

namespace Sneakerz.Entity;

public class Item : AggressiveRoot<string>
{
    public string Name { get; set; }
    public long ReleaseDate { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public double Cash { get; set; }
    public int CaregoryId { get; set; }
}