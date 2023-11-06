using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmacyAutomation_DATA.Enums;
using System.Runtime.CompilerServices;
using PharmacyAutomation_DATA.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using PharmacyAutomation_DAL.Services;

namespace PharmacyAutomation_UI
{
    public partial class SalesScreen : Form
    {
        Employee employee;

        public SalesScreen(Employee _employee)
        {
            employee = _employee;
            InitializeComponent();
        }

        MedicineRepostitory medicineRepo;
        BasketDetailRepository basketDetailRepo;
        BasketRepositories basketRepo;
        PatientRepostitory patientRepo;
        EmployeeLogRepository employeeLogRepo;
        BasketDetail basketDetail;
        List<Medicine> listMedicine;
        List<BasketDetail> listBasketDetail;
        EmployeeLog employeeLog;
        private void SalesScreen_Load(object sender, EventArgs e)
        {
            basketDetailRepo = new BasketDetailRepository();
            medicineRepo = new MedicineRepostitory();
            basketRepo = new BasketRepositories();
            patientRepo = new PatientRepostitory();
            listMedicine = new List<Medicine>();
            listBasketDetail = new List<BasketDetail>();
            employeeLogRepo = new EmployeeLogRepository();
            employeeLog = new EmployeeLog();
            employeeLog.EnterTime = DateTime.Now;

            OpenClose(true, false);
            ButtonOpenClose(false);
            ListFillİn(listMedicine, lstSalesMedicine);
            ListFillİn(medicineRepo.GetAllWithoutPrescription(), lstWithoutReceipt);

        }
        private void rbReceipt_CheckedChanged(object sender, EventArgs e)
        {
            OpenClose(false, true);
            listMedicine.Clear();
            listBasketDetail.Clear();
            lstWithoutReceipt.Items.Clear();
            //ListFillİn(medicineRepo.GetAll(), lstWithoutReceipt);

        }
        private void rbWithoutReceipt_CheckedChanged(object sender, EventArgs e)
        {

            OpenClose(true, false);
            ListFillİn(medicineRepo.GetAllWithoutPrescription(), lstWithoutReceipt);

        }


        private void OpenClose(bool open, bool close)
        {

            txtMedicineName.Enabled = open;
            nudQuantity.Enabled = open;
            lstWithoutReceipt.FullRowSelect = open;
            btnRemoveMedicine.Enabled = open;

            btnReadReceipt.Enabled = close;
            btnRemoveReceipt.Enabled = close;
            txtReceiptNo.Enabled = close;


        }

        private void ButtonOpenClose(bool result)
        {
            btnOrderClear.Enabled = result;
            btnOrderComplete.Enabled = result;
            btnDescription.Enabled = result;
        }

