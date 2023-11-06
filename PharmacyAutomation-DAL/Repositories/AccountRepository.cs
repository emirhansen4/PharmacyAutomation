using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class AccountRepository
    {
        ProjectContext db;
        public AccountRepository()
        {
            db = new ProjectContext();
        }

        public void Add(Account account)
        {
            db.Accounts.Add(account);
            db.SaveChanges();
        }

        public void Update(Account account)
        {
            db.Accounts.Update(account);
            db.SaveChanges();
        }

        public void Delete(Account account)
        {
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Account account = db.Accounts.Where(x => x.AccountId == id).FirstOrDefault();
            db.Accounts.Remove(account);
            db.SaveChanges();
        }

        public List<Account> GetAll()
        {
            return db.Accounts.ToList();
        }

        public Account GetById(int id)
        {
            return db.Accounts.Where(e => e.AccountId == id).FirstOrDefault();
        }

        public Employee GetEmployeeByAccount(int id)
        {
            return db.Employees.Where(e => e.AccountId == id).FirstOrDefault();
        }

    }
}
