using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class MedicineRepostitory
    {
        ProjectContext db;
        public MedicineRepostitory()
        {
            db = new ProjectContext();
        }

        public void Add(Medicine medicine)
        {
            db.Medicines.Add(medicine);
            db.SaveChanges();
        }

        public void Update(Medicine medicine)
        {
            db.Medicines.Update(medicine);
            db.SaveChanges();
        }

        public void Delete(Medicine medicine)
        {
            db.Medicines.Remove(medicine);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Medicine medicine = db.Medicines.Where(x => x.MedicineId == id).FirstOrDefault();
            db.Medicines.Remove(medicine);
            db.SaveChanges();
        }

        public List<Medicine> GetAll()
        {
            return db.Medicines.ToList();
        }

        public List<Medicine> GetMedicineWithReceiptType(ReceiptType receiptType)
        {
            return db.Medicines.Where(a => a.ReceiptType == receiptType).ToList();
        }

        public Medicine GetMedicine(object tag)
        {
            return db.Medicines.FirstOrDefault(a => a.MedicineId == (int)tag);
        }

        public List<Medicine> GetAllWithoutPrescription()
        {
            return db.Medicines.Where(x => x.ReceiptType == ReceiptType.Beyaz).ToList();
        }

        public List<Medicine> GetContaints(string seachWord)
        {

            return db.Medicines.Where(x => x.Name.Contains(seachWord) && x.ReceiptType == ReceiptType.Beyaz).ToList();
        }

        public Medicine GetFirst(string name)
        {

            return db.Medicines.FirstOrDefault(x => x.Name == name);
        }

    }
}
