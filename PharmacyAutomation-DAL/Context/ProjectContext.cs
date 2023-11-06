using Microsoft.EntityFrameworkCore;
using PharmacyAutomation_DATA.Entities;
using PharmacyAutomation_DATA.Entity;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyAutomation_DAL.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<BasketDetail> BasketDetails { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<EmployeeLog> EmployeeLogs { get; set; }

        string[] medicine = { "Ciprofloxacin", "Ibuprofen", "Paracetamol", "Aspirin", "Dolerex", "Parol", "Ventolin", "Amoklavin", "Nurofen", "Cipro", "Voltaren" };
        public static string HashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-M7Q6KH9;Database=Pharmacy1DB;User Id=sa;Password=123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                new Account() { AccountId = 1, IsAdmin = true, IsValid = true, Password = HashPassword("1234"), Mail = "John@hotmail.com" }
                );
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { EmployeeId = 1, AccountId = 1, Adress = "Eczane", Gender = PharmacyAutomation_DATA.Enums.Gender.Male, Name = "John Doe" }
                );

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier() { SupplierId = 1, Name = "Eczacıbaşı", Adress = "İstanbul" },
                new Supplier() { SupplierId = 2, Name = "Sekçuk Ecza Deposu", Adress = "Ankara" }
                );

            modelBuilder.Entity<Medicine>().HasData(
                new Medicine
                {
                    MedicineId = 1,
                    Name = "Dolerex",
                    StockCount = 25,
                    ExpireDate = new DateTime(2023, 11, 27),
                    ReceiptType = ReceiptType.Beyaz,
                    BuyPrice = 10.50m,
                    SalePrice = 12.25m,
                    SupplierId = 1,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 2,
                    Name = "Paracetamol",
                    StockCount = 50,
                    ExpireDate = new DateTime(2024, 5, 15),
                    ReceiptType = ReceiptType.Beyaz,
                    BuyPrice = 5.75m,
                    SalePrice = 7.00m,
                    SupplierId = 2,
                    Coverage = false
                },
                new Medicine
                {
                    MedicineId = 3,
                    Name = "Ibuprofen",
                    StockCount = 30,
                    ExpireDate = new DateTime(2023, 10, 10),
                    ReceiptType = ReceiptType.Kırmızı,
                    BuyPrice = 8.25m,
                    SalePrice = 10.00m,
                    SupplierId = 1,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 4,
                    Name = "Ciprofloxacin",
                    StockCount = 20,
                    ExpireDate = new DateTime(2023, 12, 31),
                    ReceiptType = ReceiptType.Yeşil,
                    BuyPrice = 12.00m,
                    SalePrice = 15.50m,
                    SupplierId = 1,
                    Coverage = true
                },
              
                new Medicine
                {
                    MedicineId = 5,
                    Name = "Aspirin",
                    StockCount = 40,
                    ExpireDate = new DateTime(2023, 9, 30),
                    ReceiptType = ReceiptType.Mor,
                    BuyPrice = 6.00m,
                    SalePrice = 8.00m,
                    SupplierId = 1,
                    Coverage = false
                },
              
                new Medicine
                {
                    MedicineId = 6,
                    Name = "Parol",
                    StockCount = 60,
                    ExpireDate = new DateTime(2024, 3, 15),
                    ReceiptType = ReceiptType.Beyaz,
                    BuyPrice = 4.50m,
                    SalePrice = 5.75m,
                    SupplierId = 2,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 7,
                    Name = "Ventolin",
                    StockCount = 15,
                    ExpireDate = new DateTime(2023, 8, 20),
                    ReceiptType = ReceiptType.Kırmızı,
                    BuyPrice = 15.00m,
                    SalePrice = 18.00m,
                    SupplierId = 2,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 8,
                    Name = "Amoklavin",
                    StockCount = 35,
                    ExpireDate = new DateTime(2023, 9, 15),
                    ReceiptType = ReceiptType.Mor,
                    BuyPrice = 7.25m,
                    SalePrice = 9.50m,
                    SupplierId = 2,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 9,
                    Name = "Nurofen",
                    StockCount = 48,
                    ExpireDate = new DateTime(2024, 2, 28),
                    ReceiptType = ReceiptType.Beyaz,
                    BuyPrice = 6.75m,
                    SalePrice = 8.25m,
                    SupplierId = 1,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 10,
                    Name = "Cipro",
                    StockCount = 22,
                    ExpireDate = new DateTime(2023, 11, 10),
                    ReceiptType = ReceiptType.Kırmızı,
                    BuyPrice = 9.75m,
                    SalePrice = 11.00m,
                    SupplierId = 1,
                    Coverage = true
                },
                new Medicine
                {
                    MedicineId = 11,
                    Name = "Voltaren",
                    StockCount = 30,
                    ExpireDate = new DateTime(2023, 10, 5),
                    ReceiptType = ReceiptType.Yeşil,
                    BuyPrice = 11.25m,
                    SalePrice = 13.75m,
                    SupplierId = 1,
                    Coverage = true
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