        decimal totalPrice;
        Medicine medicine;
        private void btnAddMedicine_Click(object sender, EventArgs e)
        {

            if (rbWithoutReceipt.Checked)
            {

                if (lstWithoutReceipt.SelectedItems.Count == 1)
                {
                    medicine = (Medicine)lstWithoutReceipt.SelectedItems[0].Tag;
                    ButtonOpenClose(true);
                    FillAndRemove(medicine, lstWithoutReceipt);
                    nudQuantity.Value = 1;

                }
                else if (lstWithoutReceipt.SelectedItems.Count > 1)
                {

                    MessageBox.Show("Çoklu seçim yapamazsınız.Tek ilaç seçmeniz gerekiyor.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show("Seçim Yapmanız Gerekiyor", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
            }
            else
            {
                ButtonOpenClose(true);
                FillInRecipeList(listMedicine);
                btnAddMedicine.Enabled = false;
                lstPrescriptionMedicine.Items.Clear();
            }
        }

        private void btnRemoveMedicine_Click(object sender, EventArgs e)
        {

            if (rbWithoutReceipt.Checked)
            {
                if (lstSalesMedicine.SelectedItems.Count == 1)
                {
                    medicine = (Medicine)lstSalesMedicine.SelectedItems[0].Tag;
                    FillAndRemove(medicine, lstSalesMedicine);
                    nudQuantity.Value = 1;
                    if (lstSalesMedicine.Items.Count == 0)
                    {
                        ButtonOpenClose(false);
                    }
                }

            }

        }

        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            if (rbWithoutReceipt.Checked)
            {
                DialogResult dr = MessageBox.Show($"Toplam Tutar : {totalPrice}\nSiparişi Tamamlamak İster Misiniz!", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    OrderComplete();
                    btnReadReceipt.Enabled = true;

                }
            }
            else if (rbReceipt.Checked)
            {

                DialogResult dr = MessageBox.Show($"Toplam Tutar : {totalPrice}\nSiparişi Tamamlamak İster Misiniz!", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (dr == DialogResult.OK)
                {
                    OrderComplete();
                    btnAddMedicine.Enabled = true;
                    btnReadReceipt.Enabled = true;

                }

            }

        }
        private void OrderComplete()
        {
            foreach (BasketDetail item in listBasketDetail)
            {
                basketDetailRepo.Add(item);
            }
            foreach (Medicine item in listMedicine)
            {
                medicineRepo.Update(item);
            }
            listMedicine.Clear();
            listBasketDetail.Clear();
            totalPrice = 0;
            lblTotalPrice.Text = totalPrice.ToString() + "₺";
            lstSalesMedicine.Items.Clear();
            lstPrescriptionMedicine.Items.Clear();
            MessageBox.Show("Sipariş Tamamlandı!");
            btnReadReceipt.Enabled = true;

        }
        private void btnOrderClear_Click(object sender, EventArgs e)
        {


            DialogResult dr = MessageBox.Show($"Siparişi Silmek İstediğinize Emin misiniz?", "BİLGİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (rbWithoutReceipt.Checked)
            {
                if (dr == DialogResult.OK)
                {
                    listMedicine.Clear();
                    listBasketDetail.Clear();
                    lstSalesMedicine.Items.Clear();
                    medicineRepo = new MedicineRepostitory();
                    basketDetail = new BasketDetail();

                    totalPrice = 0;
                    lblTotalPrice.Text = totalPrice.ToString() + "₺";
                    ListFillİn(medicineRepo.GetAllWithoutPrescription(), lstWithoutReceipt);
                    ListFillİn(listMedicine, lstSalesMedicine);
                    btnReadReceipt.Enabled = true;
                }
            }
            else if (rbReceipt.Checked)
            {

                listMedicine.Clear();
                listBasketDetail.Clear();
                lstSalesMedicine.Items.Clear();
                lstPrescriptionMedicine.Items.Clear();
                btnAddMedicine.Enabled = true;
                btnReadReceipt.Enabled = true;
                medicineRepo = new MedicineRepostitory();
                basketDetail = new BasketDetail();
                totalPrice = 0;
                lblTotalPrice.Text = totalPrice.ToString() + "₺";
            }

        }
        private void txtMedicineName_TextChanged(object sender, EventArgs e)
        {
            ListFillİn(medicineRepo.GetContaints(txtMedicineName.Text), lstWithoutReceipt);
        }

        bool isThere;
        Basket basket;
        private void FillAndRemove(Medicine medicine, Control control)
        {
            isThere = false;
            if (control == lstWithoutReceipt)
            {
                foreach (Medicine item in listMedicine)
                {
                    if (item.MedicineId == medicine.MedicineId)
                    {
                        isThere = true;
                    }
                }

                if (isThere == true)
                {
                    basketDetail = listBasketDetail.FirstOrDefault(b => b.MedicineId == medicine.MedicineId);

                    medicine.StockCount -= (int)nudQuantity.Value;
                    basketDetail.TotalPrice += (medicine.SalePrice * nudQuantity.Value);
                    basketDetail.Quantity += (int)nudQuantity.Value;
                    totalPrice += medicine.SalePrice * nudQuantity.Value;
                    lblTotalPrice.Text = totalPrice.ToString() + "₺";

                }
                else
                {

                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = medicine.MedicineId.ToString();
                    lvi.SubItems.Add(medicine.Name);
                    lvi.SubItems.Add(medicine.SalePrice.ToString());
                    lvi.SubItems.Add("0");
                    lvi.Tag = medicine;

                    medicine.StockCount -= (int)nudQuantity.Value;

                    totalPrice += medicine.SalePrice * nudQuantity.Value;
                    lblTotalPrice.Text = totalPrice.ToString() + "₺";

                    basket = new Basket();
                    basket.EmployeeId = employee.EmployeeId;
                    basketRepo.Add(basket);
                    basketDetail = new BasketDetail();
                    basketDetail.Quantity = 0;
                    basketDetail.PurshasedDate = DateTime.Now;
                    basketDetail.MedicineId = medicine.MedicineId;
                    basketDetail.BasketId = basket.BasketID;
                    basketDetail.Quantity += (int)nudQuantity.Value;
                    //basketDetail.TotalPrice = medicine.SalePrice * nudQuantity.Value;
                    lvi.SubItems.Add(basketDetail.Quantity.ToString());
                    lstSalesMedicine.Items.Add(lvi);
                    listBasketDetail.Add(basketDetail);
                    listMedicine.Add(medicine);
                }
            }
            else if (control == lstSalesMedicine)
            {
                medicine = listMedicine.FirstOrDefault(b => b == (Medicine)lstSalesMedicine.SelectedItems[0].Tag);
                basketDetail = listBasketDetail.FirstOrDefault(b => b.MedicineId == medicine.MedicineId);



                medicine = listMedicine[lstSalesMedicine.SelectedIndices[0]];
                medicine.StockCount += (int)nudQuantity.Value;

                basketDetail.Quantity -= (int)nudQuantity.Value;
                basketDetail.TotalPrice -= (medicine.SalePrice * nudQuantity.Value);
                totalPrice -= (medicine.SalePrice * nudQuantity.Value);
                lblTotalPrice.Text = totalPrice.ToString() + "₺";



                if (basketDetail.Quantity == 0)
                {
                    listMedicine.Remove(medicine);
                    listBasketDetail.Remove(basketDetail);
                    //lstSalesMedicine.SelectedItems[lstSalesMedicine.SelectedIndices[0]].Remove();

                }
                //lstSalesMedicine.SelectedItems[0].Remove();

            }
            ListFillİn(medicineRepo.GetAllWithoutPrescription(), lstWithoutReceipt);
            ListFillİn(listMedicine, lstSalesMedicine);

        }
        SupplierRepository supplier;
        private void ListFillİn(List<Medicine> medicines, Control control)
        {
            if (control == lstWithoutReceipt)
            {
                supplier = new SupplierRepository();
                lstWithoutReceipt.Items.Clear();
                foreach (Medicine item in medicines)
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = item.MedicineId.ToString();
                    list.SubItems.Add(item.Name);
                    list.SubItems.Add(item.StockCount.ToString());
                    list.SubItems.Add(item.ExpireDate.ToShortDateString());
                    list.SubItems.Add(item.ReceiptType.ToString());
                    list.SubItems.Add(item.BuyPrice.ToString());
                    list.SubItems.Add(supplier.GetSupplier(item.SupplierId).Name);
                    lstWithoutReceipt.Items.Add(list);
                    list.Tag = item;

                }
            }
            else if (control == lstSalesMedicine)
            {
                lstSalesMedicine.Items.Clear();
                foreach (Medicine item in medicines)
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = item.MedicineId.ToString();
                    list.SubItems.Add(item.Name);
                    list.SubItems.Add(listBasketDetail.FirstOrDefault(b => b.MedicineId == item.MedicineId).TotalPrice.ToString());
                    list.SubItems.Add("0");
                    list.SubItems.Add(listBasketDetail.FirstOrDefault(b => b.MedicineId == item.MedicineId).Quantity.ToString());
                    list.Tag = item;
                    lstSalesMedicine.Items.Add(list);

                }
            }
            else if ((control == lstPrescriptionMedicine))
            {
                lstPrescriptionMedicine.Items.Clear();

                foreach (Medicine item in medicines)
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = item.MedicineId.ToString();
                    list.SubItems.Add(item.Name);
                    list.SubItems.Add(item.StockCount.ToString());
                    list.SubItems.Add(item.ExpireDate.ToShortDateString());
                    list.SubItems.Add(item.ReceiptType.ToString());
                    list.SubItems.Add(item.BuyPrice.ToString());
                    list.SubItems.Add(supplier.GetSupplier(item.SupplierId).Name);
                    lstPrescriptionMedicine.Items.Add(list);
                    list.Tag = item;

                }
            }

        }
        MedicineData medicineData;

