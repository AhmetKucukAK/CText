namespace CTextCurrent
{
    partial class Playing
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
            this.PlayingReturnButton = new System.Windows.Forms.Button();
            this.GamesListBox = new System.Windows.Forms.ListBox();
            this.HelpPlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayingReturnButton
            // 
            this.PlayingReturnButton.BackColor = System.Drawing.Color.LightCoral;
            this.PlayingReturnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayingReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingReturnButton.Location = new System.Drawing.Point(642, 12);
            this.PlayingReturnButton.Name = "PlayingReturnButton";
            this.PlayingReturnButton.Size = new System.Drawing.Size(146, 57);
            this.PlayingReturnButton.TabIndex = 20;
            this.PlayingReturnButton.Text = "Back";
            this.PlayingReturnButton.UseVisualStyleBackColor = false;
            this.PlayingReturnButton.Click += new System.EventHandler(this.PlayingReturnButton_Click);
            // 
            // GamesListBox
            // 
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.Items.AddRange(new object[] {
            "Fighter of the Firejast Forest"});
            this.GamesListBox.Location = new System.Drawing.Point(87, 44);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(330, 316);
            this.GamesListBox.TabIndex = 26;
            // 
            // HelpPlayButton
            // 
            this.HelpPlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPlayButton.Location = new System.Drawing.Point(650, 350);
            this.HelpPlayButton.Name = "HelpPlayButton";
            this.HelpPlayButton.Size = new System.Drawing.Size(138, 57);
            this.HelpPlayButton.TabIndex = 27;
            this.HelpPlayButton.Text = "HELP";
            this.HelpPlayButton.UseVisualStyleBackColor = true;
            this.HelpPlayButton.Click += new System.EventHandler(this.HelpPlayButton_Click);
            // 
            // Playing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelpPlayButton);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.PlayingReturnButton);
            this.Name = "Playing";
            this.Text = "CText";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playing_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayingReturnButton;
        private System.Windows.Forms.ListBox GamesListBox;
        private System.Windows.Forms.Button HelpPlayButton;
    }
}