using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class BasketDetail
    {
        public int BasketDetailId { get; set; }
        public DateTime PurshasedDate { get; set; }
        public string? ManualDescription { get; set; }
        public decimal SGKDiscount { get; set; } = 0.95m;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }

    }
}
