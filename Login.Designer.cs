namespace CTextCurrent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.SettingsLoginLabel = new System.Windows.Forms.Label();
            this.NoAccountLabel = new System.Windows.Forms.Label();
            this.PasswordLoginLabel = new System.Windows.Forms.Label();
            this.UsernameLoginLabel = new System.Windows.Forms.Label();
            this.TitleLogin = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.UsernameLoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLoginTextBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SettingsButtonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsLoginLabel
            // 
            this.SettingsLoginLabel.AutoSize = true;
            this.SettingsLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLoginLabel.Location = new System.Drawing.Point(590, 337);
            this.SettingsLoginLabel.Name = "SettingsLoginLabel";
            this.SettingsLoginLabel.Size = new System.Drawing.Size(120, 33);
            this.SettingsLoginLabel.TabIndex = 9;
            this.SettingsLoginLabel.Text = "Settings";
            // 
            // NoAccountLabel
            // 
            this.NoAccountLabel.AutoSize = true;
            this.NoAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAccountLabel.Location = new System.Drawing.Point(80, 333);
            this.NoAccountLabel.Name = "NoAccountLabel";
            this.NoAccountLabel.Size = new System.Drawing.Size(173, 66);
            this.NoAccountLabel.TabIndex = 8;
            this.NoAccountLabel.Text = "Don\'t have \r\nan account?";
            // 
            // PasswordLoginLabel
            // 
            this.PasswordLoginLabel.AutoSize = true;
            this.PasswordLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginLabel.Location = new System.Drawing.Point(87, 196);
            this.PasswordLoginLabel.Name = "PasswordLoginLabel";
            this.PasswordLoginLabel.Size = new System.Drawing.Size(143, 33);
            this.PasswordLoginLabel.TabIndex = 7;
            this.PasswordLoginLabel.Text = "Password";
            // 
            // UsernameLoginLabel
            // 
            this.UsernameLoginLabel.AutoSize = true;
            this.UsernameLoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLoginLabel.Location = new System.Drawing.Point(80, 128);
            this.UsernameLoginLabel.Name = "UsernameLoginLabel";
            this.UsernameLoginLabel.Size = new System.Drawing.Size(150, 33);
            this.UsernameLoginLabel.TabIndex = 6;
            this.UsernameLoginLabel.Text = "Username";
            // 
            // TitleLogin
            // 
            this.TitleLogin.AutoSize = true;
            this.TitleLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLogin.Location = new System.Drawing.Point(319, 25);
            this.TitleLogin.Name = "TitleLogin";
            this.TitleLogin.Size = new System.Drawing.Size(142, 55);
            this.TitleLogin.TabIndex = 5;
            this.TitleLogin.Text = "Login";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.LightGray;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(68, 431);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(200, 75);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // UsernameLoginTextBox
            // 
            this.UsernameLoginTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UsernameLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLoginTextBox.Location = new System.Drawing.Point(300, 132);
            this.UsernameLoginTextBox.Name = "UsernameLoginTextBox";
            this.UsernameLoginTextBox.Size = new System.Drawing.Size(278, 31);
            this.UsernameLoginTextBox.TabIndex = 12;
            // 
            // PasswordLoginTextBox
            // 
            this.PasswordLoginTextBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PasswordLoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginTextBox.Location = new System.Drawing.Point(300, 196);
            this.PasswordLoginTextBox.Name = "PasswordLoginTextBox";
            this.PasswordLoginTextBox.PasswordChar = '*';
            this.PasswordLoginTextBox.Size = new System.Drawing.Size(278, 31);
            this.PasswordLoginTextBox.TabIndex = 13;
            this.PasswordLoginTextBox.VisibleChanged += new System.EventHandler(this.Login_Load);
            // 
            // LogInButton
            // 
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(315, 242);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(240, 69);
            this.LogInButton.TabIndex = 14;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SettingsButtonLogin
            // 
            this.SettingsButtonLogin.AccessibleDescription = "Button to go to the settings page.";
            this.SettingsButtonLogin.AccessibleName = "Settings Button";
            this.SettingsButtonLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SettingsButtonLogin.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButtonLogin.BackgroundImage")));
            this.SettingsButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButtonLogin.Location = new System.Drawing.Point(571, 382);
            this.SettingsButtonLogin.Name = "SettingsButtonLogin";
            this.SettingsButtonLogin.Size = new System.Drawing.Size(139, 124);
            this.SettingsButtonLogin.TabIndex = 11;
            this.SettingsButtonLogin.UseVisualStyleBackColor = false;
            this.SettingsButtonLogin.Click += new System.EventHandler(this.SettingsButtonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordLoginTextBox);
            this.Controls.Add(this.UsernameLoginTextBox);
            this.Controls.Add(this.SettingsButtonLogin);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SettingsLoginLabel);
            this.Controls.Add(this.NoAccountLabel);
            this.Controls.Add(this.PasswordLoginLabel);
            this.Controls.Add(this.UsernameLoginLabel);
            this.Controls.Add(this.TitleLogin);
            this.Name = "Login";
            this.Text = "CText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SettingsLoginLabel;
        private System.Windows.Forms.Label NoAccountLabel;
        private System.Windows.Forms.Label PasswordLoginLabel;
        private System.Windows.Forms.Label UsernameLoginLabel;
        private System.Windows.Forms.Label TitleLogin;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button SettingsButtonLogin;
        private System.Windows.Forms.TextBox UsernameLoginTextBox;
        private System.Windows.Forms.TextBox PasswordLoginTextBox;
        private System.Windows.Forms.Button LogInButton;
    }
}

