using Sneakerz.Model;

namespace Sneakerz.Repository.Receipt;

public interface IReceiptRepository : IRepository<Entity.Receipt, int>
{
    public void AddRecept(ReceiptDto receiptDto);

}