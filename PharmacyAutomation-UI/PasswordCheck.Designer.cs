namespace PharmacyAutomation_UI
{
    partial class PasswordCheck
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
            txtPassword = new TextBox();
            btnCheck = new Button();
            Es = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(6, 27);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(185, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(107, 56);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(84, 30);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Doğrula";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // Es
            // 
            Es.AutoSize = true;
            Es.Location = new Point(6, 9);
            Es.Name = "Es";
            Es.Size = new Size(53, 15);
            Es.TabIndex = 2;
            Es.Text = "Eski Şifre";
            // 
            // PasswordCheck
            // 
            AcceptButton = btnCheck;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(209, 109);
            Controls.Add(Es);
            Controls.Add(btnCheck);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PasswordCheck";
            Text = "PasswordCheck";
            Load += PasswordCheck_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnCheck;
        private Label Es;
    }
}