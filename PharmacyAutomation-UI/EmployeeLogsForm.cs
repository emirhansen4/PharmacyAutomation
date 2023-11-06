using PharmacyAutomation_DAL.Repositories;
using PharmacyAutomation_DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PharmacyAutomation_UI
{
    public partial class EmployeeLogsForm : Form
    {
        int id;
        public EmployeeLogsForm(int _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void EmployeeLogsForm_Load(object sender, EventArgs e)
        {
            EmployeeLogRepository empLogRep = new EmployeeLogRepository();
            List<EmployeeLog> logs = empLogRep.GetByEmoloyeeId(id);
            UpdateList(logs);

            //TotalMonth
            double totoalWorkingInMonth = logs.Where(l => l.EnterTime.Month == DateTime.Now.Month).Sum(l => (l.ExitTime - l.EnterTime).TotalHours);
            lblMouth.Text = Convert.ToString(Math.Round(totoalWorkingInMonth, 2)) + " saat";

            //TotalWeek
            double totalHoursThisWeek = logs.Where(l => l.EnterTime.Year == DateTime.Now.Year &&
              CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(l.EnterTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday) == CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday))
            .Sum(l => (double)(l.ExitTime - l.EnterTime).TotalHours);
            lblweek.Text = Convert.ToString(Math.Round(totalHoursThisWeek, 2)) + " saat";
        }

        private void UpdateList(List<EmployeeLog> logs)
        {
            foreach (EmployeeLog log in logs)
            {
                string enterTimeFormatted = $"{log.EnterTime.Year}/{log.EnterTime.Month}/{log.EnterTime.Day} {log.EnterTime.Hour}:{log.EnterTime.Minute}";
                string exitTimeFormatted = $"{log.ExitTime.Year}/{log.ExitTime.Month}/{log.ExitTime.Day} {log.ExitTime.Hour}:{log.ExitTime.Minute}";
                string durationFormatted = $"{(log.ExitTime - log.EnterTime).TotalHours} hours";

                string[] details = new string[] { enterTimeFormatted, exitTimeFormatted, durationFormatted };
                ListViewItem listViewItem = new ListViewItem(details);

                lwLogs.Items.Add(listViewItem);
            }
        }
    }
}


