namespace Sneakerz.Repository.Cart;

public class CartRepository : Repository<Entity.Cart, int>,ICartRepository
{
    public CartRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}