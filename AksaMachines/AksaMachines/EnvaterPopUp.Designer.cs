namespace AksaMachines
{
    partial class EnvaterPopUp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            envanterTitleLabel = new Label();
            envanterGenelBilgi = new Panel();
            envaterSayisiUp = new Label();
            envaterAdıLabel = new Label();
            envanterType = new ComboBox();
            envaterTürü = new Label();
            envanterSayisi = new Label();
            tekTipEnvanterSayısı = new NumericUpDown();
            envanterAyır = new Button();
            envanterGösterim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            envanterGenelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tekTipEnvanterSayısı).BeginInit();
            ((System.ComponentModel.ISupportInitialize)envanterGösterim).BeginInit();
            SuspendLayout();
            // 
            // envanterTitleLabel
            // 
            envanterTitleLabel.AutoSize = true;
            envanterTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            envanterTitleLabel.Location = new Point(255, 26);
            envanterTitleLabel.Name = "envanterTitleLabel";
            envanterTitleLabel.Size = new Size(141, 25);
            envanterTitleLabel.TabIndex = 0;
            envanterTitleLabel.Text = "Envanter Bilgisi";
            envanterTitleLabel.Click += envanterTitleLabel_Click;
            // 
            // envanterGenelBilgi
            // 
            envanterGenelBilgi.BackColor = Color.Wheat;
            envanterGenelBilgi.Controls.Add(envaterSayisiUp);
            envanterGenelBilgi.Controls.Add(envaterAdıLabel);
            envanterGenelBilgi.Location = new Point(220, 67);
            envanterGenelBilgi.Name = "envanterGenelBilgi";
            envanterGenelBilgi.Size = new Size(208, 71);
            envanterGenelBilgi.TabIndex = 1;
            // 
            // envaterSayisiUp
            // 
            envaterSayisiUp.AutoSize = true;
            envaterSayisiUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            envaterSayisiUp.Location = new Point(49, 37);
            envaterSayisiUp.Name = "envaterSayisiUp";
            envaterSayisiUp.Size = new Size(106, 21);
            envaterSayisiUp.TabIndex = 1;
            envaterSayisiUp.Text = "Envater Sayısı";
            // 
            // envaterAdıLabel
            // 
            envaterAdıLabel.AutoSize = true;
            envaterAdıLabel.Location = new Point(39, 9);
            envaterAdıLabel.Name = "envaterAdıLabel";
            envaterAdıLabel.Size = new Size(67, 15);
            envaterAdıLabel.TabIndex = 0;
            envaterAdıLabel.Text = "Envater Adı";
            // 
            // envanterType
            // 
            envanterType.FormattingEnabled = true;
            envanterType.Location = new Point(25, 207);
            envanterType.Name = "envanterType";
            envanterType.Size = new Size(272, 23);
            envanterType.TabIndex = 3;
            envanterType.SelectedValueChanged += envanterTürü_SelectedChangedValue;
            // 
            // envaterTürü
            // 
            envaterTürü.AutoSize = true;
            envaterTürü.Location = new Point(25, 179);
            envaterTürü.Name = "envaterTürü";
            envaterTürü.Size = new Size(80, 15);
            envaterTürü.TabIndex = 4;
            envaterTürü.Text = "Envanter Türü";
            // 
            // envanterSayisi
            // 
            envanterSayisi.AutoSize = true;
            envanterSayisi.Location = new Point(24, 253);
            envanterSayisi.Name = "envanterSayisi";
            envanterSayisi.Size = new Size(85, 15);
            envanterSayisi.TabIndex = 5;
            envanterSayisi.Text = "Envanter Sayısı";
            // 
            // tekTipEnvanterSayısı
            // 
            tekTipEnvanterSayısı.Location = new Point(25, 280);
            tekTipEnvanterSayısı.Name = "tekTipEnvanterSayısı";
            tekTipEnvanterSayısı.Size = new Size(80, 23);
            tekTipEnvanterSayısı.TabIndex = 6;
            // 
            // envanterAyır
            // 
            envanterAyır.Location = new Point(156, 327);
            envanterAyır.Name = "envanterAyır";
            envanterAyır.Size = new Size(157, 70);
            envanterAyır.TabIndex = 7;
            envanterAyır.Text = "AYIR";
            envanterAyır.UseVisualStyleBackColor = true;
            envanterAyır.Click += ayırButton_Clicked;
            // 
            // envanterGösterim
            // 
            envanterGösterim.BackColor = SystemColors.Info;
            chartArea1.Name = "ChartArea1";
            envanterGösterim.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            envanterGösterim.Legends.Add(legend1);
            envanterGösterim.Location = new Point(332, 165);
            envanterGösterim.Name = "envanterGösterim";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "envanterTürü";
            envanterGösterim.Series.Add(series1);
            envanterGösterim.Size = new Size(280, 232);
            envanterGösterim.TabIndex = 8;
            envanterGösterim.Text = "Envanter Sayısı";
            // 
            // EnvaterPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(637, 451);
            Controls.Add(envanterGösterim);
            Controls.Add(envanterAyır);
            Controls.Add(tekTipEnvanterSayısı);
            Controls.Add(envanterSayisi);
            Controls.Add(envaterTürü);
            Controls.Add(envanterType);
            Controls.Add(envanterGenelBilgi);
            Controls.Add(envanterTitleLabel);
            Name = "EnvaterPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Envanter";
            Load += envanterPopUp_Load;
            envanterGenelBilgi.ResumeLayout(false);
            envanterGenelBilgi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tekTipEnvanterSayısı).EndInit();
            ((System.ComponentModel.ISupportInitialize)envanterGösterim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label envanterTitleLabel;
        private Panel envanterGenelBilgi;
        private Label envaterAdıLabel;
        private Label envaterSayisiUp;
        private ComboBox envanterType;
        private Label envaterTürü;
        private Label envanterSayisi;
        private NumericUpDown tekTipEnvanterSayısı;
        private Button envanterAyır;
        private System.Windows.Forms.DataVisualization.Charting.Chart envanterGösterim;
    }
}