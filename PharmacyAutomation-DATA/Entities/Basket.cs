using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class Basket
    {
        public Basket()
        {
            BasketDetails = new List<BasketDetail> ();
        }
        public int BasketID { get; set; }
        public DateTime? ReceipDate { get; set; } = DateTime.Now;
        public string? DoctorName { get; set; }
        public ReceiptType? ReceiptType { get; set; }
        public string? RecipeNumber { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<BasketDetail> BasketDetails { get; set; }
        public string? PatientId { get; set; }
        public Patient Patient { get; set; }


    }
}
