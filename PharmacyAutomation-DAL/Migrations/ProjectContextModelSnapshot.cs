﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyAutomation_DAL.Context;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.EmployeeLog", b =>
                {
                    b.Property<int>("EmployeeLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeLogId"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnterTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExitTime")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeLogId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeLogs");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.Patient", b =>
                {
                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SGKValid")
                        .HasColumnType("bit");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountId"), 1L, 1);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccountId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1,
                            IsAdmin = true,
                            IsValid = true,
                            Mail = "John@hotmail.com",
                            Password = "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4"
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.Property<int>("BasketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketID"), 1L, 1);

                    b.Property<string>("DoctorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("PatientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("ReceipDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReceiptType")
                        .HasColumnType("int");

                    b.Property<string>("RecipeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BasketID");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("PatientId");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.BasketDetail", b =>
                {
                    b.Property<int>("BasketDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BasketDetailId"), 1L, 1);

                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<string>("ManualDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PurshasedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("SGKDiscount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BasketDetailId");

                    b.HasIndex("BasketId");

                    b.HasIndex("MedicineId");

                    b.ToTable("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            AccountId = 1,
                            Adress = "Eczane",
                            Gender = 0,
                            Name = "John Doe"
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"), 1L, 1);

                    b.Property<decimal>("BuyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Coverage")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceiptType")
                        .HasColumnType("int");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("StockCount")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("MedicineId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            BuyPrice = 10.50m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dolerex",
                            ReceiptType = 0,
                            SalePrice = 12.25m,
                            StockCount = 25,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 2,
                            BuyPrice = 5.75m,
                            Coverage = false,
                            ExpireDate = new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Paracetamol",
                            ReceiptType = 0,
                            SalePrice = 7.00m,
                            StockCount = 50,
                            SupplierId = 2
                        },
                        new
                        {
                            MedicineId = 3,
                            BuyPrice = 8.25m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ibuprofen",
                            ReceiptType = 1,
                            SalePrice = 10.00m,
                            StockCount = 30,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 4,
                            BuyPrice = 12.00m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ciprofloxacin",
                            ReceiptType = 2,
                            SalePrice = 15.50m,
                            StockCount = 20,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 5,
                            BuyPrice = 6.00m,
                            Coverage = false,
                            ExpireDate = new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aspirin",
                            ReceiptType = 4,
                            SalePrice = 8.00m,
                            StockCount = 40,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 6,
                            BuyPrice = 4.50m,
                            Coverage = true,
                            ExpireDate = new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Parol",
                            ReceiptType = 0,
                            SalePrice = 5.75m,
                            StockCount = 60,
                            SupplierId = 2
                        },
                        new
                        {
                            MedicineId = 7,
                            BuyPrice = 15.00m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ventolin",
                            ReceiptType = 1,
                            SalePrice = 18.00m,
                            StockCount = 15,
                            SupplierId = 2
                        },
                        new
                        {
                            MedicineId = 8,
                            BuyPrice = 7.25m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Amoklavin",
                            ReceiptType = 4,
                            SalePrice = 9.50m,
                            StockCount = 35,
                            SupplierId = 2
                        },
                        new
                        {
                            MedicineId = 9,
                            BuyPrice = 6.75m,
                            Coverage = true,
                            ExpireDate = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nurofen",
                            ReceiptType = 0,
                            SalePrice = 8.25m,
                            StockCount = 48,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 10,
                            BuyPrice = 9.75m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Cipro",
                            ReceiptType = 1,
                            SalePrice = 11.00m,
                            StockCount = 22,
                            SupplierId = 1
                        },
                        new
                        {
                            MedicineId = 11,
                            BuyPrice = 11.25m,
                            Coverage = true,
                            ExpireDate = new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Voltaren",
                            ReceiptType = 2,
                            SalePrice = 13.75m,
                            StockCount = 30,
                            SupplierId = 1
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            Adress = "İstanbul",
                            Name = "Eczacıbaşı"
                        },
                        new
                        {
                            SupplierId = 2,
                            Adress = "Ankara",
                            Name = "Sekçuk Ecza Deposu"
                        });
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.EmployeeLog", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Employee", "Employee")
                        .WithMany("EmployeeLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Employee", "Employee")
                        .WithMany("Baskets")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyAutomation_DATA.Entities.Patient", "Patient")
                        .WithMany("Baskets")
                        .HasForeignKey("PatientId");

                    b.Navigation("Employee");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.BasketDetail", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Basket", "Basket")
                        .WithMany("BasketDetails")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmacyAutomation_DATA.Entity.Medicine", "Medicine")
                        .WithMany("BasketDetails")
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Basket");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Account", "Account")
                        .WithOne("Employee")
                        .HasForeignKey("PharmacyAutomation_DATA.Entity.Employee", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.HasOne("PharmacyAutomation_DATA.Entity.Supplier", "Supplier")
                        .WithMany("Medicines")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entities.Patient", b =>
                {
                    b.Navigation("Baskets");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Account", b =>
                {
                    b.Navigation("Employee")
                        .IsRequired();
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Basket", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Employee", b =>
                {
                    b.Navigation("Baskets");

                    b.Navigation("EmployeeLogs");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Medicine", b =>
                {
                    b.Navigation("BasketDetails");
                });

            modelBuilder.Entity("PharmacyAutomation_DATA.Entity.Supplier", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
