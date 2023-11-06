using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class Medicine
    {
        public Medicine()
        {
            BasketDetails = new List<BasketDetail>();
        }

        public int MedicineId { get; set; }
        public string Name { get; set; }
        public int StockCount { get; set; }
        public DateTime ExpireDate { get; set; }
        public ReceiptType ReceiptType { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Coverage { get; set; }
        public List<BasketDetail> BasketDetails { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
            