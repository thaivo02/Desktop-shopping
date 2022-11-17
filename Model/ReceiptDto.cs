using Sneakerz.Entity;

namespace Sneakerz.Model;

public class ReceiptDto
{
    public Receipt Receipt { get; set; }
    public List<ReceiptDetail> ReceiptDetails { get; set; }
}