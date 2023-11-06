namespace PharmacyAutomation_UI
{
    partial class AddSupplierCompany
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
            grpSuppliersCompanies = new GroupBox();
            lvSuppliersList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            txtCompanyName = new TextBox();
            txtAddress = new TextBox();
            label2 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            grpInformations = new GroupBox();
            grpButtons = new GroupBox();
            grpSuppliersCompanies.SuspendLayout();
            grpInformations.SuspendLayout();
            grpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpSuppliersCompanies
            // 
            grpSuppliersCompanies.Controls.Add(lvSuppliersList);
            grpSuppliersCompanies.Location = new Point(12, 12);
            grpSuppliersCompanies.Name = "grpSuppliersCompanies";
            grpSuppliersCompanies.Size = new Size(332, 285);
            grpSuppliersCompanies.TabIndex = 0;
            grpSuppliersCompanies.TabStop = false;
            grpSuppliersCompanies.Text = "Tedarikçi Firmalar";
            // 
            // lvSuppliersList
            // 
            lvSuppliersList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvSuppliersList.FullRowSelect = true;
            lvSuppliersList.GridLines = true;
            lvSuppliersList.Location = new Point(6, 22);
            lvSuppliersList.Name = "lvSuppliersList";
            lvSuppliersList.Size = new Size(320, 257);
            lvSuppliersList.TabIndex = 0;
            lvSuppliersList.UseCompatibleStateImageBehavior = false;
            lvSuppliersList.View = View.Details;
            lvSuppliersList.SelectedIndexChanged += lvSuppliersList_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Şirket Adı";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adres";
            columnHeader3.Width = 300;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Şirket Adı:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(73, 16);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(129, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(73, 45);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(129, 137);
            txtAddress.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 108);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Adresi:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(6, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 46);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(6, 129);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(90, 46);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "SİL";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // grpInformations
            // 
            grpInformations.Controls.Add(txtAddress);
            grpInformations.Controls.Add(label1);
            grpInformations.Controls.Add(txtCompanyName);
            grpInformations.Controls.Add(label2);
            grpInformations.Location = new Point(12, 297);
            grpInformations.Name = "grpInformations";
            grpInformations.Size = new Size(216, 187);
            grpInformations.TabIndex = 8;
            grpInformations.TabStop = false;
            grpInformations.Text = "Bilgiler";
            // 
            // grpButtons
            // 
            grpButtons.Controls.Add(btnAdd);
            grpButtons.Controls.Add(btnUpdate);
            grpButtons.Controls.Add(btnRemove);
            grpButtons.Location = new Point(243, 297);
            grpButtons.Name = "grpButtons";
            grpButtons.Size = new Size(101, 182);
            grpButtons.TabIndex = 9;
            grpButtons.TabStop = false;
            grpButtons.Text = "İşlemler";
            // 
            // AddSupplierCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(351, 485);
            Controls.Add(grpButtons);
            Controls.Add(grpInformations);
            Controls.Add(grpSuppliersCompanies);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddSupplierCompany";
            Text = "Tedarikçi Ekleme";
            Load += AddSupplierCompany_Load;
            grpSuppliersCompanies.ResumeLayout(false);
            grpInformations.ResumeLayout(false);
            grpInformations.PerformLayout();
            grpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpSuppliersCompanies;
        private ListView lvSuppliersList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label label1;
        private TextBox txtCompanyName;
        private TextBox txtAddress;
        private Label label2;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRemove;
        private GroupBox grpInformations;
        private GroupBox grpButtons;
    }
}