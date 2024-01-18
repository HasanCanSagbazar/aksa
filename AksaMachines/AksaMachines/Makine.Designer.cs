namespace AksaMachines
{
    partial class Makine
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
            PersonelKullaniciAdi = new Label();
            panel1 = new Panel();
            machineAdd = new Label();
            envanterPanel = new Panel();
            envanter = new Label();
            employeeRoleLabel = new Label();
            employeeIdLabel = new Label();
            employeeNameLabel = new Label();
            signOutPanel = new Panel();
            signOutLabel = new Label();
            employeePanel = new Panel();
            employeeLabel = new Label();
            homePanel = new Panel();
            homeLabel = new Label();
            addMachine = new Button();
            dataGridView1 = new DataGridView();
            PersonelIdLabel = new Label();
            menuBarPanel = new Panel();
            machineNumtextBox = new TextBox();
            machineNametextBox = new TextBox();
            panel1.SuspendLayout();
            envanterPanel.SuspendLayout();
            signOutPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // PersonelKullaniciAdi
            // 
            PersonelKullaniciAdi.AutoSize = true;
            PersonelKullaniciAdi.Location = new Point(614, 97);
            PersonelKullaniciAdi.Name = "PersonelKullaniciAdi";
            PersonelKullaniciAdi.Size = new Size(67, 15);
            PersonelKullaniciAdi.TabIndex = 66;
            PersonelKullaniciAdi.Text = "Makine Adı";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(machineAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(224, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 67);
            panel1.TabIndex = 60;
            // 
            // machineAdd
            // 
            machineAdd.AutoSize = true;
            machineAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            machineAdd.Location = new Point(307, 19);
            machineAdd.Name = "machineAdd";
            machineAdd.Size = new Size(157, 32);
            machineAdd.TabIndex = 9;
            machineAdd.Text = "MAKİNE EKLE";
            // 
            // envanterPanel
            // 
            envanterPanel.BackColor = SystemColors.Control;
            envanterPanel.Controls.Add(envanter);
            envanterPanel.Location = new Point(13, 268);
            envanterPanel.Name = "envanterPanel";
            envanterPanel.Size = new Size(193, 57);
            envanterPanel.TabIndex = 3;
            envanterPanel.Click += envanterPanel_Clicked;
            // 
            // envanter
            // 
            envanter.AutoSize = true;
            envanter.Location = new Point(74, 21);
            envanter.Name = "envanter";
            envanter.Size = new Size(53, 15);
            envanter.TabIndex = 0;
            envanter.Text = "Envanter";
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
            employeePanel.Click += employeePanel_Clicked;
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
            // addMachine
            // 
            addMachine.Location = new Point(531, 169);
            addMachine.Name = "addMachine";
            addMachine.Size = new Size(124, 50);
            addMachine.TabIndex = 73;
            addMachine.Text = "EKLE";
            addMachine.UseVisualStyleBackColor = true;
            addMachine.Click += addMachine_Clicked;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(224, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 282);
            dataGridView1.TabIndex = 63;
            // 
            // PersonelIdLabel
            // 
            PersonelIdLabel.AutoSize = true;
            PersonelIdLabel.Location = new Point(476, 97);
            PersonelIdLabel.Name = "PersonelIdLabel";
            PersonelIdLabel.Size = new Size(100, 15);
            PersonelIdLabel.TabIndex = 61;
            PersonelIdLabel.Text = "Makine Numarası";
            // 
            // menuBarPanel
            // 
            menuBarPanel.BackColor = SystemColors.GradientInactiveCaption;
            menuBarPanel.Controls.Add(envanterPanel);
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
            menuBarPanel.TabIndex = 59;
            // 
            // machineNumtextBox
            // 
            machineNumtextBox.Location = new Point(469, 119);
            machineNumtextBox.Name = "machineNumtextBox";
            machineNumtextBox.Size = new Size(102, 23);
            machineNumtextBox.TabIndex = 74;
            // 
            // machineNametextBox
            // 
            machineNametextBox.Location = new Point(614, 119);
            machineNametextBox.Name = "machineNametextBox";
            machineNametextBox.Size = new Size(102, 23);
            machineNametextBox.TabIndex = 75;
            // 
            // Makine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 568);
            Controls.Add(machineNametextBox);
            Controls.Add(machineNumtextBox);
            Controls.Add(PersonelKullaniciAdi);
            Controls.Add(panel1);
            Controls.Add(addMachine);
            Controls.Add(dataGridView1);
            Controls.Add(PersonelIdLabel);
            Controls.Add(menuBarPanel);
            Name = "Makine";
            Text = "Makine";
            Load += machine_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            envanterPanel.ResumeLayout(false);
            envanterPanel.PerformLayout();
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuBarPanel.ResumeLayout(false);
            menuBarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label meslekLabel;
        private TextBox passwordTextBox;
        private TextBox roleTextBox;
        private TextBox jobTextBox;
        private TextBox nameTextBox;
        private TextBox userNameTextBox;
        private TextBox idTextBox;
        private Label PersonelKullaniciAdi;
        private Label passwordLabel;
        private Label rolName;
        private Panel panel1;
        private Label machineAdd;
        private Panel envanterPanel;
        private Label envanter;
        private Label employeeRoleLabel;
        private Label employeeIdLabel;
        private Label employeeNameLabel;
        private Panel signOutPanel;
        private Label signOutLabel;
        private Panel employeePanel;
        private Label employeeLabel;
        private Panel homePanel;
        private Label homeLabel;
        private Button addMachine;
        private DataGridView dataGridView1;
        private Label PersonelAdiLabel;
        private Label PersonelIdLabel;
        private Panel menuBarPanel;
        private TextBox machineNumtextBox;
        private TextBox machineNametextBox;
    }
}