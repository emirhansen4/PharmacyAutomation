using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DATA.Entity
{
    public class Employee
    {
        public Employee()
        {
            EmployeeLogs = new List<EmployeeLog>();
            Baskets = new List<Basket>();
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string? Telephone { get; set; }
        public string? Adress { get; set; }
        public Gender Gender { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        public List<Basket> Baskets { get; set; }
        public List<EmployeeLog> EmployeeLogs { get; set; }

    }
}
