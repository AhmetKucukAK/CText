using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTextCurrent.Properties;

namespace CTextCurrent
{
    public partial class MainMenu : Form
    {
        bool changingWindow = false;
        public MainMenu()
        {
            InitializeComponent();
            WelcomeUserLabel.Text = "Welcome " + Properties.Settings.Default["Username"].ToString() + "!";
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            changingWindow = true;
            this.Close();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }
        //Event for when username is appended on welcome label.
        private void WelcomeUserLabel_TextChanged(object sender, EventArgs e)
        {
            //Possible functionality is for when label moves dependent on how long the username is.
        }

        private void SettingsButtonMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Show();
            settings = null;
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Creation creator = new Creation();
            creator.ShowDialog();
            this.Show();
            creator = null;
        }

        private void HelpMainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to CText! This is a usability heuristic focused text adventure game generator.\n " +
                "You are free to create your own text adventure games, or try user created text adventure games using the two buttons on this screen.\n " +
                "The settings can be reached by pressing the cog icon, within them you will find different usability options.");
        }

        private void PlayGameButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Playing playScreen = new Playing();
            playScreen.ShowDialog();
            this.Show();
            playScreen = null;
        }
    }
}
