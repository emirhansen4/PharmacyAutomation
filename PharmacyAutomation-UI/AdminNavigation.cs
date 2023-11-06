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
    public partial class AdminNavigation : Form
    {
        Employee employee;
        public AdminNavigation(Employee _employee)
        {
            employee = _employee;
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeCheck employeeCheck = new EmployeeCheck();
            this.Hide();
            employeeCheck.ShowDialog();
            this.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            this.Hide();
            addMedicine.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            this.Hide();
            reports.ShowDialog();
            this.Show();
        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {

        }

        private void AdminNavigation_FormClosed(object? sender, FormClosedEventArgs? e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesScreen salesScreen = new SalesScreen(employee);
            this.Hide();
            salesScreen.ShowDialog();
            this.Show();
        }
    }
}
