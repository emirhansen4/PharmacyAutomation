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
    public partial class EmployeeCheck : Form
    {
        public EmployeeCheck()
        {
            InitializeComponent();
            dgvEmployees.MultiSelect = false;
        }


        private void EmployeeControl_Load(object sender, EventArgs e)
        {
            btnConditionChange.Enabled = false;
            btnLog.Enabled = false;
            UpdateDatas();
        }

        private void UpdateDatas()
        {
            dgvEmployees.Rows.Clear();
            AccountRepository accRep = new AccountRepository();
            EmployeeRepository empRep = new EmployeeRepository();
            List<Employee> employees = empRep.GetAll();
            List<Account> accounts = accRep.GetAll();

            foreach (Account account in accounts)
            {
                DataGridViewRow pushData = new DataGridViewRow();
                pushData.CreateCells(dgvEmployees);

                pushData.Tag = employees.Where(e => e.AccountId == account.AccountId).FirstOrDefault();
                pushData.Cells[0].Value = employees.Where(e => e.AccountId == account.AccountId).Select(e => e.Name).DefaultIfEmpty("-").FirstOrDefault();
                pushData.Cells[1].Value = account.Mail;
                pushData.Cells[2].Value = employees.Where(e => e.AccountId == account.AccountId).Select(e => e.Telephone).DefaultIfEmpty("-").FirstOrDefault();
                pushData.Cells[3].Value = employees.Where(e => e.AccountId == account.AccountId).FirstOrDefault().Gender == 0 ? "Erkek" : "Kadın";
                pushData.Cells[4].Value = employees.Where(e => e.AccountId == account.AccountId).Select(e => e.Adress).DefaultIfEmpty("-").FirstOrDefault(); ;
                pushData.Cells[5].Value = account.IsAdmin ? "Yönetici" : "Kullanıcı";
                pushData.Cells[6].Value = account.IsValid ? "Aktif" : "Pasif";

                dgvEmployees.Rows.Add(pushData);

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee employee = dgvEmployees.SelectedRows[0].Tag as Employee;
            EditEmployees editEmployees = new EditEmployees(employee.AccountId);
            if (editEmployees.ShowDialog() == DialogResult.OK)
            {
                UpdateDatas();
            }

        }

        private void dgvEmployees_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Employee employee = dgvEmployees.SelectedRows[0].Tag as Employee;
            if (employee.AccountId == 1)
            {
                btnConditionChange.Enabled = false;
                btnLog.Enabled = false;
            }
            else
            {
                btnConditionChange.Enabled = true;
                btnLog.Enabled = true;
            }
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            EditEmployees editEmployees = new EditEmployees();
            if (editEmployees.ShowDialog() == DialogResult.OK)
            {
                UpdateDatas();
            }
        }

        private void btnConditionChange_Click(object sender, EventArgs e)
        {
            Employee employee = dgvEmployees.SelectedRows[0].Tag as Employee;
            AccountRepository accRep = new AccountRepository();
            Account account = accRep.GetById(employee.AccountId);
            account.IsValid = account.IsValid ? false : true;
            accRep.Update(account);
            UpdateDatas();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Employee employee = dgvEmployees.SelectedRows[0].Tag as Employee;
            EmployeeLogsForm employeeLogs = new EmployeeLogsForm(employee.EmployeeId);
            employeeLogs.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
