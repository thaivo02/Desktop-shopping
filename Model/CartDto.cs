using Sneakerz.Entity;

namespace Sneakerz.Model;

public class CartDto
{
    public Cart Cart { get; set; }
    public List<CartDetail> CartDetails { get; set; }
}