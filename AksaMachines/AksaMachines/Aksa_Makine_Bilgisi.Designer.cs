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
            homePanel.SuspendLayout();
            employeePanel.SuspendLayout();
            signOutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // homePanel
            // 
            homePanel.Controls.Add(homeLabel);
            homePanel.Location = new Point(11, 120);
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
            employeePanel.Controls.Add(employeeLabel);
            employeePanel.Location = new Point(11, 192);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(193, 57);
            employeePanel.TabIndex = 2;
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
            signOutPanel.Controls.Add(signOutLabel);
            signOutPanel.Location = new Point(11, 264);
            signOutPanel.Name = "signOutPanel";
            signOutPanel.Size = new Size(193, 57);
            signOutPanel.TabIndex = 2;
            // 
            // signOutLabel
            // 
            signOutLabel.AutoSize = true;
            signOutLabel.Location = new Point(74, 23);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.Size = new Size(53, 15);
            signOutLabel.TabIndex = 0;
            signOutLabel.Text = "Sign Out";
            // 
            // allMachineDisplay
            // 
            allMachineDisplay.AutoScroll = true;
            allMachineDisplay.Dock = DockStyle.Right;
            allMachineDisplay.Location = new Point(240, 0);
            allMachineDisplay.Name = "allMachineDisplay";
            allMachineDisplay.Size = new Size(731, 568);
            allMachineDisplay.TabIndex = 4;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(12, 21);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(94, 15);
            employeeNameLabel.TabIndex = 5;
            employeeNameLabel.Text = "Employee Name";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new Point(12, 45);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(72, 15);
            employeeIdLabel.TabIndex = 6;
            employeeIdLabel.Text = "Employee Id";
            // 
            // employeeRoleLabel
            // 
            employeeRoleLabel.AutoSize = true;
            employeeRoleLabel.Location = new Point(13, 69);
            employeeRoleLabel.Name = "employeeRoleLabel";
            employeeRoleLabel.Size = new Size(85, 15);
            employeeRoleLabel.TabIndex = 7;
            employeeRoleLabel.Text = "Employee Role";
            // 
            // Aksa_Makine_Bilgisi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 568);
            Controls.Add(employeeRoleLabel);
            Controls.Add(employeeIdLabel);
            Controls.Add(employeeNameLabel);
            Controls.Add(allMachineDisplay);
            Controls.Add(signOutPanel);
            Controls.Add(employeePanel);
            Controls.Add(homePanel);
            Name = "Aksa_Makine_Bilgisi";
            Text = "Aksa_Makine_Bilgisi";
            Load += Aksa_Makine_Bilgisi_Load;
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}