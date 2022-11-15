using Microsoft.EntityFrameworkCore;

namespace Sneakerz.Entity;

public class Item : AggressiveRoot
{
    public string Name { get; set; }
    public long ReleaseDate { get; set; }
    public string Description { get; set; }
    public double Cash { get; set; }
}