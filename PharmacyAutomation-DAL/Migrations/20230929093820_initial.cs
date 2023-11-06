using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyAutomation_DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SGKValid = table.Column<bool>(type: "bit", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    MedicineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptType = table.Column<int>(type: "int", nullable: false),
                    BuyPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Coverage = table.Column<bool>(type: "bit", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.MedicineId);
                    table.ForeignKey(
                        name: "FK_Medicines_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    BasketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceipDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DoctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceiptType = table.Column<int>(type: "int", nullable: true),
                    RecipeNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.BasketID);
                    table.ForeignKey(
                        name: "FK_Baskets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Baskets_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "PatientId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLogs",
                columns: table => new
                {
                    EmployeeLogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLogs", x => x.EmployeeLogId);
                    table.ForeignKey(
                        name: "FK_EmployeeLogs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketDetails",
                columns: table => new
                {
                    BasketDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurshasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManualDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SGKDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    BasketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.BasketDetailId);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "BasketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "MedicineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "AccountId", "IsAdmin", "IsValid", "Mail", "Password" },
                values: new object[] { 1, true, true, "John@hotmail.com", "03AC674216F3E15C761EE1A5E255F067953623C8B388B4459E13F978D7C846F4" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Adress", "Name" },
                values: new object[] { 1, "İstanbul", "Eczacıbaşı" });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Adress", "Name" },
                values: new object[] { 2, "Ankara", "Sekçuk Ecza Deposu" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "AccountId", "Adress", "Gender", "Name", "Telephone" },
                values: new object[] { 1, 1, "Eczane", 0, "John Doe", null });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "MedicineId", "BuyPrice", "Coverage", "ExpireDate", "Name", "ReceiptType", "SalePrice", "StockCount", "SupplierId" },
                values: new object[,]
                {
                    { 1, 10.50m, true, new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dolerex", 0, 12.25m, 25, 1 },
                    { 2, 5.75m, false, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paracetamol", 0, 7.00m, 50, 2 },
                    { 3, 8.25m, true, new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ibuprofen", 1, 10.00m, 30, 1 },
                    { 4, 12.00m, true, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ciprofloxacin", 2, 15.50m, 20, 1 },
                    { 5, 6.00m, false, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aspirin", 4, 8.00m, 40, 1 },
                    { 6, 4.50m, true, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Parol", 0, 5.75m, 60, 2 },
                    { 7, 15.00m, true, new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ventolin", 1, 18.00m, 15, 2 },
                    { 8, 7.25m, true, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amoklavin", 4, 9.50m, 35, 2 },
                    { 9, 6.75m, true, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nurofen", 0, 8.25m, 48, 1 },
                    { 10, 9.75m, true, new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cipro", 1, 11.00m, 22, 1 },
                    { 11, 11.25m, true, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voltaren", 2, 13.75m, 30, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_BasketId",
                table: "BasketDetails",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_MedicineId",
                table: "BasketDetails",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_EmployeeId",
                table: "Baskets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_PatientId",
                table: "Baskets",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLogs_EmployeeId",
                table: "EmployeeLogs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AccountId",
                table: "Employees",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_SupplierId",
                table: "Medicines",
                column: "SupplierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketDetails");

            migrationBuilder.DropTable(
                name: "EmployeeLogs");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
