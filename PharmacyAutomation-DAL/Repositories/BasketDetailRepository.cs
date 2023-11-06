using PharmacyAutomation_DAL.Context;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Repositories
{
    public class BasketDetailRepository
    {
        ProjectContext db;
        public BasketDetailRepository()
        {
            db = new ProjectContext();
        }

        public void Add(BasketDetail basketDetails)
        {
            db.BasketDetails.Add(basketDetails);
            db.SaveChanges();
        }

        public void Update(BasketDetail basketDetails)
        {
            db.BasketDetails.Update(basketDetails);
            db.SaveChanges();
        }

        public void Delete(BasketDetail basketDetails)
        {
            db.BasketDetails.Remove(basketDetails);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            BasketDetail basketDetails = db.BasketDetails.Where(x => x.BasketDetailId == id).FirstOrDefault();
            db.BasketDetails.Remove(basketDetails);
            db.SaveChanges();
        }

        public List<BasketDetail> GetAll()
        {
            return db.BasketDetails.ToList();
        }

        public string GetDailyIncome()
        {

            var basketDetailsQuery = db.BasketDetails
                    .Where(b => b.PurshasedDate.Day == DateTime.Now.Day && b.PurshasedDate.Date.Month == DateTime.Now.Date.Month && b.PurshasedDate.Date.Year == DateTime.Now.Date.Year);

            var medicineRepository = new MedicineRepostitory();
            var medicinesOnGivenDate = medicineRepository.GetAll()
                .Join(
                    basketDetailsQuery,
                    m => m.MedicineId,
                    b => b.MedicineId,
                    (m, b) => new
                    {
                        Quantity = b.Quantity,
                        SalePrice = m.SalePrice,
                        PurchasedDate = b.PurshasedDate
                    })
                .ToList();

            var totalCostOnGivenDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Date.Day == DateTime.Now.Date.Day && b.PurchasedDate.Date.Month == DateTime.Now.Date.Month && b.PurchasedDate.Date.Year == DateTime.Now.Date.Year).Sum(mb => mb.Quantity * mb.SalePrice);

            return totalCostOnGivenDate.ToString("C");
        }

        public string GetMonthlyIncome()
        {
            var basketDetailsQuery = db.BasketDetails
                    .Where(b => b.PurshasedDate.Date.Month == DateTime.Now.Date.Month && b.PurshasedDate.Date.Year == DateTime.Now.Date.Year);

            var medicineRepository = new MedicineRepostitory();
            var medicinesOnGivenDate = medicineRepository.GetAll()
                .Join(
                    basketDetailsQuery,
                    m => m.MedicineId,
                    b => b.MedicineId,
                    (m, b) => new
                    {
                        Quantity = b.Quantity,
                        SalePrice = m.SalePrice,
                        PurchasedDate = b.PurshasedDate
                    })
                .ToList();

            var totalCostOnGivenDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Date.Month == DateTime.Now.Date.Month && b.PurchasedDate.Date.Year == DateTime.Now.Date.Year).Sum(mb => mb.Quantity * mb.SalePrice);

            return totalCostOnGivenDate.ToString("C");


        }

        public string GetDailyProfit(DateTime date)
        {

            var medicineRepository = new MedicineRepostitory();

            var medicinesOnGivenDate = medicineRepository.GetAll()
                    .Join(
                        db.BasketDetails,
                        m => m.MedicineId,
                        b => b.MedicineId,
                        (m, b) => new
                        {
                            Quantity = b.Quantity,
                            TotalPrice = b.Quantity * m.SalePrice,
                            PurchasedDate = b.PurshasedDate,
                            TotalBuyPrice = b.Quantity * m.BuyPrice
                        })
                    .ToList();
            var totalSalesForCurrentDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Day == date.Day && b.PurchasedDate.Date.Month == date.Date.Month && b.PurchasedDate.Date.Year == date.Date.Year).Sum(b => b.TotalPrice);


            var totalCostOnGivenDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Date.Day == date.Date.Day && b.PurchasedDate.Date.Month == date.Date.Month && b.PurchasedDate.Date.Year == date.Date.Year).Sum(mb => mb.TotalBuyPrice);

            decimal dailyProfit = totalSalesForCurrentDate - totalCostOnGivenDate;

            return dailyProfit.ToString("C");

        }

        public string GetMonthlyProfit(DateTime date)
        {
            var medicineRepository = new MedicineRepostitory();

            var medicinesOnGivenDate = medicineRepository.GetAll()
                    .Join(
                        db.BasketDetails,
                        m => m.MedicineId,
                        b => b.MedicineId,
                        (m, b) => new
                        {
                            Quantity = b.Quantity,
                            TotalPrice = b.Quantity * m.SalePrice,
                            PurchasedDate = b.PurshasedDate,
                            TotalBuyPrice = b.Quantity * m.BuyPrice
                        })
                    .ToList();
            var totalSalesForCurrentDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Date.Month == date.Date.Month && b.PurchasedDate.Date.Year == date.Date.Year).Sum(b => b.TotalPrice);


            var totalCostOnGivenDate = medicinesOnGivenDate.Where(b => b.PurchasedDate.Date.Month == date.Date.Month && b.PurchasedDate.Date.Year == date.Date.Year).Sum(mb => mb.TotalBuyPrice);

            decimal dailyProfit = totalSalesForCurrentDate - totalCostOnGivenDate;

            return dailyProfit.ToString("C");
        }

    }
}
