namespace AksaMachines
{
    partial class MachineControl
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
            machineIdLabel = new Label();
            machineId_in = new Label();
            machineName_in = new Label();
            machineNameLabel = new Label();
            info1_in = new Label();
            info1Label = new Label();
            info2_in = new Label();
            info2Label = new Label();
            SuspendLayout();
            // 
            // machineIdLabel
            // 
            machineIdLabel.AutoSize = true;
            machineIdLabel.Location = new Point(91, 53);
            machineIdLabel.Name = "machineIdLabel";
            machineIdLabel.Size = new Size(100, 15);
            machineIdLabel.TabIndex = 0;
            machineIdLabel.Text = "Makine Numarası";
            // 
            // machineId_in
            // 
            machineId_in.AutoSize = true;
            machineId_in.Location = new Point(124, 78);
            machineId_in.Name = "machineId_in";
            machineId_in.Size = new Size(22, 15);
            machineId_in.TabIndex = 1;
            machineId_in.Text = "---";
            // 
            // machineName_in
            // 
            machineName_in.AutoSize = true;
            machineName_in.Location = new Point(124, 154);
            machineName_in.Name = "machineName_in";
            machineName_in.Size = new Size(22, 15);
            machineName_in.TabIndex = 3;
            machineName_in.Text = "---";
            // 
            // machineNameLabel
            // 
            machineNameLabel.AutoSize = true;
            machineNameLabel.Location = new Point(102, 129);
            machineNameLabel.Name = "machineNameLabel";
            machineNameLabel.Size = new Size(67, 15);
            machineNameLabel.TabIndex = 2;
            machineNameLabel.Text = "Makine Adı";
            // 
            // info1_in
            // 
            info1_in.AutoSize = true;
            info1_in.Location = new Point(124, 219);
            info1_in.Name = "info1_in";
            info1_in.Size = new Size(22, 15);
            info1_in.TabIndex = 5;
            info1_in.Text = "---";
            // 
            // info1Label
            // 
            info1Label.AutoSize = true;
            info1Label.Location = new Point(118, 204);
            info1Label.Name = "info1Label";
            info1Label.Size = new Size(37, 15);
            info1Label.TabIndex = 4;
            info1Label.Text = "Info 1";
            // 
            // info2_in
            // 
            info2_in.AutoSize = true;
            info2_in.Location = new Point(124, 275);
            info2_in.Name = "info2_in";
            info2_in.Size = new Size(22, 15);
            info2_in.TabIndex = 7;
            info2_in.Text = "---";
            // 
            // info2Label
            // 
            info2Label.AutoSize = true;
            info2Label.Location = new Point(118, 260);
            info2Label.Name = "info2Label";
            info2Label.Size = new Size(37, 15);
            info2Label.TabIndex = 6;
            info2Label.Text = "Info 2";
            // 
            // MachineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(info2_in);
            Controls.Add(info2Label);
            Controls.Add(info1_in);
            Controls.Add(info1Label);
            Controls.Add(machineName_in);
            Controls.Add(machineNameLabel);
            Controls.Add(machineId_in);
            Controls.Add(machineIdLabel);
            Name = "MachineControl";
            Size = new Size(295, 437);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label machineIdLabel;
        private Label machineId_in;
        private Label machineName_in;
        private Label machineNameLabel;
        private Label info1_in;
        private Label info1Label;
        private Label info2_in;
        private Label info2Label;
    }
}
