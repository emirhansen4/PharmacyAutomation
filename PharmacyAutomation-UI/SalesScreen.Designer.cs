namespace PharmacyAutomation_UI
{
    partial class SalesScreen
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
            components = new System.ComponentModel.Container();
            lstWithoutReceipt = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtMedicineName = new TextBox();
            label4 = new Label();
            nudQuantity = new NumericUpDown();
            txtReceiptNo = new TextBox();
            groupBox2 = new GroupBox();
            lstPrescriptionMedicine = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            btnRemoveReceipt = new Button();
            btnReadReceipt = new Button();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnDescription = new Button();
            btnOrderComplete = new Button();
            btnOrderClear = new Button();
            lstSalesMedicine = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            açıklamaEkleToolStripMenuItem = new ToolStripMenuItem();
            açıklamaDüzeltToolStripMenuItem = new ToolStripMenuItem();
            lblTotalPrice = new Label();
            label2 = new Label();
            btnAddMedicine = new Button();
            btnRemoveMedicine = new Button();
            rbWithoutReceipt = new RadioButton();
            rbReceipt = new RadioButton();
            groupBox4 = new GroupBox();
            pictureBox5 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lstWithoutReceipt
            // 
            lstWithoutReceipt.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader8 });
            lstWithoutReceipt.FullRowSelect = true;
            lstWithoutReceipt.GridLines = true;
            lstWithoutReceipt.Location = new Point(6, 52);
            lstWithoutReceipt.Name = "lstWithoutReceipt";
            lstWithoutReceipt.Size = new Size(593, 248);
            lstWithoutReceipt.TabIndex = 0;
            lstWithoutReceipt.UseCompatibleStateImageBehavior = false;
            lstWithoutReceipt.View = View.Details;
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
            columnHeader3.Text = "Stok Sayısı";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Son Kullanma Tarihi";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Reçete Tipi";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Fiyatı";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "TedarikçiID";
            columnHeader8.Width = 70;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMedicineName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nudQuantity);
            groupBox1.Controls.Add(lstWithoutReceipt);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(624, 311);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "REÇETESİZ İLAÇ ALIMI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 25);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "İLAÇ ADI :";
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new Point(325, 22);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new Size(135, 23);
            txtMedicineName.TabIndex = 5;
            txtMedicineName.TextChanged += txtMedicineName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(482, 25);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "Adet :";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(526, 23);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(73, 23);
            nudQuantity.TabIndex = 3;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtReceiptNo
            // 
            txtReceiptNo.Location = new Point(401, 22);
            txtReceiptNo.Name = "txtReceiptNo";
            txtReceiptNo.Size = new Size(205, 23);
            txtReceiptNo.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPrescriptionMedicine);
            groupBox2.Controls.Add(btnRemoveReceipt);
            groupBox2.Controls.Add(btnReadReceipt);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtReceiptNo);
            groupBox2.Location = new Point(12, 393);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(624, 317);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "REÇETELİ İLAÇ ALIMI";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lstPrescriptionMedicine
            // 
            lstPrescriptionMedicine.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader16 });
            lstPrescriptionMedicine.FullRowSelect = true;
            lstPrescriptionMedicine.GridLines = true;
            lstPrescriptionMedicine.Location = new Point(13, 79);
            lstPrescriptionMedicine.Name = "lstPrescriptionMedicine";
            lstPrescriptionMedicine.Size = new Size(593, 216);
            lstPrescriptionMedicine.TabIndex = 7;
            lstPrescriptionMedicine.UseCompatibleStateImageBehavior = false;
            lstPrescriptionMedicine.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID";
            columnHeader9.Width = 40;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "İlaç Adı";
            columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Stok Sayısı";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Son Kullanma Tarihi";
            columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Reçete Tipi";
            columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Fiyatı";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "TedarikçiID";
            columnHeader16.Width = 70;
            // 
            // btnRemoveReceipt
            // 
            btnRemoveReceipt.Location = new Point(401, 48);
            btnRemoveReceipt.Name = "btnRemoveReceipt";
            btnRemoveReceipt.Size = new Size(87, 25);
            btnRemoveReceipt.TabIndex = 6;
            btnRemoveReceipt.Text = "ÇIKART";
            btnRemoveReceipt.UseVisualStyleBackColor = true;
            btnRemoveReceipt.Click += btnRemoveReceipt_Click;
            // 
            // btnReadReceipt
            // 
            btnReadReceipt.Location = new Point(494, 48);
            btnReadReceipt.Name = "btnReadReceipt";
            btnReadReceipt.Size = new Size(112, 25);
            btnReadReceipt.TabIndex = 5;
            btnReadReceipt.Text = "REÇETEYİ OKU";
            btnReadReceipt.UseVisualStyleBackColor = true;
            btnReadReceipt.Click += btnReadReceipt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Reçete No:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDescription);
            groupBox3.Controls.Add(btnOrderComplete);
            groupBox3.Controls.Add(btnOrderClear);
            groupBox3.Controls.Add(lstSalesMedicine);
            groupBox3.Controls.Add(lblTotalPrice);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(798, 150);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 488);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "ALINAN İLAÇLAR";
            // 
            // btnDescription
            // 
            btnDescription.Location = new Point(211, 408);
            btnDescription.Name = "btnDescription";
            btnDescription.Size = new Size(132, 27);
            btnDescription.TabIndex = 4;
            btnDescription.Text = "İlaç Kullanımı";
            btnDescription.UseVisualStyleBackColor = true;
            btnDescription.Click += btnDescription_Click;
            // 
            // btnOrderComplete
            // 
            btnOrderComplete.Location = new Point(6, 409);
            btnOrderComplete.Name = "btnOrderComplete";
            btnOrderComplete.Size = new Size(132, 27);
            btnOrderComplete.TabIndex = 3;
            btnOrderComplete.Text = "Siparişi Tamamla";
            btnOrderComplete.UseVisualStyleBackColor = true;
            btnOrderComplete.Click += btnOrderComplete_Click;
            // 
            // btnOrderClear
            // 
            btnOrderClear.Location = new Point(6, 442);
            btnOrderClear.Name = "btnOrderClear";
            btnOrderClear.Size = new Size(132, 27);
            btnOrderClear.TabIndex = 2;
            btnOrderClear.Text = "Sipariş Temizle";
            btnOrderClear.UseVisualStyleBackColor = true;
            btnOrderClear.Click += btnOrderClear_Click;
            // 
            // lstSalesMedicine
            // 
            lstSalesMedicine.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader15, columnHeader17, columnHeader18, columnHeader19 });
            lstSalesMedicine.ContextMenuStrip = contextMenuStrip1;
            lstSalesMedicine.FullRowSelect = true;
            lstSalesMedicine.GridLines = true;
            lstSalesMedicine.Location = new Point(11, 22);
            lstSalesMedicine.Name = "lstSalesMedicine";
            lstSalesMedicine.Size = new Size(339, 381);
            lstSalesMedicine.TabIndex = 1;
            lstSalesMedicine.UseCompatibleStateImageBehavior = false;
            lstSalesMedicine.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            columnHeader7.Width = 35;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "İlaç Adı";
            columnHeader15.Width = 80;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Fiyatı";
            columnHeader17.Width = 80;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "SGK İndirimi";
            columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Adet";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { açıklamaEkleToolStripMenuItem, açıklamaDüzeltToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(160, 48);
            // 
            // açıklamaEkleToolStripMenuItem
            // 
            açıklamaEkleToolStripMenuItem.Name = "açıklamaEkleToolStripMenuItem";
            açıklamaEkleToolStripMenuItem.Size = new Size(159, 22);
            açıklamaEkleToolStripMenuItem.Text = "Açıklama Ekle";
            açıklamaEkleToolStripMenuItem.Click += açıklamaEkleToolStripMenuItem_Click;
            // 
            // açıklamaDüzeltToolStripMenuItem
            // 
            açıklamaDüzeltToolStripMenuItem.Name = "açıklamaDüzeltToolStripMenuItem";
            açıklamaDüzeltToolStripMenuItem.Size = new Size(159, 22);
            açıklamaDüzeltToolStripMenuItem.Text = "Açıklama Düzelt";
            açıklamaDüzeltToolStripMenuItem.Click += açıklamaDüzeltToolStripMenuItem_Click;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new Point(313, 454);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(12, 15);
            lblTotalPrice.TabIndex = 0;
            lblTotalPrice.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 454);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "TOPLAM TUTAR :";
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(663, 357);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(79, 30);
            btnAddMedicine.TabIndex = 4;
            btnAddMedicine.Text = "Ekle >>";
            btnAddMedicine.UseVisualStyleBackColor = true;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnRemoveMedicine
            // 
            btnRemoveMedicine.Location = new Point(663, 392);
            btnRemoveMedicine.Name = "btnRemoveMedicine";
            btnRemoveMedicine.Size = new Size(79, 30);
            btnRemoveMedicine.TabIndex = 4;
            btnRemoveMedicine.Text = "<< Çıkart";
            btnRemoveMedicine.UseVisualStyleBackColor = true;
            btnRemoveMedicine.Click += btnRemoveMedicine_Click;
            // 
            // rbWithoutReceipt
            // 
            rbWithoutReceipt.AutoSize = true;
            rbWithoutReceipt.Checked = true;
            rbWithoutReceipt.Location = new Point(21, 22);
            rbWithoutReceipt.Name = "rbWithoutReceipt";
            rbWithoutReceipt.Size = new Size(83, 19);
            rbWithoutReceipt.TabIndex = 7;
            rbWithoutReceipt.TabStop = true;
            rbWithoutReceipt.Text = "REÇETESİZ ";
            rbWithoutReceipt.UseVisualStyleBackColor = true;
            rbWithoutReceipt.CheckedChanged += rbWithoutReceipt_CheckedChanged;
            // 
            // rbReceipt
            // 
            rbReceipt.AutoSize = true;
            rbReceipt.Location = new Point(147, 22);
            rbReceipt.Name = "rbReceipt";
            rbReceipt.Size = new Size(73, 19);
            rbReceipt.TabIndex = 7;
            rbReceipt.TabStop = true;
            rbReceipt.Text = "REÇETELİ";
            rbReceipt.UseVisualStyleBackColor = true;
            rbReceipt.CheckedChanged += rbReceipt_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbWithoutReceipt);
            groupBox4.Controls.Add(rbReceipt);
            groupBox4.Location = new Point(804, 79);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(254, 52);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "SATIN ALMA TİPİ";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.back;
            pictureBox5.Location = new Point(12, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 53);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // SalesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(1178, 731);
            Controls.Add(pictureBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(btnRemoveMedicine);
            Controls.Add(btnAddMedicine);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SalesScreen";
            Load += SalesScreen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListView lstWithoutReceipt;
        private GroupBox groupBox1;
        private TextBox txtReceiptNo;
        private GroupBox groupBox2;
        private Label label1;
        private Button btnReadReceipt;
        private NumericUpDown nudQuantity;
        private GroupBox groupBox3;
        private Label lblTotalPrice;
        private Label label2;
        private Label label4;
        private Button btnRemoveReceipt;
        private ListView lstSalesMedicine;
        private Label label5;
        private TextBox txtMedicineName;
        private Button btnAddMedicine;
        private Button btnRemoveMedicine;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader8;
        private Button btnOrderClear;
        private ListView lstPrescriptionMedicine;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader16;
        private RadioButton rbWithoutReceipt;
        private RadioButton rbReceipt;
        private GroupBox groupBox4;
        private Button btnOrderComplete;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private Button btnDescription;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem açıklamaEkleToolStripMenuItem;
        private ToolStripMenuItem açıklamaDüzeltToolStripMenuItem;
        private PictureBox pictureBox5;
    }
}