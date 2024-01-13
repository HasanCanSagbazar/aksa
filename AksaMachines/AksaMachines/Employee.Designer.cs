namespace AksaMachines
{
    partial class Employee
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
            employeeRoleLabel = new Label();
            employeeIdLabel = new Label();
            employeeNameLabel = new Label();
            signOutPanel = new Panel();
            signOutLabel = new Label();
            employeePanel = new Panel();
            employeeLabel = new Label();
            homePanel = new Panel();
            homeLabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            allEmployeeInfo = new FlowLayoutPanel();
            signOutPanel.SuspendLayout();
            employeePanel.SuspendLayout();
            homePanel.SuspendLayout();
            SuspendLayout();
            // 
            // employeeRoleLabel
            // 
            employeeRoleLabel.AutoSize = true;
            employeeRoleLabel.Location = new Point(7, 69);
            employeeRoleLabel.Name = "employeeRoleLabel";
            employeeRoleLabel.Size = new Size(85, 15);
            employeeRoleLabel.TabIndex = 14;
            employeeRoleLabel.Text = "Employee Role";
            // 
            // employeeIdLabel
            // 
            employeeIdLabel.AutoSize = true;
            employeeIdLabel.Location = new Point(6, 45);
            employeeIdLabel.Name = "employeeIdLabel";
            employeeIdLabel.Size = new Size(72, 15);
            employeeIdLabel.TabIndex = 13;
            employeeIdLabel.Text = "Employee Id";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(6, 21);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(94, 15);
            employeeNameLabel.TabIndex = 12;
            employeeNameLabel.Text = "Employee Name";
            // 
            // signOutPanel
            // 
            signOutPanel.Controls.Add(signOutLabel);
            signOutPanel.Location = new Point(5, 264);
            signOutPanel.Name = "signOutPanel";
            signOutPanel.Size = new Size(193, 57);
            signOutPanel.TabIndex = 9;
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
            // employeePanel
            // 
            employeePanel.BackColor = SystemColors.ControlDark;
            employeePanel.Controls.Add(employeeLabel);
            employeePanel.Location = new Point(5, 192);
            employeePanel.Name = "employeePanel";
            employeePanel.Size = new Size(193, 57);
            employeePanel.TabIndex = 10;
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
            homePanel.Controls.Add(homeLabel);
            homePanel.Location = new Point(5, 120);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(193, 57);
            homePanel.TabIndex = 8;
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(203, 264);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(756, 299);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // allEmployeeInfo
            // 
            allEmployeeInfo.AutoScroll = true;
            allEmployeeInfo.Location = new Point(204, 4);
            allEmployeeInfo.Name = "allEmployeeInfo";
            allEmployeeInfo.Size = new Size(755, 246);
            allEmployeeInfo.TabIndex = 11;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 568);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(employeeRoleLabel);
            Controls.Add(employeeIdLabel);
            Controls.Add(employeeNameLabel);
            Controls.Add(allEmployeeInfo);
            Controls.Add(signOutPanel);
            Controls.Add(employeePanel);
            Controls.Add(homePanel);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            signOutPanel.ResumeLayout(false);
            signOutPanel.PerformLayout();
            employeePanel.ResumeLayout(false);
            employeePanel.PerformLayout();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeRoleLabel;
        private Label employeeIdLabel;
        private Label employeeNameLabel;
        private Panel signOutPanel;
        private Label signOutLabel;
        private Panel employeePanel;
        private Label employeeLabel;
        private Panel homePanel;
        private Label homeLabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel allEmployeeInfo;
    }
}