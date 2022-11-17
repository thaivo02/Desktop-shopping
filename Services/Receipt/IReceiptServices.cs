using Sneakerz.Model;

namespace Sneakerz.Services.Receipt;

public interface IReceiptServices
{
    public int AddReceipt(ReceiptDto receiptDto);
}