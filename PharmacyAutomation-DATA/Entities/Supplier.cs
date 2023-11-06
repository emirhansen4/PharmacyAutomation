using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class Supplier
    {
        public Supplier()
        {
            Medicines = new List<Medicine>();
        }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Medicine> Medicines { get; set; }
    }
}
