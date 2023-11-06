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
    public partial class AddMedicine : Form
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        MedicineRepostitory medicineRepostitory;
        SupplierRepository supplierRepository;

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            medicineRepostitory = new MedicineRepostitory();
            supplierRepository = new SupplierRepository();
            cbSupplierCompany.DataSource = supplierRepository.GetCompanyNames();
            cbReceiptType.DataSource = Enum.GetValues(typeof(ReceiptType));
            cbReceiptType.SelectedIndex = 0;
            //cbSupplierCompany.SelectedIndex = 0;

            FillTheMedicines(medicineRepostitory.GetAll());
            rbAllMedicine.Checked = true;

        }

        List<Medicine> allMedicines;
        private void FillTheMedicines(List<Medicine> Medicines)
        {


            if (rbWhite.Checked)
            {

                Medicines = medicineRepostitory.GetMedicineWithReceiptType(ReceiptType.Beyaz);
                lvMedicineList.Items.Clear();

                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }

            }
            else if (rbRed.Checked)
            {

                Medicines = medicineRepostitory.GetMedicineWithReceiptType(ReceiptType.Kırmızı);
                lvMedicineList.Items.Clear();

                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }

            }
            else if (rbGreen.Checked)
            {

                Medicines = medicineRepostitory.GetMedicineWithReceiptType(ReceiptType.Yeşil);
                lvMedicineList.Items.Clear();

                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbOrange.Checked)
            {

                Medicines = medicineRepostitory.GetMedicineWithReceiptType(ReceiptType.Turuncu);
                lvMedicineList.Items.Clear();

                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbPurple.Checked)
            {

                Medicines = medicineRepostitory.GetMedicineWithReceiptType(ReceiptType.Mor);
                lvMedicineList.Items.Clear();

                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }
            }
            else if (rbAllMedicine.Checked)
            {
                lvMedicineList.Items.Clear();


                foreach (Medicine item in Medicines)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = item.MedicineId.ToString();
                    lvi.SubItems.Add(item.Name);
                    lvi.SubItems.Add(item.ReceiptType.ToString());
                    lvi.SubItems.Add(item.ExpireDate.ToShortDateString());

                    lvi.Tag = item.MedicineId;
                    lvMedicineList.Items.Add(lvi);
                }
            }




        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierCompany addSupplierCompany = new AddSupplierCompany();
            addSupplierCompany.ShowDialog();
            supplierRepository = new SupplierRepository();
            cbSupplierCompany.DataSource = supplierRepository.GetCompanyNames();
        }


        Medicine newMedicine;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            supplierRepository = new SupplierRepository();
            if (txtMedicineName.Text == "" || nudStock.Value == 0 || dtpExpireDate.Value < DateTime.Now.AddMonths(1) || cbReceiptType.SelectedIndex == -1 || nudBuyPrice.Value == 0 || nudSalePrice.Value == 0 || cbSupplierCompany.SelectedIndex == -1)
            {
                if (dtpExpireDate.Value < DateTime.Now.AddMonths(1))
                {
                    MessageBox.Show("Son Kullanım Tarihi Minimum 1 Ay Sonrası İçin Olmalıdır!");
                }
                else
                {
                    MessageBox.Show("Lütfen İlaç Bilgilerini Tam Olarak Giriniz");
                }

            }
            else
            {
                ReceiptType receiptType;
                Enum.TryParse(cbReceiptType.SelectedItem.ToString(), out receiptType);
                string choosenSupplierName = cbSupplierCompany.Text;
                int id = supplierRepository.GetID(choosenSupplierName);


                newMedicine = new Medicine() { Name = txtMedicineName.Text, StockCount = (int)nudStock.Value, ExpireDate = dtpExpireDate.Value = dtpExpireDate.Value, ReceiptType = receiptType, BuyPrice = nudBuyPrice.Value, SalePrice = nudSalePrice.Value, SupplierId = id, Coverage = rbYes.Checked ? true : false };

                medicineRepostitory.Add(newMedicine);

            }

            FillTheMedicines(medicineRepostitory.GetAll());
        }

        Medicine medicine;
        private void lvMedicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedicineList.SelectedIndices.Count == 1)
            {


                medicine = medicineRepostitory.GetMedicine(lvMedicineList.SelectedItems[0].Tag);


                txtMedicineName.Text = medicine.Name.ToString();
                nudStock.Value = medicine.StockCount;
                dtpExpireDate.Value = medicine.ExpireDate;
                cbReceiptType.SelectedIndex = (int)medicine.ReceiptType;
                nudBuyPrice.Value = medicine.BuyPrice;
                nudSalePrice.Value = medicine.SalePrice;
                cbSupplierCompany.SelectedItem = supplierRepository.GetSelectedSupplier(medicine.SupplierId);



                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;


            }
            else if (lvMedicineList.SelectedIndices.Count == 0)
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                txtMedicineName.Text = "";
                nudStock.Value = 0;
                dtpExpireDate.Value = DateTime.Now;
                cbReceiptType.SelectedIndex = -1;
                nudBuyPrice.Value = 0;
                nudSalePrice.Value = 0;
                cbSupplierCompany.SelectedIndex = -1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            supplierRepository = new SupplierRepository();
            if (txtMedicineName.Text == "" || nudStock.Value == 0 || dtpExpireDate.Value < DateTime.Now.AddMonths(1) || cbReceiptType.SelectedIndex == -1 || nudBuyPrice.Value == 0 || nudSalePrice.Value == 0 || cbSupplierCompany.SelectedIndex == -1)
            {
                if (dtpExpireDate.Value < DateTime.Now.AddMonths(1))
                {
                    MessageBox.Show("Son Kullanım Tarihi Minimum 1 Ay Sonrası İçin Olmalıdır!");
                }
                else
                {
                    MessageBox.Show("Lütfen İlaç Bilgilerini Tam Olarak Giriniz");
                }

            }
            else
            {
                ReceiptType receiptType;
                Enum.TryParse(cbReceiptType.SelectedItem.ToString(), out receiptType);
                string choosenSupplierName = cbSupplierCompany.Text;
                int id = supplierRepository.GetID(choosenSupplierName);


                medicine.Name = txtMedicineName.Text;
                medicine.StockCount = (int)nudStock.Value;
                medicine.ExpireDate = dtpExpireDate.Value;
                medicine.ReceiptType = receiptType;
                medicine.BuyPrice = nudBuyPrice.Value;
                medicine.SalePrice = nudSalePrice.Value;
                medicine.SupplierId = id;

                medicineRepostitory.Update(medicine);

            }

            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            medicineRepostitory.Delete(medicine);
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbWhite_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbOrange_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbPurple_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void rbAllMedicine_CheckedChanged(object sender, EventArgs e)
        {
            FillTheMedicines(medicineRepostitory.GetAll());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
