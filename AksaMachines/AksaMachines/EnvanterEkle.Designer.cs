namespace AksaMachines
{
    partial class EnvanterEkle
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
            panel1 = new Panel();
            envanterAdd = new Label();
            menuBarPanel = new Panel();
            makinePanel = new Panel();
            makineLabel = new Label();
            employeeRoleLabel = new Label();
            employeeIdLabel = new Label();
            employeeNameLabel = new Label();
            signOutPanel = new Panel();
            signOutLabel = new Label();
            employeePanel = new Panel();
            employeeLabel = new Label();
            homePanel = new Panel();
            homeLabel = new Label();
            EnvanterAdiComboBox = new ComboBox();
            EnvanterTürüComboBox = new ComboBox();
            EnvanterTypeLabel = new Label();
            stokLabel = new Label();
            envanterEkleUpDown = new NumericUpDown();
            addButton = new Button();
            EnvanterAdiLabel = new Label();
            envanterSizeComboBox = new ComboBox();
            envanterSize = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            menuBarPanel.SuspendLayout();
            makinePanel.SuspendLayout();
            signOutPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)envanterEkleUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(envanterAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(224, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 67);
            panel1.TabIndex = 24;
            // 
            // envanterAdd
            // 
            envanterAdd.AutoSize = true;
            envanterAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            envanterAdd.Location = new Point(66, 19);
            envanterAdd.Name = "envanterAdd";
            envanterAdd.Size = new Size(186, 32);
            envanterAdd.TabIndex = 9;
            envanterAdd.Text = "ENVANTER EKLE";
            // 
            // menuBarPanel
            // 
            menuBarPanel.BackColor = SystemColors.GradientInactiveCaption;
            menuBarPanel.Controls.Add(makinePanel);
            menuBarPanel.Controls.Add(employeeRoleLabel);
            menuBarPanel.Controls.Add(employeeIdLabel);
            menuBarPanel.Controls.Add(employeeNameLabel);
            menuBarPanel.Controls.Add(signOutPanel);
            menuBarPanel.Controls.Add(employeePanel);
            menuBarPanel.Controls.Add(homePanel);
            menuBarPanel.Dock = DockStyle.Left;
            menuBarPanel.Location = new Point(0, 0);
            menuBarPanel.Name = "menuBarPanel";
            menuBarPanel.Size = new Size(224, 568);
            menuBarPanel.TabIndex = 19;
            // 
            // makinePanel
            // 
            makinePanel.BackColor = SystemColors.Control;
            makinePanel.Controls.Add(makineLabel);
            makinePanel.Location = new Point(13, 268);
            makinePanel.Name = "makinePanel";
            makinePanel.Size = new Size(193, 57);
            makinePanel.TabIndex = 3;
            makinePanel.Click += makinePanel_Clicked;
            // 
            // makineLabel
            // 
            makineLabel.AutoSize = true;
            makineLabel.Location = new Point(74, 21);
            makineLabel.Name = "makineLabel";
            makineLabel.Size = new Size(46, 15);
            makineLabel.TabIndex = 0;
            makineLabel.Text = "Makine";
            // 
            // employeeRoleLabel
            // 
            employeeRoleLabel.AutoSize = true;
            employeeRoleLabel.Location = new Point(13, 67);
            employeeRoleLabel.Name = "employeeRoleLabel";
            employeeRoleLabel.Size = new Size(85, 15);
            employeeRoleLabel.TabIndex = 7;
            employeeRoleLabel.Text = "Employee Role";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new Point(12, 43);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(72, 15);
            employeeIdLabel.TabIndex = 6;
            employeeIdLabel.Text = "Employee Id";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(12, 19);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(94, 15);
            employeeNameLabel.TabIndex = 5;
            employeeNameLabel.Text = "Employee Name";
            // 
            // signOutPanel
            // 
            signOutPanel.BackColor = SystemColors.ControlDark;
            signOutPanel.Controls.Add(signOutLabel);
            signOutPanel.Location = new Point(11, 497);
            signOutPanel.Name = "signOutPanel";
            signOutPanel.Size = new Size(193, 57);
            signOutPanel.TabIndex = 2;
            signOutPanel.Click += signOutPanel_Clicked;
            // 
            // signOutLabel
            // 
            signOutLabel.AutoSize = true;
            signOutLabel.Location = new Point(74, 22);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.Size = new Size(53, 15);
            signOutLabel.TabIndex = 0;
            signOutLabel.Text = "Sign Out";
            // 
            // employeePanel
            // 
            employeePanel.BackColor = SystemColors.Control;
            employeePanel.Controls.Add(employeeLabel);
            employeePanel.Location = new Point(11, 190);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(193, 57);
            employeePanel.TabIndex = 2;
            employeePanel.Click += employePanel_Clicked;
            // 
            // employeeLabel
            // 
            employeeLabel.AutoSize = true;
            employeeLabel.Location = new Point(74, 21);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(59, 15);
            employeeLabel.TabIndex = 0;
            employeeLabel.Text = "Employee";
            // 
            // homePanel
            // 
            homePanel.BackColor = SystemColors.Control;
            homePanel.Controls.Add(homeLabel);
            homePanel.Location = new Point(11, 118);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(193, 57);
            homePanel.TabIndex = 1;
            homePanel.Click += homePanel_Clicked;
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Location = new Point(74, 19);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(40, 15);
            homeLabel.TabIndex = 3;
            homeLabel.Text = "Home";
            // 
            // EnvanterAdiComboBox
            // 
            EnvanterAdiComboBox.FormattingEnabled = true;
            EnvanterAdiComboBox.Location = new Point(248, 124);
            EnvanterAdiComboBox.Name = "EnvanterAdiComboBox";
            EnvanterAdiComboBox.Size = new Size(114, 23);
            EnvanterAdiComboBox.TabIndex = 26;
            EnvanterAdiComboBox.SelectedValueChanged += envanterAdi_Chosen;
            // 
            // EnvanterTürüComboBox
            // 
            EnvanterTürüComboBox.FormattingEnabled = true;
            EnvanterTürüComboBox.Location = new Point(405, 124);
            EnvanterTürüComboBox.Name = "EnvanterTürüComboBox";
            EnvanterTürüComboBox.Size = new Size(114, 23);
            EnvanterTürüComboBox.TabIndex = 28;
            // 
            // EnvanterTypeLabel
            // 
            EnvanterTypeLabel.AutoSize = true;
            EnvanterTypeLabel.Location = new Point(405, 97);
            EnvanterTypeLabel.Name = "EnvanterTypeLabel";
            EnvanterTypeLabel.Size = new Size(80, 15);
            EnvanterTypeLabel.TabIndex = 27;
            EnvanterTypeLabel.Text = "Envanter Türü";
            // 
            // stokLabel
            // 
            stokLabel.AutoSize = true;
            stokLabel.Location = new Point(558, 97);
            stokLabel.Name = "stokLabel";
            stokLabel.Size = new Size(41, 15);
            stokLabel.TabIndex = 29;
            stokLabel.Text = "Miktar";
            // 
            // envanterEkleUpDown
            // 
            envanterEkleUpDown.Location = new Point(558, 124);
            envanterEkleUpDown.Name = "envanterEkleUpDown";
            envanterEkleUpDown.Size = new Size(78, 23);
            envanterEkleUpDown.TabIndex = 30;
            // 
            // addButton
            // 
            addButton.Location = new Point(605, 172);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 41);
            addButton.TabIndex = 31;
            addButton.Text = "Ekle";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addNewItem_Click;
            // 
            // EnvanterAdiLabel
            // 
            EnvanterAdiLabel.AutoSize = true;
            EnvanterAdiLabel.Location = new Point(248, 97);
            EnvanterAdiLabel.Name = "EnvanterAdiLabel";
            EnvanterAdiLabel.Size = new Size(74, 15);
            EnvanterAdiLabel.TabIndex = 32;
            EnvanterAdiLabel.Text = "Envanter Adı";
            // 
            // envanterSizeComboBox
            // 
            envanterSizeComboBox.FormattingEnabled = true;
            envanterSizeComboBox.Location = new Point(405, 187);
            envanterSizeComboBox.Name = "envanterSizeComboBox";
            envanterSizeComboBox.Size = new Size(114, 23);
            envanterSizeComboBox.TabIndex = 34;
            // 
            // envanterSize
            // 
            envanterSize.AutoSize = true;
            envanterSize.Location = new Point(405, 160);
            envanterSize.Name = "envanterSize";
            envanterSize.Size = new Size(94, 15);
            envanterSize.TabIndex = 33;
            envanterSize.Text = "Envanter Boyutu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(224, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 282);
            dataGridView1.TabIndex = 35;
            // 
            // EnvanterEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 568);
            Controls.Add(dataGridView1);
            Controls.Add(envanterSizeComboBox);
            Controls.Add(envanterSize);
            Controls.Add(EnvanterAdiLabel);
            Controls.Add(addButton);
            Controls.Add(envanterEkleUpDown);
            Controls.Add(stokLabel);
            Controls.Add(EnvanterTürüComboBox);
            Controls.Add(EnvanterTypeLabel);
            Controls.Add(EnvanterAdiComboBox);
            Controls.Add(panel1);
            Controls.Add(menuBarPanel);
            Name = "EnvanterEkle";
            Text = "EnvanterEkle";
            Load += EnvanterEkle_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuBarPanel.ResumeLayout(false);
            menuBarPanel.PerformLayout();
            makinePanel.ResumeLayout(false);
            makinePanel.PerformLayout();
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)envanterEkleUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label envanterAdd;
        private Label potFiltreLabel;
        private Panel potFiltrePanel;
        private Label kandilLabel;
        private Panel kandilPanel;
        private Label kolLabel;
        private Panel kolPanel;
        private Label spineretLabel;
        private Panel spineretPanel;
        private Panel menuBarPanel;
        private Panel makinePanel;
        private Label makineLabel;
        private Label employeeRoleLabel;
        private Label employeeIdLabel;
        private Label employeeNameLabel;
        private Panel signOutPanel;
        private Label signOutLabel;
        private Panel employeePanel;
        private Label employeeLabel;
        private Panel homePanel;
        private Label homeLabel;
        private Label envanterTypeLabel;
        private ComboBox EnvanterAdiComboBox;
        private ComboBox EnvanterTürüComboBox;
        private Label EnvanterTypeLabel;
        private Label stokLabel;
        private NumericUpDown envanterEkleUpDown;
        private Button addButton;
        private Label EnvanterAdiLabel;
        private ComboBox envanterSizeComboBox;
        private Label envanterSize;
        private DataGridView dataGridView1;
    }
}