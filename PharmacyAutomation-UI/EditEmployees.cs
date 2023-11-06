using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entity;
using PharmacyAutomation_DATA.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security.Policy;

namespace PharmacyAutomation_UI
{
    public partial class EditEmployees : Form
    {
        public EditEmployees()
        {
            InitializeComponent();
        }
        int id = -1;
        public EditEmployees(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        AccountRepository accRep;
        EmployeeRepository empRep;

        Account account;
        private void EditEmployees_Load(object sender, EventArgs e)
        {
            accRep = new AccountRepository();
            empRep = new EmployeeRepository();
            if (id != -1)
            {
                account = accRep.GetById(id);
                account.Employee = empRep.GetById(id);
                fillBlanks();
            }

        }

        private void fillBlanks()
        {
            txtName.Text = account.Employee.Name;
            txtEmail.Text = account.Mail;
            txtAdress.Text = account.Employee.Adress;
            txtPhone.Text = account.Employee.Telephone;
            rbMan.Checked = account.Employee.Gender == 0 ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtEmail.Text != "" && txtAdress.Text != "" && txtPhone.Text != "")
            {
                if (id == -1)
                {
                    Account acc = new Account();
                    acc.Employee = new Employee();

                    acc.Employee.Name = txtName.Text;
                    acc.Mail = txtEmail.Text;
                    acc.Employee.Adress = txtAdress.Text;
                    acc.Employee.Telephone = txtPhone.Text;
                    acc.Employee.Gender = rbMan.Checked ? Gender.Male : Gender.Female;
                    acc.IsAdmin = false;
                    acc.IsValid = true;
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        acc.Password = HashPassword(txtPassword.Text);
                    }
                    else
                    {
                        MessageBox.Show("Şifre boş bırakılamaz");
                        return;
                    }
                    DialogResult res = MessageBox.Show("Eklemek istediğinize emin misiniz?", "Yeni Personel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                        accRep.Add(acc);
                        this.Close();
                    }
                }
                else if (id == 1)
                {
                    account.Employee.Name = txtName.Text;
                    account.Mail = txtEmail.Text;
                    account.Employee.Adress = txtAdress.Text;
                    account.Employee.Telephone = txtPhone.Text;
                    account.Employee.Gender = rbMan.Checked ? Gender.Male : Gender.Female;
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        account.Password = HashPassword(txtPassword.Text);
                        PasswordCheck passwordCheck = new PasswordCheck();
                        if (passwordCheck.ShowDialog() != DialogResult.OK)
                        {
                            return;
                        }
                    }
                    this.DialogResult = DialogResult.OK;
                    accRep.Update(account);
                    this.Close();
                }
                else
                {
                    account.Employee.Name = txtName.Text;
                    account.Mail = txtEmail.Text;
                    account.Employee.Adress = txtAdress.Text;
                    account.Employee.Telephone = txtPhone.Text;
                    account.Employee.Gender = rbMan.Checked ? Gender.Male : Gender.Female;
                    if (!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        account.Password = HashPassword(txtPassword.Text);
                    }
                    DialogResult res = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        this.DialogResult = DialogResult.OK;
                        accRep.Update(account);
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        public static string HashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Kaydetmeden çıkmak istediğinize emin misiniz?");

            if (res == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
