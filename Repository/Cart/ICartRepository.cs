namespace Sneakerz.Repository.Cart;

public interface ICartRepository : IRepository<Entity.Cart, int>
{
    public int AddToCart(Entity.Cart cart);
    public Entity.Cart GetCart(int userId);
}