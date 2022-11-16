namespace Sneakerz.Repository.CartDetail;

public class CartDetailRepository : Repository<Entity.CartDetail, int>, ICartDetailRepository
{
    public CartDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public List<Entity.CartDetail> GetCartDetail(int cartId)
    {
        var cardDetails = GetAll().Where(cd => cd.CardId == cartId).ToList();
        return cardDetails;
    }
}