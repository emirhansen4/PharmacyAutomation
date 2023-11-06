using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class EmployeeRepository
    {
        ProjectContext db;
        public EmployeeRepository()
        {
            db = new ProjectContext();
        }

        public void Add(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }

        public void Update(Employee employee)
        {
            db.Employees.Update(employee);
            db.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Employee employee = db.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return db.Employees.Where(e => e.AccountId == id).FirstOrDefault();
        }

        public List<string> GetNames()
        {
            return db.Employees.Select(a => a.Name).ToList();
        }
    }
}
