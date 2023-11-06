namespace PharmacyAutomation_UI
{
    partial class EmployeeLogsForm
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
            lwLogs = new ListView();
            EnterDate = new ColumnHeader();
            ExitDate = new ColumnHeader();
            PassTime = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            lblMouth = new Label();
            lblweek = new Label();
            SuspendLayout();
            // 
            // lwLogs
            // 
            lwLogs.Columns.AddRange(new ColumnHeader[] { EnterDate, ExitDate, PassTime });
            lwLogs.ForeColor = SystemColors.ActiveBorder;
            lwLogs.FullRowSelect = true;
            lwLogs.GridLines = true;
            lwLogs.Location = new Point(12, 113);
            lwLogs.MultiSelect = false;
            lwLogs.Name = "lwLogs";
            lwLogs.Size = new Size(393, 405);
            lwLogs.TabIndex = 0;
            lwLogs.UseCompatibleStateImageBehavior = false;
            lwLogs.View = View.Details;
            // 
            // EnterDate
            // 
            EnterDate.Text = "Giriş zamanı";
            EnterDate.Width = 150;
            // 
            // ExitDate
            // 
            ExitDate.Text = "Çıkış zamanı";
            ExitDate.Width = 150;
            // 
            // PassTime
            // 
            PassTime.Text = "Geçen Süre";
            PassTime.Width = 85;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 1;
            label1.Text = "Bu Ay Geçirilen Süre";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(218, 13);
            label2.Name = "label2";
            label2.Size = new Size(187, 23);
            label2.TabIndex = 2;
            label2.Text = "Bu Hafta geçirilen süre";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMouth
            // 
            lblMouth.Location = new Point(12, 46);
            lblMouth.Name = "lblMouth";
            lblMouth.Size = new Size(187, 23);
            lblMouth.TabIndex = 3;
            lblMouth.Text = "label3";
            lblMouth.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblweek
            // 
            lblweek.Location = new Point(218, 46);
            lblweek.Name = "lblweek";
            lblweek.Size = new Size(187, 23);
            lblweek.TabIndex = 4;
            lblweek.Text = "label4";
            lblweek.TextAlign = ContentAlignment.TopCenter;
            // 
            // EmployeeLogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(417, 530);
            Controls.Add(lblweek);
            Controls.Add(lblMouth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lwLogs);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EmployeeLogsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeLogsForm";
            Load += EmployeeLogsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView lwLogs;
        private ColumnHeader EnterDate;
        private ColumnHeader ExitDate;
        private ColumnHeader PassTime;
        private Label label1;
        private Label label2;
        private Label lblMouth;
        private Label lblweek;
    }
}