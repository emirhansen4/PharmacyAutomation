namespace PharmacyAutomation_UI
{
    partial class Description
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
            chkMorning = new CheckBox();
            chkAfternoon = new CheckBox();
            chkEvening = new CheckBox();
            rbHungry = new RadioButton();
            rbFull = new RadioButton();
            btnSave = new Button();
            btnComeBack = new Button();
            SuspendLayout();
            // 
            // chkMorning
            // 
            chkMorning.AutoSize = true;
            chkMorning.Location = new Point(72, 35);
            chkMorning.Name = "chkMorning";
            chkMorning.Size = new Size(58, 19);
            chkMorning.TabIndex = 0;
            chkMorning.Tag = "Sabah";
            chkMorning.Text = "Sabah";
            chkMorning.UseVisualStyleBackColor = true;
            // 
            // chkAfternoon
            // 
            chkAfternoon.AutoSize = true;
            chkAfternoon.Location = new Point(72, 69);
            chkAfternoon.Name = "chkAfternoon";
            chkAfternoon.Size = new Size(58, 19);
            chkAfternoon.TabIndex = 0;
            chkAfternoon.Tag = "Öğlen";
            chkAfternoon.Text = "Öğlen";
            chkAfternoon.UseVisualStyleBackColor = true;
            // 
            // chkEvening
            // 
            chkEvening.AutoSize = true;
            chkEvening.Location = new Point(72, 108);
            chkEvening.Name = "chkEvening";
            chkEvening.Size = new Size(62, 19);
            chkEvening.TabIndex = 0;
            chkEvening.Tag = "Akşam";
            chkEvening.Text = "Akşam";
            chkEvening.UseVisualStyleBackColor = true;
            // 
            // rbHungry
            // 
            rbHungry.AutoSize = true;
            rbHungry.Location = new Point(244, 35);
            rbHungry.Name = "rbHungry";
            rbHungry.Size = new Size(82, 19);
            rbHungry.TabIndex = 1;
            rbHungry.TabStop = true;
            rbHungry.Tag = "Aç Karnına";
            rbHungry.Text = "Aç Karnına";
            rbHungry.UseVisualStyleBackColor = true;
            // 
            // rbFull
            // 
            rbFull.AutoSize = true;
            rbFull.Location = new Point(244, 82);
            rbFull.Name = "rbFull";
            rbFull.Size = new Size(86, 19);
            rbFull.TabIndex = 1;
            rbFull.TabStop = true;
            rbFull.Tag = "Tok Karnına";
            rbFull.Text = "Tok Karnına";
            rbFull.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(72, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 40);
            btnSave.TabIndex = 3;
            btnSave.Text = "KAYDET";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnComeBack
            // 
            btnComeBack.Location = new Point(244, 157);
            btnComeBack.Name = "btnComeBack";
            btnComeBack.Size = new Size(86, 40);
            btnComeBack.TabIndex = 4;
            btnComeBack.Text = "GERİ DÖN";
            btnComeBack.UseVisualStyleBackColor = true;
            btnComeBack.Click += btnComeBack_Click;
            // 
            // Description
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(391, 238);
            Controls.Add(chkAfternoon);
            Controls.Add(btnComeBack);
            Controls.Add(rbFull);
            Controls.Add(btnSave);
            Controls.Add(chkMorning);
            Controls.Add(rbHungry);
            Controls.Add(chkEvening);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Description";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Description";
            Load += Description_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkMorning;
        private CheckBox chkAfternoon;
        private CheckBox chkEvening;
        private RadioButton rbHungry;
        private RadioButton rbFull;
        private Button btnSave;
        private Button btnComeBack;
    }
}