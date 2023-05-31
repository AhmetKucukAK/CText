namespace CTextCurrent
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.TitleRegister = new System.Windows.Forms.Label();
            this.PasswordRegisterTextBox = new System.Windows.Forms.TextBox();
            this.UsernameRegisterTextBox = new System.Windows.Forms.TextBox();
            this.SettingsButtonRegister = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SettingsRegisterLabel = new System.Windows.Forms.Label();
            this.RegisteredLabel = new System.Windows.Forms.Label();
            this.PasswordRegister = new System.Windows.Forms.Label();
            this.UsernameRegisterLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.RegisterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleRegister
            // 
            this.TitleRegister.AutoSize = true;
            this.TitleRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRegister.Location = new System.Drawing.Point(306, 21);
            this.TitleRegister.Name = "TitleRegister";
            this.TitleRegister.Size = new System.Drawing.Size(203, 55);
            this.TitleRegister.TabIndex = 0;
            this.TitleRegister.Text = "Register";
            // 
            // PasswordRegisterTextBox
            // 
            this.PasswordRegisterTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PasswordRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegisterTextBox.Location = new System.Drawing.Point(290, 163);
            this.PasswordRegisterTextBox.Name = "PasswordRegisterTextBox";
            this.PasswordRegisterTextBox.PasswordChar = '*';
            this.PasswordRegisterTextBox.Size = new System.Drawing.Size(278, 31);
            this.PasswordRegisterTextBox.TabIndex = 21;
            // 
            // UsernameRegisterTextBox
            // 
            this.UsernameRegisterTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UsernameRegisterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameRegisterTextBox.Location = new System.Drawing.Point(290, 99);
            this.UsernameRegisterTextBox.Name = "UsernameRegisterTextBox";
            this.UsernameRegisterTextBox.Size = new System.Drawing.Size(278, 31);
            this.UsernameRegisterTextBox.TabIndex = 20;
            // 
            // SettingsButtonRegister
            // 
            this.SettingsButtonRegister.AccessibleDescription = "Button to go to the settings page.";
            this.SettingsButtonRegister.AccessibleName = "Settings Button";
            this.SettingsButtonRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SettingsButtonRegister.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsButtonRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButtonRegister.BackgroundImage")));
            this.SettingsButtonRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButtonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButtonRegister.Location = new System.Drawing.Point(615, 292);
            this.SettingsButtonRegister.Name = "SettingsButtonRegister";
            this.SettingsButtonRegister.Size = new System.Drawing.Size(139, 124);
            this.SettingsButtonRegister.TabIndex = 19;
            this.SettingsButtonRegister.UseVisualStyleBackColor = false;
            this.SettingsButtonRegister.Click += new System.EventHandler(this.SettingsButtonRegister_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(44, 359);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(146, 57);
            this.LoginButton.TabIndex = 18;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SettingsRegisterLabel
            // 
            this.SettingsRegisterLabel.AutoSize = true;
            this.SettingsRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRegisterLabel.Location = new System.Drawing.Point(635, 260);
            this.SettingsRegisterLabel.Name = "SettingsRegisterLabel";
            this.SettingsRegisterLabel.Size = new System.Drawing.Size(100, 29);
            this.SettingsRegisterLabel.TabIndex = 17;
            this.SettingsRegisterLabel.Text = "Settings";
            // 
            // RegisteredLabel
            // 
            this.RegisteredLabel.AutoSize = true;
            this.RegisteredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisteredLabel.Location = new System.Drawing.Point(50, 298);
            this.RegisteredLabel.Name = "RegisteredLabel";
            this.RegisteredLabel.Size = new System.Drawing.Size(157, 58);
            this.RegisteredLabel.TabIndex = 16;
            this.RegisteredLabel.Text = "Already have \r\nan account?";
            // 
            // PasswordRegister
            // 
            this.PasswordRegister.AutoSize = true;
            this.PasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordRegister.Location = new System.Drawing.Point(131, 163);
            this.PasswordRegister.Name = "PasswordRegister";
            this.PasswordRegister.Size = new System.Drawing.Size(143, 33);
            this.PasswordRegister.TabIndex = 15;
            this.PasswordRegister.Text = "Password";
            // 
            // UsernameRegisterLabel
            // 
            this.UsernameRegisterLabel.AutoSize = true;
            this.UsernameRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameRegisterLabel.Location = new System.Drawing.Point(124, 94);
            this.UsernameRegisterLabel.Name = "UsernameRegisterLabel";
            this.UsernameRegisterLabel.Size = new System.Drawing.Size(150, 33);
            this.UsernameRegisterLabel.TabIndex = 14;
            this.UsernameRegisterLabel.Text = "Username";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(290, 220);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(278, 31);
            this.ConfirmPasswordTextBox.TabIndex = 23;
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(20, 220);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(254, 33);
            this.ConfirmPasswordLabel.TabIndex = 22;
            this.ConfirmPasswordLabel.Text = "Confirm Password";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.Location = new System.Drawing.Point(307, 270);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(240, 69);
            this.CreateAccountButton.TabIndex = 24;
            this.CreateAccountButton.Text = "CREATE ACCOUNT";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // RegisterErrorProvider
            // 
            this.RegisterErrorProvider.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.ConfirmPasswordLabel);
            this.Controls.Add(this.PasswordRegisterTextBox);
            this.Controls.Add(this.UsernameRegisterTextBox);
            this.Controls.Add(this.SettingsButtonRegister);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SettingsRegisterLabel);
            this.Controls.Add(this.RegisteredLabel);
            this.Controls.Add(this.PasswordRegister);
            this.Controls.Add(this.UsernameRegisterLabel);
            this.Controls.Add(this.TitleRegister);
            this.Name = "Register";
            this.Text = "CText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleRegister;
        private System.Windows.Forms.TextBox PasswordRegisterTextBox;
        private System.Windows.Forms.TextBox UsernameRegisterTextBox;
        private System.Windows.Forms.Button SettingsButtonRegister;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label SettingsRegisterLabel;
        private System.Windows.Forms.Label RegisteredLabel;
        private System.Windows.Forms.Label PasswordRegister;
        private System.Windows.Forms.Label UsernameRegisterLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.ErrorProvider RegisterErrorProvider;
    }
}