using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class PatientRepostitory
    {
        ProjectContext db;
        public PatientRepostitory()
        {
            db = new ProjectContext();
        }

        public void Add(Patient patient)
        {
            db.Patients.Add(patient);
            db.SaveChanges();
        }

        public void Update(Patient patient)
        {
            db.Patients.Update(patient);
            db.SaveChanges();
        }

        public void Delete(Patient patient)
        {
            db.Patients.Remove(patient);
            db.SaveChanges();
        }

        public void Delete(string id)
        {
            Patient patient = db.Patients.Where(x => x.PatientId == id).FirstOrDefault();
            db.Patients.Remove(patient);
            db.SaveChanges();
        }

        public List<Patient> GetAll()
        {
            return db.Patients.ToList();
        }

        public bool SgkIsValid(int ıd)
        {
            return Convert.ToBoolean((from p in db.Patients
                                      join b in db.Baskets on p.PatientId equals b.PatientId
                                      join bd in db.BasketDetails on b.BasketID equals bd.BasketId
                                      where bd.MedicineId == ıd
                                      select new { p.SGKValid }).FirstOrDefault());
        }

    }
}
