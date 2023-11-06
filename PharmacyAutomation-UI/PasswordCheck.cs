using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyAutomation_UI
{
    public partial class PasswordCheck : Form
    {
        public PasswordCheck()
        {
            InitializeComponent();
        }
        string Password;
        private void PasswordCheck_Load(object sender, EventArgs e)
        {
            AccountRepository accRep = new AccountRepository();
            Password = accRep.GetById(1).Password;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (Password == HashPassword(txtPassword.Text))
            {
                MessageBox.Show("Şifre Başarı ile değiştirildi");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Şifre hatalıdır.");
            }
        }
        public static string HashPassword(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }
    }
}
