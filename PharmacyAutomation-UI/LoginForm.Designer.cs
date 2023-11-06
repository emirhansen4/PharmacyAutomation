namespace PharmacyAutomation_UI
{
    partial class LoginForm
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
            groupBox1 = new GroupBox();
            pbpass = new PictureBox();
            loginButton = new Button();
            pass_TextBox = new TextBox();
            loginUserName_TextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbpass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pbpass);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(pass_TextBox);
            groupBox1.Controls.Add(loginUserName_TextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(27, 417);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(435, 249);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // pbpass
            // 
            pbpass.BackColor = Color.White;
            pbpass.Image = Properties.Resources.eye;
            pbpass.Location = new Point(364, 107);
            pbpass.Name = "pbpass";
            pbpass.Size = new Size(35, 31);
            pbpass.SizeMode = PictureBoxSizeMode.StretchImage;
            pbpass.TabIndex = 9;
            pbpass.TabStop = false;
            pbpass.MouseDown += pbpass_MouseDown;
            pbpass.MouseUp += pbpass_MouseUp;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.Location = new Point(131, 176);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(185, 44);
            loginButton.TabIndex = 8;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // pass_TextBox
            // 
            pass_TextBox.Location = new Point(164, 103);
            pass_TextBox.Margin = new Padding(2);
            pass_TextBox.Name = "pass_TextBox";
            pass_TextBox.Size = new Size(239, 37);
            pass_TextBox.TabIndex = 7;
            // 
            // loginUserName_TextBox
            // 
            loginUserName_TextBox.Location = new Point(164, 43);
            loginUserName_TextBox.Margin = new Padding(2);
            loginUserName_TextBox.Name = "loginUserName_TextBox";
            loginUserName_TextBox.Size = new Size(239, 37);
            loginUserName_TextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Şifre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(83, 232);
            label3.Name = "label3";
            label3.Size = new Size(330, 56);
            label3.TabIndex = 7;
            label3.Text = "PharmaTrack";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(171, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.exit;
            pictureBox2.Location = new Point(439, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.MouseDown += pictureBox2_MouseDown;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            pictureBox2.MouseUp += pictureBox2_MouseUp;
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(487, 756);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbpass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button loginButton;
        private TextBox pass_TextBox;
        private TextBox loginUserName_TextBox;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pbpass;
        private PictureBox pictureBox2;
    }
}