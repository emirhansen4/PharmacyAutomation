namespace PharmacyAutomation_UI
{
    partial class EditEmployees
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
            btnSave = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtAdress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            rbWoman = new RadioButton();
            rbMan = new RadioButton();
            label3 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            txtPhone = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(232, 392);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(87, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(65, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Çıkış";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(65, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(254, 23);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(65, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(254, 23);
            txtEmail.TabIndex = 1;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(65, 286);
            txtAdress.Multiline = true;
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(254, 87);
            txtAdress.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 8;
            label1.Text = "İsim:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 83);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "EMail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 236);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 289);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Adres:";
            // 
            // rbWoman
            // 
            rbWoman.AutoSize = true;
            rbWoman.Location = new Point(210, 236);
            rbWoman.Name = "rbWoman";
            rbWoman.Size = new Size(55, 19);
            rbWoman.TabIndex = 5;
            rbWoman.Text = "Kadın";
            rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            rbMan.AutoSize = true;
            rbMan.Checked = true;
            rbMan.Location = new Point(87, 236);
            rbMan.Name = "rbMan";
            rbMan.Size = new Size(53, 19);
            rbMan.TabIndex = 4;
            rbMan.TabStop = true;
            rbMan.Text = "Erkek";
            rbMan.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 183);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 133);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 18;
            label8.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(65, 130);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(254, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(65, 180);
            txtPhone.Mask = "(999) 000-0000";
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(254, 23);
            txtPhone.TabIndex = 3;
            // 
            // EditEmployees
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(332, 444);
            Controls.Add(txtPhone);
            Controls.Add(label8);
            Controls.Add(txtPassword);
            Controls.Add(rbMan);
            Controls.Add(rbWoman);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdress);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EditEmployees";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EditEmployees";
            Load += EditEmployees_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAdress;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private RadioButton rbWoman;
        private RadioButton rbMan;
        private Label label3;
        private Label label8;
        private TextBox txtPassword;
        private MaskedTextBox txtPhone;
    }
}