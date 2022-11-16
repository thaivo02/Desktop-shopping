using Sneakerz.Repository.CartDetail;

namespace Sneakerz.Repository.Cart;

public class CartRepository : Repository<Entity.Cart, int>, ICartRepository
{
    private readonly ICartDetailRepository _cartDetailRepository;
    public CartRepository(
        ApplicationDbContext dbContext, 
        ICartDetailRepository cartDetailRepository
        ) : base(dbContext)
    {
        _cartDetailRepository = cartDetailRepository;
    }

    public int AddToCart(Entity.Cart cart)
    {
        Add(cart);
        SaveChanges();
        return cart.Id;
    }

    public Entity.Cart GetCart(int userId)
    {
        var cart = GetAll().FirstOrDefault(c => c.UserId == userId);
        return cart;
    }
}