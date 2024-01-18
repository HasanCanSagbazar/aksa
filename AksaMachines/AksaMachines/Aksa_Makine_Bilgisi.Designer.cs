namespace AksaMachines
{
    partial class Aksa_Makine_Bilgisi
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
            homePanel = new Panel();
            homeLabel = new Label();
            employeePanel = new Panel();
            employeeLabel = new Label();
            signOutPanel = new Panel();
            signOutLabel = new Label();
            allMachineDisplay = new FlowLayoutPanel();
            employeeNameLabel = new Label();
            employeeIdLabel = new Label();
            employeeRoleLabel = new Label();
            envanterPanel = new Panel();
            envanter = new Label();
            menuBarPanel = new Panel();
            panel2 = new Panel();
            machinePanel = new Label();
            envanterName = new Label();
            spineretPanel = new Panel();
            spineretLabel = new Label();
            kolPanel = new Panel();
            kolLabel = new Label();
            kandilPanel = new Panel();
            kandilLabel = new Label();
            potFiltrePanel = new Panel();
            potFiltreLabel = new Label();
            makineLabel = new Label();
            panel1 = new Panel();
            EnvanterListesi = new ListBox();
            sendButton = new Button();
            homePanel.SuspendLayout();
            employeePanel.SuspendLayout();
            signOutPanel.SuspendLayout();
            envanterPanel.SuspendLayout();
            menuBarPanel.SuspendLayout();
            panel2.SuspendLayout();
            spineretPanel.SuspendLayout();
            kolPanel.SuspendLayout();
            kandilPanel.SuspendLayout();
            potFiltrePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.BackColor = SystemColors.Control;
            homePanel.Controls.Add(homeLabel);
            homePanel.Location = new Point(11, 118);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(193, 57);
            homePanel.TabIndex = 1;
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
            // employeePanel
            // 
            employeePanel.BackColor = SystemColors.Control;
            employeePanel.Controls.Add(employeeLabel);
            employeePanel.Location = new Point(11, 190);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(193, 57);
            employeePanel.TabIndex = 2;
            employeePanel.Click += personelPanel_Clicked;
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
            // allMachineDisplay
            // 
            allMachineDisplay.AutoScroll = true;
            allMachineDisplay.Location = new Point(590, 67);
            allMachineDisplay.Name = "allMachineDisplay";
            allMachineDisplay.Size = new Size(381, 501);
            allMachineDisplay.TabIndex = 4;
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
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new Point(12, 43);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(72, 15);
            employeeIdLabel.TabIndex = 6;
            employeeIdLabel.Text = "Employee Id";
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
            // envanterPanel
            // 
            envanterPanel.BackColor = SystemColors.Control;
            envanterPanel.Controls.Add(envanter);
            envanterPanel.Location = new Point(13, 268);
            envanterPanel.Name = "envanterPanel";
            envanterPanel.Size = new Size(193, 57);
            envanterPanel.TabIndex = 3;
            envanterPanel.Click += envanter_Clicked;
            // 
            // envanter
            // 
            envanter.AutoSize = true;
            envanter.Location = new Point(74, 21);
            envanter.Name = "envanter";
            envanter.Size = new Size(53, 15);
            envanter.TabIndex = 0;
            envanter.Text = "Envanter";
            envanter.Click += label1_Click;
            // 
            // menuBarPanel
            // 
            menuBarPanel.BackColor = SystemColors.GradientInactiveCaption;
            menuBarPanel.Controls.Add(panel2);
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
            menuBarPanel.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(machinePanel);
            panel2.Location = new Point(13, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(193, 57);
            panel2.TabIndex = 4;
            panel2.Click += machinePanel_Clicked;
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
            // envanterName
            // 
            envanterName.AutoSize = true;
            envanterName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            envanterName.Location = new Point(66, 19);
            envanterName.Name = "envanterName";
            envanterName.Size = new Size(239, 32);
            envanterName.TabIndex = 9;
            envanterName.Text = "ENVANTER ÇEŞİTLERİ";
            // 
            // spineretPanel
            // 
            spineretPanel.BackColor = SystemColors.ActiveCaption;
            spineretPanel.Controls.Add(spineretLabel);
            spineretPanel.Location = new Point(248, 83);
            spineretPanel.Name = "spineretPanel";
            spineretPanel.Size = new Size(241, 59);
            spineretPanel.TabIndex = 10;
            spineretPanel.Click += spineretPanel_Clicked;
            // 
            // spineretLabel
            // 
            spineretLabel.AutoSize = true;
            spineretLabel.Location = new Point(96, 22);
            spineretLabel.Name = "spineretLabel";
            spineretLabel.Size = new Size(50, 15);
            spineretLabel.TabIndex = 0;
            spineretLabel.Text = "Spineret";
            // 
            // kolPanel
            // 
            kolPanel.BackColor = SystemColors.ActiveCaption;
            kolPanel.Controls.Add(kolLabel);
            kolPanel.Location = new Point(248, 158);
            kolPanel.Name = "kolPanel";
            kolPanel.Size = new Size(241, 59);
            kolPanel.TabIndex = 11;
            kolPanel.Click += kolPanel_Click;
            // 
            // kolLabel
            // 
            kolLabel.AutoSize = true;
            kolLabel.Location = new Point(107, 25);
            kolLabel.Name = "kolLabel";
            kolLabel.Size = new Size(24, 15);
            kolLabel.TabIndex = 2;
            kolLabel.Text = "Kol";
            // 
            // kandilPanel
            // 
            kandilPanel.BackColor = SystemColors.ActiveCaption;
            kandilPanel.Controls.Add(kandilLabel);
            kandilPanel.Location = new Point(248, 236);
            kandilPanel.Name = "kandilPanel";
            kandilPanel.Size = new Size(241, 59);
            kandilPanel.TabIndex = 12;
            kandilPanel.Click += kandilPanel_Click;
            // 
            // kandilLabel
            // 
            kandilLabel.AutoSize = true;
            kandilLabel.Location = new Point(98, 24);
            kandilLabel.Name = "kandilLabel";
            kandilLabel.Size = new Size(40, 15);
            kandilLabel.TabIndex = 3;
            kandilLabel.Text = "Kandil";
            // 
            // potFiltrePanel
            // 
            potFiltrePanel.BackColor = SystemColors.ActiveCaption;
            potFiltrePanel.Controls.Add(potFiltreLabel);
            potFiltrePanel.Location = new Point(248, 318);
            potFiltrePanel.Name = "potFiltrePanel";
            potFiltrePanel.Size = new Size(241, 59);
            potFiltrePanel.TabIndex = 13;
            potFiltrePanel.Click += potFiltrePanel_Click;
            // 
            // potFiltreLabel
            // 
            potFiltreLabel.AutoSize = true;
            potFiltreLabel.Location = new Point(92, 25);
            potFiltreLabel.Name = "potFiltreLabel";
            potFiltreLabel.Size = new Size(51, 15);
            potFiltreLabel.TabIndex = 4;
            potFiltreLabel.Text = "PotFiltre";
            // 
            // makineLabel
            // 
            makineLabel.AutoSize = true;
            makineLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            makineLabel.Location = new Point(485, 19);
            makineLabel.Name = "makineLabel";
            makineLabel.Size = new Size(138, 32);
            makineLabel.TabIndex = 14;
            makineLabel.Text = "MAKİNELER";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(makineLabel);
            panel1.Controls.Add(envanterName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(224, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 67);
            panel1.TabIndex = 15;
            // 
            // EnvanterListesi
            // 
            EnvanterListesi.BackColor = Color.AntiqueWhite;
            EnvanterListesi.BorderStyle = BorderStyle.None;
            EnvanterListesi.FormattingEnabled = true;
            EnvanterListesi.ItemHeight = 15;
            EnvanterListesi.Location = new Point(248, 399);
            EnvanterListesi.Name = "EnvanterListesi";
            EnvanterListesi.Size = new Size(243, 135);
            EnvanterListesi.TabIndex = 16;
            // 
            // sendButton
            // 
            sendButton.Location = new Point(505, 249);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(70, 36);
            sendButton.TabIndex = 17;
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Clicked;
            // 
            // Aksa_Makine_Bilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(971, 568);
            Controls.Add(sendButton);
            Controls.Add(EnvanterListesi);
            Controls.Add(panel1);
            Controls.Add(potFiltrePanel);
            Controls.Add(kandilPanel);
            Controls.Add(kolPanel);
            Controls.Add(spineretPanel);
            Controls.Add(menuBarPanel);
            Controls.Add(allMachineDisplay);
            Name = "Aksa_Makine_Bilgisi";
            Text = "Aksa_Makine_Bilgisi";
            Load += Aksa_Makine_Bilgisi_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            envanterPanel.ResumeLayout(false);
            envanterPanel.PerformLayout();
            menuBarPanel.ResumeLayout(false);
            menuBarPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            spineretPanel.ResumeLayout(false);
            spineretPanel.PerformLayout();
            kolPanel.ResumeLayout(false);
            kolPanel.PerformLayout();
            kandilPanel.ResumeLayout(false);
            kandilPanel.PerformLayout();
            potFiltrePanel.ResumeLayout(false);
            potFiltrePanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel homePanel;
        private Label homeLabel;
        private Panel employeePanel;
        private Label employeeLabel;
        private Panel signOutPanel;
        private Label signOutLabel;
        private FlowLayoutPanel allMachineDisplay;
        private Label employeeNameLabel;
        private Label employeeIdLabel;
        private Label employeeRoleLabel;
        private Panel envanterPanel;
        private Label envanter;
        private Panel menuBarPanel;
        private Label envanterName;
        private Panel spineretPanel;
        private Label spineretLabel;
        private Panel kolPanel;
        private Label kolLabel;
        private Panel kandilPanel;
        private Label kandilLabel;
        private Panel potFiltrePanel;
        private Label potFiltreLabel;
        private Label makineLabel;
        private Panel panel1;
        private ListBox EnvanterListesi;
        private Button sendButton;
        private Panel panel2;
        private Label machinePanel;
    }
}