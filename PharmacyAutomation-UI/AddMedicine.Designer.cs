namespace PharmacyAutomation_UI
{
    partial class AddMedicine
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
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMedicineName = new TextBox();
            nudStock = new NumericUpDown();
            dtpExpireDate = new DateTimePicker();
            cbReceiptType = new ComboBox();
            nudBuyPrice = new NumericUpDown();
            nudSalePrice = new NumericUpDown();
            cbSupplierCompany = new ComboBox();
            grpMedicineInformation = new GroupBox();
            rbNo = new RadioButton();
            rbYes = new RadioButton();
            label8 = new Label();
            btnAddSupplier = new Button();
            grpMedicineList = new GroupBox();
            lvMedicineList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            rbWhite = new RadioButton();
            grpReceiptType = new GroupBox();
            rbAllMedicine = new RadioButton();
            rbPurple = new RadioButton();
            rbOrange = new RadioButton();
            rbGreen = new RadioButton();
            rbRed = new RadioButton();
            groupBox4 = new GroupBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).BeginInit();
            grpMedicineInformation.SuspendLayout();
            grpMedicineList.SuspendLayout();
            grpReceiptType.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(98, 45);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 60);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 45);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(216, 60);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 45);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 21);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 51);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Stok Sayısı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 6;
            label3.Text = "Son Kullanma Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 116);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Reçete Türü:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 154);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Alış Ücreti:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 186);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 9;
            label6.Text = "Satış Ücreti:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 221);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 10;
            label7.Text = "Tedarikçi Firma:";
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new Point(141, 21);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(166, 23);
            txtMedicineName.TabIndex = 11;
            // 
            // nudStock
            // 
            nudStock.Location = new Point(141, 52);
            nudStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(166, 23);
            nudStock.TabIndex = 12;
            // 
            // dtpExpireDate
            // 
            dtpExpireDate.Location = new Point(141, 84);
            dtpExpireDate.Name = "dtpExpireDate";
            dtpExpireDate.Size = new Size(166, 23);
            dtpExpireDate.TabIndex = 13;
            // 
            // cbReceiptType
            // 
            cbReceiptType.FormattingEnabled = true;
            cbReceiptType.Location = new Point(141, 116);
            cbReceiptType.Name = "cbReceiptType";
            cbReceiptType.Size = new Size(166, 23);
            cbReceiptType.TabIndex = 14;
            // 
            // nudBuyPrice
            // 
            nudBuyPrice.DecimalPlaces = 2;
            nudBuyPrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudBuyPrice.Location = new Point(141, 152);
            nudBuyPrice.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudBuyPrice.Name = "nudBuyPrice";
            nudBuyPrice.Size = new Size(166, 23);
            nudBuyPrice.TabIndex = 15;
            // 
            // nudSalePrice
            // 
            nudSalePrice.DecimalPlaces = 2;
            nudSalePrice.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            nudSalePrice.Location = new Point(141, 184);
            nudSalePrice.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            nudSalePrice.Name = "nudSalePrice";
            nudSalePrice.Size = new Size(166, 23);
            nudSalePrice.TabIndex = 16;
            // 
            // cbSupplierCompany
            // 
            cbSupplierCompany.FormattingEnabled = true;
            cbSupplierCompany.Location = new Point(141, 213);
            cbSupplierCompany.Name = "cbSupplierCompany";
            cbSupplierCompany.Size = new Size(166, 23);
            cbSupplierCompany.TabIndex = 17;
            // 
            // grpMedicineInformation
            // 
            grpMedicineInformation.Controls.Add(rbNo);
            grpMedicineInformation.Controls.Add(rbYes);
            grpMedicineInformation.Controls.Add(label8);
            grpMedicineInformation.Controls.Add(btnAddSupplier);
            grpMedicineInformation.Controls.Add(label1);
            grpMedicineInformation.Controls.Add(cbSupplierCompany);
            grpMedicineInformation.Controls.Add(nudSalePrice);
            grpMedicineInformation.Controls.Add(nudBuyPrice);
            grpMedicineInformation.Controls.Add(cbReceiptType);
            grpMedicineInformation.Controls.Add(label2);
            grpMedicineInformation.Controls.Add(dtpExpireDate);
            grpMedicineInformation.Controls.Add(label3);
            grpMedicineInformation.Controls.Add(nudStock);
            grpMedicineInformation.Controls.Add(label4);
            grpMedicineInformation.Controls.Add(txtMedicineName);
            grpMedicineInformation.Controls.Add(label5);
            grpMedicineInformation.Controls.Add(label7);
            grpMedicineInformation.Controls.Add(label6);
            grpMedicineInformation.Location = new Point(12, 65);
            grpMedicineInformation.Name = "grpMedicineInformation";
            grpMedicineInformation.Size = new Size(320, 307);
            grpMedicineInformation.TabIndex = 18;
            grpMedicineInformation.TabStop = false;
            grpMedicineInformation.Text = "İlaç Bilgileri";
            // 
            // rbNo
            // 
            rbNo.AutoSize = true;
            rbNo.Location = new Point(239, 248);
            rbNo.Name = "rbNo";
            rbNo.Size = new Size(44, 19);
            rbNo.TabIndex = 21;
            rbNo.Text = "Yok";
            rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            rbYes.AutoSize = true;
            rbYes.Checked = true;
            rbYes.Location = new Point(157, 246);
            rbYes.Name = "rbYes";
            rbYes.Size = new Size(41, 19);
            rbYes.TabIndex = 20;
            rbYes.TabStop = true;
            rbYes.Text = "Var";
            rbYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 248);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 19;
            label8.Text = "Sigorta Karşılıyor mu:";
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(174, 273);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(93, 28);
            btnAddSupplier.TabIndex = 18;
            btnAddSupplier.Text = "Tedarikçi Ekle";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // grpMedicineList
            // 
            grpMedicineList.Controls.Add(lvMedicineList);
            grpMedicineList.Location = new Point(360, 64);
            grpMedicineList.Name = "grpMedicineList";
            grpMedicineList.Size = new Size(386, 437);
            grpMedicineList.TabIndex = 19;
            grpMedicineList.TabStop = false;
            grpMedicineList.Text = "İlaçlar";
            // 
            // lvMedicineList
            // 
            lvMedicineList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lvMedicineList.FullRowSelect = true;
            lvMedicineList.GridLines = true;
            lvMedicineList.Location = new Point(6, 22);
            lvMedicineList.Name = "lvMedicineList";
            lvMedicineList.Size = new Size(374, 409);
            lvMedicineList.TabIndex = 0;
            lvMedicineList.UseCompatibleStateImageBehavior = false;
            lvMedicineList.View = View.Details;
            lvMedicineList.SelectedIndexChanged += lvMedicineList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "İlaç Adı";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Reçete Tipi";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Son Kullanım Tarihi";
            columnHeader4.Width = 120;
            // 
            // rbWhite
            // 
            rbWhite.AutoSize = true;
            rbWhite.Location = new Point(4, 21);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(55, 19);
            rbWhite.TabIndex = 20;
            rbWhite.TabStop = true;
            rbWhite.Text = "Beyaz";
            rbWhite.UseVisualStyleBackColor = true;
            rbWhite.CheckedChanged += rbWhite_CheckedChanged;
            // 
            // grpReceiptType
            // 
            grpReceiptType.Controls.Add(rbAllMedicine);
            grpReceiptType.Controls.Add(rbPurple);
            grpReceiptType.Controls.Add(rbOrange);
            grpReceiptType.Controls.Add(rbGreen);
            grpReceiptType.Controls.Add(rbRed);
            grpReceiptType.Controls.Add(rbWhite);
            grpReceiptType.Location = new Point(366, 12);
            grpReceiptType.Name = "grpReceiptType";
            grpReceiptType.Size = new Size(374, 53);
            grpReceiptType.TabIndex = 21;
            grpReceiptType.TabStop = false;
            grpReceiptType.Text = "Reçete Tipi";
            // 
            // rbAllMedicine
            // 
            rbAllMedicine.AutoSize = true;
            rbAllMedicine.Location = new Point(314, 21);
            rbAllMedicine.Name = "rbAllMedicine";
            rbAllMedicine.Size = new Size(56, 19);
            rbAllMedicine.TabIndex = 25;
            rbAllMedicine.TabStop = true;
            rbAllMedicine.Text = "Tümü";
            rbAllMedicine.UseVisualStyleBackColor = true;
            rbAllMedicine.CheckedChanged += rbAllMedicine_CheckedChanged;
            // 
            // rbPurple
            // 
            rbPurple.AutoSize = true;
            rbPurple.Location = new Point(261, 21);
            rbPurple.Name = "rbPurple";
            rbPurple.Size = new Size(47, 19);
            rbPurple.TabIndex = 24;
            rbPurple.TabStop = true;
            rbPurple.Text = "Mor";
            rbPurple.UseVisualStyleBackColor = true;
            rbPurple.CheckedChanged += rbPurple_CheckedChanged;
            // 
            // rbOrange
            // 
            rbOrange.AutoSize = true;
            rbOrange.Location = new Point(186, 21);
            rbOrange.Name = "rbOrange";
            rbOrange.Size = new Size(69, 19);
            rbOrange.TabIndex = 23;
            rbOrange.TabStop = true;
            rbOrange.Text = "Turuncu";
            rbOrange.UseVisualStyleBackColor = true;
            rbOrange.CheckedChanged += rbOrange_CheckedChanged;
            // 
            // rbGreen
            // 
            rbGreen.AutoSize = true;
            rbGreen.Location = new Point(132, 21);
            rbGreen.Name = "rbGreen";
            rbGreen.Size = new Size(48, 19);
            rbGreen.TabIndex = 22;
            rbGreen.TabStop = true;
            rbGreen.Text = "Yeşil";
            rbGreen.UseVisualStyleBackColor = true;
            rbGreen.CheckedChanged += rbGreen_CheckedChanged;
            // 
            // rbRed
            // 
            rbRed.AutoSize = true;
            rbRed.Location = new Point(65, 22);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(61, 19);
            rbRed.TabIndex = 21;
            rbRed.TabStop = true;
            rbRed.Text = "Kırmızı";
            rbRed.UseVisualStyleBackColor = true;
            rbRed.CheckedChanged += rbRed_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAdd);
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Location = new Point(12, 378);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(320, 123);
            groupBox4.TabIndex = 22;
            groupBox4.TabStop = false;
            groupBox4.Text = "İşlemler";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.back;
            pictureBox5.Location = new Point(12, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // AddMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(752, 510);
            Controls.Add(pictureBox5);
            Controls.Add(groupBox4);
            Controls.Add(grpReceiptType);
            Controls.Add(grpMedicineList);
            Controls.Add(grpMedicineInformation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMedicine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMedicine";
            Load += AddMedicine_Load;
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBuyPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSalePrice).EndInit();
            grpMedicineInformation.ResumeLayout(false);
            grpMedicineInformation.PerformLayout();
            grpMedicineList.ResumeLayout(false);
            grpReceiptType.ResumeLayout(false);
            grpReceiptType.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMedicineName;
        private NumericUpDown nudStock;
        private DateTimePicker dtpExpireDate;
        private ComboBox cbReceiptType;
        private NumericUpDown nudBuyPrice;
        private NumericUpDown nudSalePrice;
        private ComboBox cbSupplierCompany;
        private GroupBox grpMedicineInformation;
        private GroupBox grpMedicineList;
        private ListView lvMedicineList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private RadioButton rbWhite;
        private GroupBox grpReceiptType;
        private RadioButton rbGreen;
        private RadioButton rbRed;
        private RadioButton rbPurple;
        private RadioButton rbOrange;
        private GroupBox groupBox4;
        private RadioButton rbAllMedicine;
        private Button btnAddSupplier;
        private PictureBox pictureBox5;
        private Label label8;
        private RadioButton rbNo;
        private RadioButton rbYes;
    }
}