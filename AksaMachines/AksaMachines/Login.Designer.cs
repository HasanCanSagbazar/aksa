namespace AksaMachines
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTitle = new Label();
            KullanıcıAdı = new TextBox();
            IdLabel = new Label();
            passwordLabel = new Label();
            PasswordBox = new TextBox();
            loginButton = new Button();
            passwordReset = new Label();
            SuspendLayout();
            // 
            // loginTitle
            // 
            loginTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginTitle.AutoSize = true;
            loginTitle.Location = new Point(128, 110);
            loginTitle.Name = "loginTitle";
            loginTitle.Size = new Size(110, 15);
            loginTitle.TabIndex = 0;
            loginTitle.Text = "AKSA AKRİLİK GİRİŞ";
            loginTitle.TextAlign = ContentAlignment.MiddleCenter;
            loginTitle.Click += loginTitle_Click;
            // 
            // KullanıcıAdı
            // 
            KullanıcıAdı.Location = new Point(97, 195);
            KullanıcıAdı.Name = "KullanıcıAdı";
            KullanıcıAdı.Size = new Size(170, 23);
            KullanıcıAdı.TabIndex = 1;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(97, 167);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(73, 15);
            IdLabel.TabIndex = 2;
            IdLabel.Text = "Kullanıcı Adı";
            IdLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(97, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(30, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Şifre";
            passwordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(97, 271);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(170, 23);
            PasswordBox.TabIndex = 3;
            PasswordBox.TextChanged += textBox1_TextChanged;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(169, 335);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(98, 27);
            loginButton.TabIndex = 5;
            loginButton.Text = "Giriş";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // passwordReset
            // 
            passwordReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordReset.AutoSize = true;
            passwordReset.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 162);
            passwordReset.Location = new Point(153, 378);
            passwordReset.Name = "passwordReset";
            passwordReset.Size = new Size(113, 15);
            passwordReset.TabIndex = 6;
            passwordReset.Text = "Parolamı Unuttum...";
            passwordReset.TextAlign = ContentAlignment.MiddleCenter;
            passwordReset.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 504);
            Controls.Add(passwordReset);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(PasswordBox);
            Controls.Add(IdLabel);
            Controls.Add(KullanıcıAdı);
            Controls.Add(loginTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginTitle;
        private TextBox KullanıcıAdı;
        private Label IdLabel;
        private Label passwordLabel;
        private TextBox PasswordBox;
        private Button loginButton;
        private Label passwordReset;
    }
}
