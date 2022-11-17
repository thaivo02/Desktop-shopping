using Sneakerz.Model;

namespace Sneakerz.Repository.ReceiptDetail;

public interface IReceiptDetailRepository : IRepository<Entity.ReceiptDetail, int>
{
    public void AddReceptDetail(Entity.ReceiptDetail receiptDetail);
}