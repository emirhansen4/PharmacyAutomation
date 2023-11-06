using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class Account
    {
        public int AccountId { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsValid { get; set; }
        public Employee Employee { get; set; }
    }
}