        public void FillInRecipeList(List<Medicine> medicines)
        {
            lstSalesMedicine.Items.Clear();

            totalPrice = 0;
            foreach (Medicine item in medicines)
            {
                ListViewItem list = new ListViewItem();
                list.Text = item.MedicineId.ToString();
                list.SubItems.Add(item.Name);
                medicineData = medicineDatas.FirstOrDefault(x => x.Name == item.Name);
                if (medicine.Coverage)
                {
                    list.SubItems.Add("0");
                    totalPrice += 0;

                }
                else
                {
                    list.SubItems.Add((item.SalePrice * medicineData.count).ToString());
                    totalPrice += (item.SalePrice * medicineData.count);

                }
                list.SubItems.Add(medicine.Coverage ? "Var" : "Yok");
                list.SubItems.Add(medicineData.count.ToString());
                list.Tag = item;

                basket = new Basket();
                basket.EmployeeId = employee.EmployeeId;
                basketRepo.Add(basket);
                basketDetail = new BasketDetail();
                basketDetail.Quantity = 0;
                basketDetail.PurshasedDate = DateTime.Now;
                basketDetail.MedicineId = item.MedicineId;
                basketDetail.BasketId = basket.BasketID;
                basketDetail.Quantity = medicineData.count;
                basketDetail.TotalPrice = medicine.Coverage ? 0 : medicine.SalePrice * medicineData.count;
                lstSalesMedicine.Items.Add(list);

                listBasketDetail.Add(basketDetail);

            }




            lblTotalPrice.Text = totalPrice.ToString();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void açıklamaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basketDetail = listBasketDetail.FirstOrDefault(x => x.MedicineId == listBasketDetail[lstSalesMedicine.SelectedIndices[0]].MedicineId);
            Description description = new Description(basketDetail);
            DialogResult dr = description.ShowDialog();
            if (dr == DialogResult.OK)
                lstSalesMedicine.SelectedItems[0].BackColor = Color.Green;



        }

