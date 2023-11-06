using PharmacyAutomation_DATA.Entity;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entities
{
    public class Patient
    {
        public Patient()
        {
            Baskets = new List<Basket>();
        }
        public string PatientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool SGKValid { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public List<Basket> Baskets { get; set; }


    }
}
