namespace PharmacyAutomation_UI
{
    partial class EmployeeCheck
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BtnAddNew = new Button();
            btnUpdate = new Button();
            dgvEmployees = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            EMail = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Gender1 = new DataGridViewTextBoxColumn();
            Adress1 = new DataGridViewTextBoxColumn();
            Authority = new DataGridViewTextBoxColumn();
            Availability = new DataGridViewTextBoxColumn();
            btnConditionChange = new Button();
            btnLog = new Button();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // BtnAddNew
            // 
            BtnAddNew.Location = new Point(466, 63);
            BtnAddNew.Name = "BtnAddNew";
            BtnAddNew.Size = new Size(86, 40);
            BtnAddNew.TabIndex = 1;
            BtnAddNew.Text = "Yeni Çalışan";
            BtnAddNew.UseVisualStyleBackColor = true;
            BtnAddNew.Click += BtnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(558, 63);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 40);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Düzenle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.SeaGreen;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(77, 74, 82);
            dataGridViewCellStyle3.Font = new Font("Gadugi", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(0, 3, 0, 3);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(77, 74, 82);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { Name, EMail, PhoneNumber, Gender1, Adress1, Authority, Availability });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.Padding = new Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvEmployees.DefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.GridColor = Color.White;
            dgvEmployees.Location = new Point(1, 109);
            dgvEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1107, 463);
            dgvEmployees.TabIndex = 49;
            dgvEmployees.CellMouseClick += dgvEmployees_CellMouseClick;
            // 
            // Name
            // 
            Name.FillWeight = 50F;
            Name.HeaderText = "Isim";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // EMail
            // 
            EMail.FillWeight = 50F;
            EMail.HeaderText = "EMail";
            EMail.Name = "EMail";
            EMail.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            PhoneNumber.FillWeight = 50F;
            PhoneNumber.HeaderText = "Telefon";
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            // 
            // Gender1
            // 
            Gender1.FillWeight = 29F;
            Gender1.HeaderText = "Cinsiyet";
            Gender1.Name = "Gender1";
            Gender1.ReadOnly = true;
            // 
            // Adress1
            // 
            Adress1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Adress1.HeaderText = "Adres";
            Adress1.Name = "Adress1";
            Adress1.ReadOnly = true;
            // 
            // Authority
            // 
            Authority.FillWeight = 40F;
            Authority.HeaderText = "Pozisyon";
            Authority.Name = "Authority";
            Authority.ReadOnly = true;
            // 
            // Availability
            // 
            Availability.FillWeight = 30F;
            Availability.HeaderText = "Durum";
            Availability.Name = "Availability";
            Availability.ReadOnly = true;
            // 
            // btnConditionChange
            // 
            btnConditionChange.Location = new Point(936, 63);
            btnConditionChange.Name = "btnConditionChange";
            btnConditionChange.Size = new Size(161, 40);
            btnConditionChange.TabIndex = 50;
            btnConditionChange.Text = "Çalışan Durum Değişikliği";
            btnConditionChange.UseVisualStyleBackColor = true;
            btnConditionChange.Click += btnConditionChange_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(1012, 12);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(85, 40);
            btnLog.TabIndex = 51;
            btnLog.Text = "Log Ekranı";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.back;
            pictureBox5.Location = new Point(12, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // EmployeeCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1109, 572);
            Controls.Add(pictureBox5);
            Controls.Add(btnLog);
            Controls.Add(btnConditionChange);
            Controls.Add(dgvEmployees);
            Controls.Add(btnUpdate);
            Controls.Add(BtnAddNew);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeControl";
            Load += EmployeeControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnAddNew;
        private Button btnUpdate;
        private DataGridView dgvEmployees;
        private Button btnConditionChange;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn EMail;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Gender1;
        private DataGridViewTextBoxColumn Adress1;
        private DataGridViewTextBoxColumn Authority;
        private DataGridViewTextBoxColumn Availability;
        private Button btnLog;
        private PictureBox pictureBox5;
    }
}