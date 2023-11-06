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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            pass_TextBox.UseSystemPasswordChar = true;
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        Account account;
        private void loginButton_Click(object sender, EventArgs e)
        {
            DateTime tempLoginDate = DateTime.Now;
            string loginUserName = loginUserName_TextBox.Text;
            string enteredPass = pass_TextBox.Text;
            string hashedPass = sha256_hash(enteredPass);

            AccountRepository accountRepository = new AccountRepository();

            foreach (Account item in accountRepository.GetAll())
            {
                if (item.Mail == loginUserName && hashedPass == item.Password && item.IsAdmin && item.IsValid)
                {
                    Employee employee = accountRepository.GetEmployeeByAccount(item.AccountId);
                    AdminNavigation adminNavigation = new AdminNavigation(employee);
                    this.Hide();
                    adminNavigation.ShowDialog();
                    this.Show();
                    return;
                }

                else if (item.Mail == loginUserName && hashedPass == item.Password && item.IsAdmin == false )
                {
                    if (item.IsValid)
                    {
                        Employee employee = accountRepository.GetEmployeeByAccount(item.AccountId);
                        SalesScreen salesScreen = new SalesScreen(employee);
                        this.Hide();
                        salesScreen.ShowDialog();
                        this.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı pasif durumdadır");
                        return;
                    }
                    
                }
            }
            MessageBox.Show("Hatalı giriş");
        }

        private void pbpass_MouseDown(object sender, MouseEventArgs e)
        {
            pass_TextBox.UseSystemPasswordChar = false;
        }

        private void pbpass_MouseUp(object sender, MouseEventArgs e)
        {
            pass_TextBox.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BorderStyle = BorderStyle.None;
        }
    }
}
