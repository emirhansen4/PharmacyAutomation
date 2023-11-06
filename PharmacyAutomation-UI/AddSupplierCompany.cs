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

namespace PharmacyAutomation_UI
{
    public partial class AddSupplierCompany : Form
    {
        public AddSupplierCompany()
        {
            InitializeComponent();
        }
        SupplierRepository supplierRepository;

        private void AddSupplierCompany_Load(object sender, EventArgs e)
        {
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            supplierRepository = new SupplierRepository();
            FillTheCompanies(supplierRepository.GetAll());




        }

        List<Supplier> allSuppliers;
        private void FillTheCompanies(List<Supplier> Suppliers)
        {
            lvSuppliersList.Items.Clear();
            allSuppliers = new List<Supplier>();

            foreach (Supplier item in Suppliers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.SupplierId.ToString();
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Adress);

                lvi.Tag = item;
                allSuppliers.Add(item);
                lvSuppliersList.Items.Add(lvi);
            }

        }

        Supplier supplier;
        private void lvSuppliersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSuppliersList.SelectedIndices.Count == 1)
            {
                int index = lvSuppliersList.SelectedIndices[0];
                supplier = allSuppliers[index];

                txtCompanyName.Text = supplier.Name.ToString();
                txtAddress.Text = supplier.Adress.ToString();
                btnUpdate.Enabled = true;
                btnRemove.Enabled = true;
                btnAdd.Enabled = false;


            }
            else if (lvSuppliersList.SelectedIndices.Count == 0)
            {
                btnRemove.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                txtCompanyName.Text = "";
                txtAddress.Text = "";
            }
        }

        Supplier newSupplier;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Lütfen İsim ve Adres Kısımlarını Doldurunuz!");
            }
            else
            {
                newSupplier = new Supplier() { Name = txtCompanyName.Text, Adress = txtAddress.Text };
                supplierRepository.Add(newSupplier);
                FillTheCompanies(supplierRepository.GetAll());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Lütfen İsim ve Adres Kısımlarını Doldurunuz!");
            }
            else
            {
                supplier.Name = txtCompanyName.Text;
                supplier.Adress = txtAddress.Text;
                supplierRepository.Update(supplier);
                FillTheCompanies(supplierRepository.GetAll());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            supplierRepository.Delete(supplier);
            FillTheCompanies(supplierRepository.GetAll());
        }
    }
}
