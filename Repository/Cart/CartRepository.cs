namespace Sneakerz.Repository.Cart;

public class CartRepository : Repository<Entity.Cart, int>, ICartRepository
{
    public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public int AddToCart(Entity.Cart cart)
    {
        Add(cart);
        SaveChanges();
        return cart.Id;
    }
}