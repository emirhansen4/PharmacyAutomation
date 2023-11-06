using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class EmployeeLogRepository
    {
        ProjectContext db;
        public EmployeeLogRepository()
        {
            db = new ProjectContext();
        }

        public void Add(EmployeeLog employeeLog)
        {
            db.EmployeeLogs.Add(employeeLog);
            db.SaveChanges();
        }

        public void Update(EmployeeLog employeeLog)
        {
            db.EmployeeLogs.Update(employeeLog);
            db.SaveChanges();
        }

        public void Delete(EmployeeLog employeeLog)
        {
            db.EmployeeLogs.Remove(employeeLog);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            EmployeeLog employeeLog = db.EmployeeLogs.Where(x => x.EmployeeLogId == id).FirstOrDefault();
            db.EmployeeLogs.Remove(employeeLog);
            db.SaveChanges();
        }

        public List<EmployeeLog> GetAll()
        {
            return db.EmployeeLogs.ToList();
        }

        public List<EmployeeLog> GetByEmoloyeeId(int id)
        {
            return db.EmployeeLogs.Where(e => e.EmployeeId == id).ToList();
        }
    }
}
