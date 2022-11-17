using Sneakerz.Model;
using Sneakerz.Repository.ReceiptDetail;

namespace Sneakerz.Repository.Receipt;

public class ReceiptRepository : Repository<Entity.Receipt, int>, IReceiptRepository
{
    private readonly IReceiptDetailRepository _receiptDetailRepository;
    public ReceiptRepository(
        ApplicationDbContext dbContext,
        IReceiptDetailRepository receiptDetailRepository
        ) : base(dbContext)
    {
        _receiptDetailRepository = receiptDetailRepository;
    }

    public void AddRecept(ReceiptDto receiptDto)
    {
        Add(receiptDto.Receipt);
        receiptDto.ReceiptDetails.ForEach(rd =>
        {
            _receiptDetailRepository.AddReceptDetail(rd);
        });
        SaveChanges();
    }
}