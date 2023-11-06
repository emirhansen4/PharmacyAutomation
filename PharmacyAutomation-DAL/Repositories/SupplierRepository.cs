using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class SupplierRepository
    {
        ProjectContext db;
        public SupplierRepository()
        {
            db = new ProjectContext();
        }

        public void Add(Supplier supplier)
        {
            db.Suppliers.Add(supplier);
            db.SaveChanges();
        }

        public void Update(Supplier supplier)
        {
            db.Suppliers.Update(supplier);
            db.SaveChanges();
        }

        public void Delete(Supplier supplier)
        {
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Supplier supplier = db.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault();
            db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }

        public List<Supplier> GetAll()
        {
            return db.Suppliers.ToList();
        }


        public List<string> GetCompanyNames()
        {
            return db.Suppliers.Select(a => a.Name).ToList();
        }

        public int GetID(string CompanyName)
        {
            return db.Suppliers.FirstOrDefault(a => a.Name == CompanyName).SupplierId;
        }

        public object GetSelectedSupplier(int supplierId)
        {
            return db.Suppliers.FirstOrDefault(a => a.SupplierId == supplierId).Name;
        }

        public Supplier GetSupplier(int ıd)
        {
            return db.Suppliers.FirstOrDefault(x => x.SupplierId == ıd);

        }

    }
}
