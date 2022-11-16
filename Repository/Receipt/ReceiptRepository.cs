namespace Sneakerz.Repository.Receipt;

public class ReceiptRepository : Repository<Entity.Receipt, int>, IReceiptRepository
{
    public ReceiptRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}