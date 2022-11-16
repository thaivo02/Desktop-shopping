namespace Sneakerz.Repository.CartDetail;

public interface ICartDetailRepository : IRepository<Entity.CartDetail, int>
{
    public List<Entity.CartDetail> GetCartDetail(int cartId);
}