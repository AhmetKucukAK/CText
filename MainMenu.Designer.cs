namespace CTextCurrent
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.LogOutButton = new System.Windows.Forms.Button();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.CreateGameButton = new System.Windows.Forms.Button();
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.SettingsRegisterLabel = new System.Windows.Forms.Label();
            this.HelpMainButton = new System.Windows.Forms.Button();
            this.SettingsButtonMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.LightCoral;
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(611, 367);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(146, 57);
            this.LogOutButton.TabIndex = 19;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // WelcomeUserLabel
            // 
            this.WelcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeUserLabel.Location = new System.Drawing.Point(247, 9);
            this.WelcomeUserLabel.Name = "WelcomeUserLabel";
            this.WelcomeUserLabel.Size = new System.Drawing.Size(510, 65);
            this.WelcomeUserLabel.TabIndex = 20;
            this.WelcomeUserLabel.Text = "Welcome!";
            this.WelcomeUserLabel.TextChanged += new System.EventHandler(this.WelcomeUserLabel_TextChanged);
            // 
            // CreateGameButton
            // 
            this.CreateGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGameButton.Location = new System.Drawing.Point(214, 90);
            this.CreateGameButton.Name = "CreateGameButton";
            this.CreateGameButton.Size = new System.Drawing.Size(316, 84);
            this.CreateGameButton.TabIndex = 21;
            this.CreateGameButton.Text = "Create Game";
            this.CreateGameButton.UseVisualStyleBackColor = true;
            this.CreateGameButton.Click += new System.EventHandler(this.CreateGameButton_Click);
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGameButton.Location = new System.Drawing.Point(214, 190);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(316, 84);
            this.PlayGameButton.TabIndex = 22;
            this.PlayGameButton.Text = "Play Games";
            this.PlayGameButton.UseVisualStyleBackColor = true;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // SettingsRegisterLabel
            // 
            this.SettingsRegisterLabel.AutoSize = true;
            this.SettingsRegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsRegisterLabel.Location = new System.Drawing.Point(405, 391);
            this.SettingsRegisterLabel.Name = "SettingsRegisterLabel";
            this.SettingsRegisterLabel.Size = new System.Drawing.Size(120, 33);
            this.SettingsRegisterLabel.TabIndex = 23;
            this.SettingsRegisterLabel.Text = "Settings";
            // 
            // HelpMainButton
            // 
            this.HelpMainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpMainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpMainButton.Location = new System.Drawing.Point(234, 304);
            this.HelpMainButton.Name = "HelpMainButton";
            this.HelpMainButton.Size = new System.Drawing.Size(109, 83);
            this.HelpMainButton.TabIndex = 25;
            this.HelpMainButton.Text = "HELP";
            this.HelpMainButton.UseVisualStyleBackColor = true;
            this.HelpMainButton.Click += new System.EventHandler(this.HelpMainButton_Click);
            // 
            // SettingsButtonMain
            // 
            this.SettingsButtonMain.AccessibleDescription = "Button to go to the settings page.";
            this.SettingsButtonMain.AccessibleName = "Settings Button";
            this.SettingsButtonMain.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SettingsButtonMain.BackColor = System.Drawing.SystemColors.Window;
            this.SettingsButtonMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButtonMain.BackgroundImage")));
            this.SettingsButtonMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButtonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButtonMain.Location = new System.Drawing.Point(411, 304);
            this.SettingsButtonMain.Name = "SettingsButtonMain";
            this.SettingsButtonMain.Size = new System.Drawing.Size(95, 83);
            this.SettingsButtonMain.TabIndex = 26;
            this.SettingsButtonMain.UseVisualStyleBackColor = false;
            this.SettingsButtonMain.Click += new System.EventHandler(this.SettingsButtonMain_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButtonMain);
            this.Controls.Add(this.HelpMainButton);
            this.Controls.Add(this.SettingsRegisterLabel);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.CreateGameButton);
            this.Controls.Add(this.WelcomeUserLabel);
            this.Controls.Add(this.LogOutButton);
            this.Name = "MainMenu";
            this.Text = "CText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label WelcomeUserLabel;
        private System.Windows.Forms.Button CreateGameButton;
        private System.Windows.Forms.Button PlayGameButton;
        private System.Windows.Forms.Label SettingsRegisterLabel;
        private System.Windows.Forms.Button HelpMainButton;
        private System.Windows.Forms.Button SettingsButtonMain;
    }
}