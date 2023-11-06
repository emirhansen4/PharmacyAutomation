using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entity;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyAutomation_UI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        EmployeeRepository employeeRepository;
        BasketDetailRepository basketDetailRepository;
        MedicineRepostitory medicineRepostitory;
        BasketRepositories basketRepositories;
        private void Reports_Load(object sender, EventArgs e)
        {
            employeeRepository = new EmployeeRepository();
            basketDetailRepository = new BasketDetailRepository();
            medicineRepostitory = new MedicineRepostitory();
            basketRepositories = new BasketRepositories();
            cbEmployees.DataSource = employeeRepository.GetNames();
            rbMonthly.Checked = true;


            lblDailyIncome.Text = basketDetailRepository.GetDailyIncome();

            lblMonthlyIncome.Text = basketDetailRepository.GetMonthlyIncome();

            lblDailyProfit.Text = basketDetailRepository.GetDailyProfit(dtpDate.Value);
            lblMonthlyProfit.Text = basketDetailRepository.GetMonthlyProfit(dtpDate.Value);



            cbEmployees.SelectedIndex = -1;


        }

        private void FillTheMedicineList()
        {
            if (rbDaily.Checked && rbAllEmployees.Checked)
            {

                var list = basketDetailRepository.GetAll()
                    .Join(
                    medicineRepostitory.GetAll(),
                    b => b.MedicineId,
                    m => m.MedicineId,
                    (b, m) => new
                    {
                        MedicineID = b.MedicineId,
                        MedicineName = m.Name,
                        Quantity = b.Quantity,
                        TotalIncome = b.Quantity * m.SalePrice,
                        PurchasedDate = b.PurshasedDate
                    })
                    .Where(a => a.PurchasedDate.Day == dtpDate.Value.Day && a.PurchasedDate.Month == dtpDate.Value.Month && a.PurchasedDate.Year == dtpDate.Value.Year).ToList();





                lvMedicineList.Items.Clear();


                foreach (var item in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineID.ToString();
                    lvi.SubItems.Add(item.MedicineName);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.TotalIncome.ToString());

                    lvi.Tag = item;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbMonthly.Checked && rbAllEmployees.Checked)
            {
                var list = basketDetailRepository.GetAll()
                    .Join(
                    medicineRepostitory.GetAll(),
                    b => b.MedicineId,
                    m => m.MedicineId,
                    (b, m) => new
                    {
                        MedicineID = b.MedicineId,
                        MedicineName = m.Name,
                        Quantity = b.Quantity,
                        TotalIncome = b.Quantity * m.SalePrice,
                        PurchasedDate = b.PurshasedDate
                    }).Where(a => a.PurchasedDate.Month == dtpDate.Value.Month && a.PurchasedDate.Year == dtpDate.Value.Year).ToList();

                lvMedicineList.Items.Clear();

                foreach (var item in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineID.ToString();
                    lvi.SubItems.Add(item.MedicineName);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.TotalIncome.ToString());

                    lvi.Tag = item;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbDaily.Checked && !rbAllEmployees.Checked)
            {
                var list = (from bd in basketDetailRepository.GetAll()
                            join m in medicineRepostitory.GetAll() on bd.MedicineId equals m.MedicineId
                            join b in basketRepositories.GetAll() on bd.BasketId equals b.BasketID
                            join e in employeeRepository.GetAll() on b.EmployeeId equals e.EmployeeId
                            where bd.PurshasedDate.Day == dtpDate.Value.Day && bd.PurshasedDate.Month == dtpDate.Value.Month && bd.PurshasedDate.Year == dtpDate.Value.Year && e.Name == cbEmployees.Text
                            select new
                            {
                                MedicineID = bd.MedicineId,
                                MedicineName = m.Name,
                                Quantity = bd.Quantity,
                                TotalIncome = bd.Quantity * m.SalePrice,
                                PurchasedDate = bd.PurshasedDate
                            }).ToList();


                lvMedicineList.Items.Clear();


                foreach (var item in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineID.ToString();
                    lvi.SubItems.Add(item.MedicineName);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.TotalIncome.ToString());

                    lvi.Tag = item;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbMonthly.Checked && !rbAllEmployees.Checked)
            {
                var list = (from bd in basketDetailRepository.GetAll()
                            join m in medicineRepostitory.GetAll() on bd.MedicineId equals m.MedicineId
                            join b in basketRepositories.GetAll() on bd.BasketId equals b.BasketID
                            join e in employeeRepository.GetAll() on b.EmployeeId equals e.EmployeeId
                            where bd.PurshasedDate.Month == dtpDate.Value.Month && bd.PurshasedDate.Year == dtpDate.Value.Year && e.Name == cbEmployees.Text
                            select new
                            {
                                MedicineID = bd.MedicineId,
                                MedicineName = m.Name,
                                Quantity = bd.Quantity,
                                TotalIncome = bd.Quantity * m.SalePrice,
                                PurchasedDate = bd.PurshasedDate
                            }).ToList();

                lvMedicineList.Items.Clear();

                foreach (var item in list)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineID.ToString();
                    lvi.SubItems.Add(item.MedicineName);
                    lvi.SubItems.Add(item.Quantity.ToString());
                    lvi.SubItems.Add(item.TotalIncome.ToString());

                    lvi.Tag = item;
                    lvMedicineList.Items.Add(lvi);
                }
            }
        }






        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicineList();
        }

        private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployees.SelectedIndex == -1)
            {
                rbAllEmployees.Checked = true;

            }
            else if (cbEmployees.SelectedIndex != -1)
            {
                rbAllEmployees.Checked = false;
                FillTheMedicineList();
            }


        }

        private void rbAllEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllEmployees.Checked == false)
            {

                FillTheMedicineList();
            }
            else
            {
                cbEmployees.SelectedIndex = -1;
                FillTheMedicineList();
            }


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            FillTheMedicineList();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
