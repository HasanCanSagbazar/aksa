namespace AksaMachines
{
    partial class AksaMachineInfo
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            turnHome = new FlowLayoutPanel();
            homeLabel = new Label();
            newEmployee = new FlowLayoutPanel();
            turnHomeLabel = new Label();
            empLabel = new Label();
            signOut = new FlowLayoutPanel();
            signOutLabel = new Label();
            IdLabel = new Label();
            turnHome.SuspendLayout();
            newEmployee.SuspendLayout();
            signOut.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1101, 545);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 51);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(204, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 652);
            panel1.TabIndex = 1;
            // 
            // turnHome
            // 
            turnHome.Controls.Add(IdLabel);
            turnHome.Controls.Add(homeLabel);
            turnHome.Location = new Point(12, 144);
            turnHome.Name = "turnHome";
            turnHome.Size = new Size(178, 39);
            turnHome.TabIndex = 0;
            turnHome.Paint += turnHome_Paint;
            // 
            // homeLabel
            // 
            homeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            homeLabel.AutoSize = true;
            homeLabel.Location = new Point(82, 0);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(40, 15);
            homeLabel.TabIndex = 5;
            homeLabel.Text = "Home";
            homeLabel.TextAlign = ContentAlignment.MiddleCenter;
            homeLabel.Click += label1_Click_1;
            // 
            // newEmployee
            // 
            newEmployee.Controls.Add(turnHomeLabel);
            newEmployee.Controls.Add(empLabel);
            newEmployee.Location = new Point(12, 203);
            newEmployee.Name = "newEmployee";
            newEmployee.Size = new Size(178, 39);
            newEmployee.TabIndex = 1;
            // 
            // turnHomeLabel
            // 
            turnHomeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            turnHomeLabel.AutoSize = true;
            turnHomeLabel.Location = new Point(3, 0);
            turnHomeLabel.Name = "turnHomeLabel";
            turnHomeLabel.Size = new Size(40, 15);
            turnHomeLabel.TabIndex = 4;
            turnHomeLabel.Text = "Home";
            turnHomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            turnHomeLabel.Click += label1_Click;
            // 
            // empLabel
            // 
            empLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            empLabel.AutoSize = true;
            empLabel.Location = new Point(49, 0);
            empLabel.Name = "empLabel";
            empLabel.Size = new Size(59, 15);
            empLabel.TabIndex = 7;
            empLabel.Text = "Employee";
            empLabel.TextAlign = ContentAlignment.MiddleCenter;
            empLabel.Click += label2_Click_1;
            // 
            // signOut
            // 
            signOut.Controls.Add(signOutLabel);
            signOut.Location = new Point(12, 258);
            signOut.Name = "signOut";
            signOut.Size = new Size(178, 39);
            signOut.TabIndex = 2;
            // 
            // signOutLabel
            // 
            signOutLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            signOutLabel.AutoSize = true;
            signOutLabel.Location = new Point(3, 0);
            signOutLabel.Name = "signOutLabel";
            signOutLabel.Size = new Size(53, 15);
            signOutLabel.TabIndex = 6;
            signOutLabel.Text = "Sign Out";
            signOutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 0);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(73, 15);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "Kullanıcı Adı";
            IdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AksaMachineInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 652);
            Controls.Add(signOut);
            Controls.Add(newEmployee);
            Controls.Add(turnHome);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Name = "AksaMachineInfo";
            Text = "AksaMachineInfo";
            turnHome.ResumeLayout(false);
            turnHome.PerformLayout();
            newEmployee.ResumeLayout(false);
            newEmployee.PerformLayout();
            signOut.ResumeLayout(false);
            signOut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private FlowLayoutPanel turnHome;
        private FlowLayoutPanel newEmployee;
        private FlowLayoutPanel signOut;
        private Label turnHomeLabel;
        private Label homeLabel;
        private Label signOutLabel;
        private Label empLabel;
        private Label IdLabel;
    }
}