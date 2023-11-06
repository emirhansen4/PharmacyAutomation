using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class BasketRepositories
    {
        ProjectContext db;
        public BasketRepositories()
        {
            db = new ProjectContext();
        }

        public void Add(Basket basket)
        {
            db.Baskets.Add(basket);
            db.SaveChanges();
        }

        public void Update(Basket basket)
        {
            db.Baskets.Update(basket);
            db.SaveChanges();
        }

        public void Delete(Basket basket)
        {
            db.Baskets.Remove(basket);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Basket basket = db.Baskets.Where(x => x.BasketID == id).FirstOrDefault();
            db.Baskets.Remove(basket);
            db.SaveChanges();
        }

        public List<Basket> GetAll()
        {
            return db.Baskets.ToList();
        }

        public Basket GetBasket(string id)
        {
            return db.Baskets.FirstOrDefault(x => x.PatientId == id);

        }
    }
}
