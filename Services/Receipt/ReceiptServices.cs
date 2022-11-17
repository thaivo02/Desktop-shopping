using Sneakerz.Model;
using Sneakerz.Repository.Receipt;

namespace Sneakerz.Services.Receipt;

public class ReceiptServices : IReceiptServices
{
    private readonly IReceiptRepository _receiptRepository;

    public ReceiptServices(IReceiptRepository receiptRepository)
    {
        _receiptRepository = receiptRepository;
    }

    public int AddReceipt(ReceiptDto receiptDto)
    {
        _receiptRepository.AddRecept(receiptDto);
        return receiptDto.Receipt.Id;
    }
}