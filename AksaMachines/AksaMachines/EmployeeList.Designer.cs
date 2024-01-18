namespace AksaMachines
{
    partial class EmployeeList
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            empName = new Label();
            empSurname = new Label();
            empRole = new Label();
            empPhoneNoLabel = new Label();
            panel1 = new Panel();
            empId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 79);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // empName
            // 
            empName.AutoSize = true;
            empName.Location = new Point(151, 46);
            empName.Name = "empName";
            empName.Size = new Size(39, 15);
            empName.TabIndex = 1;
            empName.Text = "Name";
            // 
            // empSurname
            // 
            empSurname.AutoSize = true;
            empSurname.Location = new Point(151, 80);
            empSurname.Name = "empSurname";
            empSurname.Size = new Size(54, 15);
            empSurname.TabIndex = 2;
            empSurname.Text = "Surname";
            // 
            // empRole
            // 
            empRole.AutoSize = true;
            empRole.Location = new Point(151, 113);
            empRole.Name = "empRole";
            empRole.Size = new Size(30, 15);
            empRole.TabIndex = 3;
            empRole.Text = "Role";
            // 
            // empPhoneNoLabel
            // 
            empPhoneNoLabel.AutoSize = true;
            empPhoneNoLabel.Location = new Point(151, 145);
            empPhoneNoLabel.Name = "empPhoneNoLabel";
            empPhoneNoLabel.Size = new Size(41, 15);
            empPhoneNoLabel.TabIndex = 4;
            empPhoneNoLabel.Text = "Phone";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 175);
            panel1.TabIndex = 5;
            // 
            // empId
            // 
            empId.AutoSize = true;
            empId.Location = new Point(151, 12);
            empId.Name = "empId";
            empId.Size = new Size(17, 15);
            empId.TabIndex = 6;
            empId.Text = "Id";
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(empId);
            Controls.Add(panel1);
            Controls.Add(empPhoneNoLabel);
            Controls.Add(empRole);
            Controls.Add(empSurname);
            Controls.Add(empName);
            Name = "EmployeeList";
            Size = new Size(700, 175);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label empName;
        private Label empSurname;
        private Label empRole;
        private Label empPhoneNoLabel;
        private Panel panel1;
        private Label empId;
    }
}