        private void açıklamaDüzeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            basketDetail = listBasketDetail.FirstOrDefault(x => x.MedicineId == listBasketDetail[lstSalesMedicine.SelectedIndices[0]].MedicineId);
            Description description = new Description(basketDetail);
            DialogResult dr = description.ShowDialog();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {


        }
        RandonDataGenerator randonData;
        List<MedicineData> medicineDatas;
        private void btnReadReceipt_Click(object sender, EventArgs e)
        {
            //btnReadReceipt.Enabled = false;
            btnReadReceipt.Enabled = false;
            randonData = new RandonDataGenerator();
            medicineDatas = randonData.GetMedicine();
            FillInPrescriptionList(medicineDatas);

        }

        public void FillInPrescriptionList(List<MedicineData> medicines)
        {
            lstPrescriptionMedicine.Items.Clear();

            foreach (MedicineData item in medicines)
            {
                SupplierRepository supplier = new SupplierRepository();
                medicine = medicineRepo.GetFirst(item.Name);

                ListViewItem lvi = new ListViewItem();
                lvi.Text = medicine.MedicineId.ToString();
                lvi.SubItems.Add(medicine.Name);
                lvi.SubItems.Add(medicine.StockCount.ToString());
                lvi.SubItems.Add(medicine.ExpireDate.ToString());
                lvi.SubItems.Add(medicine.ReceiptType.ToString());
                lvi.SubItems.Add(medicine.BuyPrice.ToString());
                lvi.SubItems.Add(supplier.GetSupplier(medicine.SupplierId).Name);
                medicine.StockCount -= item.count;
                lstPrescriptionMedicine.Items.Add(lvi);

                listMedicine.Add(medicine);
            }
        }




        private void btnRemoveReceipt_Click(object sender, EventArgs e)
        {

            if (lstPrescriptionMedicine.SelectedItems.Count > 0)
            {
                medicine = listMedicine[lstPrescriptionMedicine.SelectedIndices[0]];
                listMedicine.Remove(medicine);
                ListFillİn(listMedicine, lstPrescriptionMedicine);
            }
            else
            {
                MessageBox.Show("Lütfen bir ilaç seçin.");
            }
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {



        }

        private void btnStockInReceipt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (employee.AccountId == 1)
            {
                this.Close();
            }
            else
            {
                employeeLog.ExitTime = DateTime.Now;
                employeeLog.EmployeeId = employee.EmployeeId;
                employeeLogRepo.Add(employeeLog);
                this.Close();
            }

        }
    }
}
