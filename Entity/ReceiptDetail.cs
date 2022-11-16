using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneakerz.Entity
{
    public class ReceiptDetail : AggressiveRoot<int>
    {
        public int Amount { get; set; }
        public int ItemId { get; set; }
        public int ReceiptId { get; set; }
    }
}
