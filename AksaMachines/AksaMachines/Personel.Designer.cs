namespace AksaMachines
{
    partial class Personel
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
            dataGridView1 = new DataGridView();
            PersonelAdiLabel = new Label();
            PersonelIdLabel = new Label();
            homeLabel = new Label();
            homePanel = new Panel();
            signOutLabel = new Label();
            employeeRoleLabel = new Label();
            employeeIdLabel = new Label();
            employeeNameLabel = new Label();
            signOutPanel = new Panel();
            envanter = new Label();
            envanterPanel = new Panel();
            menuBarPanel = new Panel();
            makinePanel = new Panel();
            machinePanel = new Label();
            personelAdd = new Label();
            panel1 = new Panel();
            rolName = new Label();
            passwordLabel = new Label();
            PersonelKullaniciAdi = new Label();
            idTextBox = new TextBox();
            userNameTextBox = new TextBox();
            nameTextBox = new TextBox();
            jobTextBox = new TextBox();
            roleTextBox = new TextBox();
            passwordTextBox = new TextBox();
            addEmloyee = new Button();
            meslekLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            homePanel.SuspendLayout();
            signOutPanel.SuspendLayout();
            envanterPanel.SuspendLayout();
            menuBarPanel.SuspendLayout();
            makinePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(224, 286);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 282);
            dataGridView1.TabIndex = 47;
            // 
            // PersonelAdiLabel
            // 
            PersonelAdiLabel.AutoSize = true;
            PersonelAdiLabel.Location = new Point(501, 97);
            PersonelAdiLabel.Name = "PersonelAdiLabel";
            PersonelAdiLabel.Size = new Size(73, 15);
            PersonelAdiLabel.TabIndex = 44;
            PersonelAdiLabel.Text = "Personel Adı";
            // 
            // PersonelIdLabel
            // 
            PersonelIdLabel.AutoSize = true;
            PersonelIdLabel.Location = new Point(259, 97);
            PersonelIdLabel.Name = "PersonelIdLabel";
            PersonelIdLabel.Size = new Size(65, 15);
            PersonelIdLabel.TabIndex = 39;
            PersonelIdLabel.Text = "Personel Id";
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
            // signOutLabel
            // 
            signOutLabel.AutoSize = true;
            signOutLabel.Location = new Point(74, 22);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.Size = new Size(53, 15);
            signOutLabel.TabIndex = 0;
            signOutLabel.Text = "Sign Out";
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
            signOutPanel.Location = new Point(13, 441);
            signOutPanel.Name = "signOutPanel";
            signOutPanel.Size = new Size(193, 57);
            signOutPanel.TabIndex = 2;
            signOutPanel.Click += signOutPanel_Clicked;
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
            // envanterPanel
            // 
            envanterPanel.BackColor = SystemColors.Control;
            envanterPanel.Controls.Add(envanter);
            envanterPanel.Location = new Point(13, 195);
            envanterPanel.Name = "envanterPanel";
            envanterPanel.Size = new Size(193, 57);
            envanterPanel.TabIndex = 3;
            // 
            // menuBarPanel
            // 
            menuBarPanel.BackColor = SystemColors.GradientInactiveCaption;
            menuBarPanel.Controls.Add(makinePanel);
            menuBarPanel.Controls.Add(envanterPanel);
            menuBarPanel.Controls.Add(employeeRoleLabel);
            menuBarPanel.Controls.Add(employeeIdLabel);
            menuBarPanel.Controls.Add(employeeNameLabel);
            menuBarPanel.Controls.Add(signOutPanel);
            menuBarPanel.Controls.Add(homePanel);
            menuBarPanel.Dock = DockStyle.Left;
            menuBarPanel.Location = new Point(0, 67);
            menuBarPanel.Name = "menuBarPanel";
            menuBarPanel.Size = new Size(224, 501);
            menuBarPanel.TabIndex = 36;
            // 
            // makinePanel
            // 
            makinePanel.BackColor = SystemColors.Control;
            makinePanel.Controls.Add(machinePanel);
            makinePanel.Location = new Point(13, 273);
            makinePanel.Name = "makinePanel";
            makinePanel.Size = new Size(193, 57);
            makinePanel.TabIndex = 8;
            makinePanel.Click += makinePanel_Clicked;
            // 
            // machinePanel
            // 
            machinePanel.AutoSize = true;
            machinePanel.Location = new Point(74, 21);
            machinePanel.Name = "machinePanel";
            machinePanel.Size = new Size(46, 15);
            machinePanel.TabIndex = 0;
            machinePanel.Text = "Makine";
            // 
            // personelAdd
            // 
            personelAdd.AutoSize = true;
            personelAdd.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            personelAdd.Location = new Point(298, 23);
            personelAdd.Name = "personelAdd";
            personelAdd.Size = new Size(181, 32);
            personelAdd.TabIndex = 9;
            personelAdd.Text = "PERSONEL EKLE";
            personelAdd.Click += envanterAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(personelAdd);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 67);
            panel1.TabIndex = 37;
            // 
            // rolName
            // 
            rolName.AutoSize = true;
            rolName.Location = new Point(753, 97);
            rolName.Name = "rolName";
            rolName.Size = new Size(24, 15);
            rolName.TabIndex = 48;
            rolName.Text = "Rol";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(875, 97);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(30, 15);
            passwordLabel.TabIndex = 49;
            passwordLabel.Text = "Şifre";
            // 
            // PersonelKullaniciAdi
            // 
            PersonelKullaniciAdi.AutoSize = true;
            PersonelKullaniciAdi.Location = new Point(358, 97);
            PersonelKullaniciAdi.Name = "PersonelKullaniciAdi";
            PersonelKullaniciAdi.Size = new Size(121, 15);
            PersonelKullaniciAdi.TabIndex = 50;
            PersonelKullaniciAdi.Text = "Personel Kullanıcı Adı";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(247, 118);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(87, 23);
            idTextBox.TabIndex = 51;
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(372, 118);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(87, 23);
            userNameTextBox.TabIndex = 52;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(501, 118);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(87, 23);
            nameTextBox.TabIndex = 53;
            // 
            // jobTextBox
            // 
            jobTextBox.Location = new Point(616, 118);
            jobTextBox.Name = "jobTextBox";
            jobTextBox.Size = new Size(87, 23);
            jobTextBox.TabIndex = 54;
            // 
            // roleTextBox
            // 
            roleTextBox.Location = new Point(732, 118);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(87, 23);
            roleTextBox.TabIndex = 55;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(847, 118);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(87, 23);
            passwordTextBox.TabIndex = 56;
            // 
            // addEmloyee
            // 
            addEmloyee.Location = new Point(531, 169);
            addEmloyee.Name = "addEmloyee";
            addEmloyee.Size = new Size(124, 50);
            addEmloyee.TabIndex = 57;
            addEmloyee.Text = "EKLE";
            addEmloyee.UseVisualStyleBackColor = true;
            addEmloyee.Click += addEmployee_Clicked;
            // 
            // meslekLabel
            // 
            meslekLabel.AutoSize = true;
            meslekLabel.Location = new Point(631, 97);
            meslekLabel.Name = "meslekLabel";
            meslekLabel.Size = new Size(44, 15);
            meslekLabel.TabIndex = 58;
            meslekLabel.Text = "Meslek";
            // 
            // Personel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 568);
            Controls.Add(meslekLabel);
            Controls.Add(addEmloyee);
            Controls.Add(passwordTextBox);
            Controls.Add(roleTextBox);
            Controls.Add(jobTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(PersonelKullaniciAdi);
            Controls.Add(passwordLabel);
            Controls.Add(rolName);
            Controls.Add(dataGridView1);
            Controls.Add(PersonelAdiLabel);
            Controls.Add(PersonelIdLabel);
            Controls.Add(menuBarPanel);
            Controls.Add(panel1);
            Name = "Personel";
            Text = "Personel";
            Load += personel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            envanterPanel.ResumeLayout(false);
            envanterPanel.PerformLayout();
            menuBarPanel.ResumeLayout(false);
            menuBarPanel.PerformLayout();
            makinePanel.ResumeLayout(false);
            makinePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox envanterSizeComboBox;
        private Label PersonelAdiLabel;
        private Button addButton;
        private NumericUpDown envanterEkleUpDown;
        private Label stokLabel;
        private ComboBox EnvanterTürüComboBox;
        private Label PersonelIdLabel;
        private ComboBox EnvanterAdiComboBox;
        private Label homeLabel;
        private Panel homePanel;
        private Label signOutLabel;
        private Label employeeRoleLabel;
        private Label employeeIdLabel;
        private Label employeeNameLabel;
        private Panel signOutPanel;
        private Label envanter;
        private Panel envanterPanel;
        private Panel menuBarPanel;
        private Label personelAdd;
        private Label envanterSize;
        private Panel panel1;
        private Label rolName;
        private Label passwordLabel;
        private Label PersonelKullaniciAdi;
        private TextBox idTextBox;
        private TextBox userNameTextBox;
        private TextBox nameTextBox;
        private TextBox jobTextBox;
        private TextBox roleTextBox;
        private TextBox passwordTextBox;
        private Button addEmloyee;
        private Label meslekLabel;
        private Panel makinePanel;
        private Label machinePanel;
    }
}