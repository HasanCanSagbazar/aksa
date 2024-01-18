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
            // MachineControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            Controls.Add(machineName_in);
            Controls.Add(machineNameLabel);
            Controls.Add(machineId_in);
            Controls.Add(machineIdLabel);
            Name = "MachineControl";
            Size = new Size(295, 213);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label machineIdLabel;
        private Label machineId_in;
        private Label machineName_in;
        private Label machineNameLabel;
    }
}
