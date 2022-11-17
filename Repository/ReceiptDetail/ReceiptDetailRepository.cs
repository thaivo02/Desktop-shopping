using Sneakerz.Model;

namespace Sneakerz.Repository.ReceiptDetail;

public class ReceiptDetailRepository : Repository<Entity.ReceiptDetail, int>, IReceiptDetailRepository
{
    public ReceiptDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }

    public void AddReceptDetail(Entity.ReceiptDetail receiptDetail)
    {
        Add(receiptDetail);
        SaveChanges();
    }
};