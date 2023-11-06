using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entities
{
    public class EmployeeLog
    {
        public int EmployeeLogId { get; set; }

        public DateTime EnterTime { get; set; }

        public DateTime ExitTime { get; set; }

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
