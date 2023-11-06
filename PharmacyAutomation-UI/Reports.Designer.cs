namespace PharmacyAutomation_UI
{
    partial class Reports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvMedicineList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            grpSoldMedicine = new GroupBox();
            label1 = new Label();
            lblDailyProfit = new Label();
            lblMonthlyProfit = new Label();
            label4 = new Label();
            lblMonthlyIncome = new Label();
            label3 = new Label();
            lblDailyIncome = new Label();
            label6 = new Label();
            cbEmployees = new ComboBox();
            label2 = new Label();
            rbDaily = new RadioButton();
            rbMonthly = new RadioButton();
            grpFilter = new GroupBox();
            gbReports = new GroupBox();
            rbAllEmployees = new RadioButton();
            gbEmployees = new GroupBox();
            dtpDate = new DateTimePicker();
            pictureBox5 = new PictureBox();
            grpSoldMedicine.SuspendLayout();
            grpFilter.SuspendLayout();
            gbReports.SuspendLayout();
            gbEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lvMedicineList
            // 
            lvMedicineList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvMedicineList.GridLines = true;
            lvMedicineList.Location = new Point(6, 22);
            lvMedicineList.Name = "lvMedicineList";
            lvMedicineList.Size = new Size(365, 470);
            lvMedicineList.TabIndex = 0;
            lvMedicineList.UseCompatibleStateImageBehavior = false;
            lvMedicineList.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İlaç Adı";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Toplam Satış Adedi";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Toplam Gelir";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // grpSoldMedicine
            // 
            grpSoldMedicine.Controls.Add(lvMedicineList);
            grpSoldMedicine.Location = new Point(262, 40);
            grpSoldMedicine.Name = "grpSoldMedicine";
            grpSoldMedicine.Size = new Size(381, 498);
            grpSoldMedicine.TabIndex = 1;
            grpSoldMedicine.TabStop = false;
            grpSoldMedicine.Text = "Satılan İlaçlar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(42, 119);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 2;
            label1.Text = "Günlük Kar:";
            // 
            // lblDailyProfit
            // 
            lblDailyProfit.AutoSize = true;
            lblDailyProfit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDailyProfit.Location = new Point(151, 119);
            lblDailyProfit.Name = "lblDailyProfit";
            lblDailyProfit.Size = new Size(57, 21);
            lblDailyProfit.TabIndex = 3;
            lblDailyProfit.Text = "label2";
            // 
            // lblMonthlyProfit
            // 
            lblMonthlyProfit.AutoSize = true;
            lblMonthlyProfit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonthlyProfit.Location = new Point(151, 159);
            lblMonthlyProfit.Name = "lblMonthlyProfit";
            lblMonthlyProfit.Size = new Size(57, 21);
            lblMonthlyProfit.TabIndex = 5;
            lblMonthlyProfit.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(58, 159);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 4;
            label4.Text = "Aylık Kar:";
            // 
            // lblMonthlyIncome
            // 
            lblMonthlyIncome.AutoSize = true;
            lblMonthlyIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMonthlyIncome.Location = new Point(151, 82);
            lblMonthlyIncome.Name = "lblMonthlyIncome";
            lblMonthlyIncome.Size = new Size(57, 21);
            lblMonthlyIncome.TabIndex = 9;
            lblMonthlyIncome.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(47, 82);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 8;
            label3.Text = "Aylık Gelir:";
            // 
            // lblDailyIncome
            // 
            lblDailyIncome.AutoSize = true;
            lblDailyIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDailyIncome.Location = new Point(151, 42);
            lblDailyIncome.Name = "lblDailyIncome";
            lblDailyIncome.Size = new Size(57, 21);
            lblDailyIncome.TabIndex = 7;
            lblDailyIncome.Text = "label2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(31, 42);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 6;
            label6.Text = "Günlük Gelir:";
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(86, 45);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(148, 23);
            cbEmployees.TabIndex = 10;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 11;
            label2.Text = "Çalışanlar:";
            // 
            // rbDaily
            // 
            rbDaily.AutoSize = true;
            rbDaily.Location = new Point(6, 22);
            rbDaily.Name = "rbDaily";
            rbDaily.Size = new Size(63, 19);
            rbDaily.TabIndex = 12;
            rbDaily.TabStop = true;
            rbDaily.Text = "Günlük";
            rbDaily.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            rbMonthly.AutoSize = true;
            rbMonthly.Location = new Point(99, 22);
            rbMonthly.Name = "rbMonthly";
            rbMonthly.Size = new Size(51, 19);
            rbMonthly.TabIndex = 13;
            rbMonthly.TabStop = true;
            rbMonthly.Text = "Aylık";
            rbMonthly.UseVisualStyleBackColor = true;
            rbMonthly.CheckedChanged += rbMonthly_CheckedChanged;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(rbMonthly);
            grpFilter.Controls.Add(rbDaily);
            grpFilter.Location = new Point(50, 120);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(167, 55);
            grpFilter.TabIndex = 14;
            grpFilter.TabStop = false;
            grpFilter.Text = "Filtrele";
            // 
            // gbReports
            // 
            gbReports.Controls.Add(label6);
            gbReports.Controls.Add(label1);
            gbReports.Controls.Add(lblDailyProfit);
            gbReports.Controls.Add(lblMonthlyIncome);
            gbReports.Controls.Add(label4);
            gbReports.Controls.Add(label3);
            gbReports.Controls.Add(lblMonthlyProfit);
            gbReports.Controls.Add(lblDailyIncome);
            gbReports.Location = new Point(9, 300);
            gbReports.Name = "gbReports";
            gbReports.Size = new Size(247, 230);
            gbReports.TabIndex = 15;
            gbReports.TabStop = false;
            gbReports.Text = "Raporlar";
            // 
            // rbAllEmployees
            // 
            rbAllEmployees.AutoSize = true;
            rbAllEmployees.Location = new Point(101, 20);
            rbAllEmployees.Name = "rbAllEmployees";
            rbAllEmployees.Size = new Size(56, 19);
            rbAllEmployees.TabIndex = 16;
            rbAllEmployees.TabStop = true;
            rbAllEmployees.Text = "Tümü";
            rbAllEmployees.UseVisualStyleBackColor = true;
            rbAllEmployees.CheckedChanged += rbAllEmployees_CheckedChanged;
            // 
            // gbEmployees
            // 
            gbEmployees.Controls.Add(rbAllEmployees);
            gbEmployees.Controls.Add(label2);
            gbEmployees.Controls.Add(cbEmployees);
            gbEmployees.Location = new Point(9, 181);
            gbEmployees.Name = "gbEmployees";
            gbEmployees.Size = new Size(247, 100);
            gbEmployees.TabIndex = 17;
            gbEmployees.TabStop = false;
            gbEmployees.Text = "Çalışan Filtresi";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(31, 78);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 18;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.back;
            pictureBox5.Location = new Point(9, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(653, 550);
            Controls.Add(pictureBox5);
            Controls.Add(dtpDate);
            Controls.Add(gbEmployees);
            Controls.Add(gbReports);
            Controls.Add(grpFilter);
            Controls.Add(grpSoldMedicine);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            grpSoldMedicine.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            gbReports.ResumeLayout(false);
            gbReports.PerformLayout();
            gbEmployees.ResumeLayout(false);
            gbEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMedicineList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox grpSoldMedicine;
        private Label label1;
        private Label lblDailyProfit;
        private Label lblMonthlyProfit;
        private Label label4;
        private Label lblMonthlyIncome;
        private Label label3;
        private Label lblDailyIncome;
        private Label label6;
        private ComboBox cbEmployees;
        private Label label2;
        private RadioButton rbDaily;
        private RadioButton rbMonthly;
        private GroupBox grpFilter;
        private GroupBox gbReports;
        private GroupBox gbEmployees;
        private RadioButton rbAllEmployees;
        private DateTimePicker dtpDate;
        private PictureBox pictureBox5;
    }
}