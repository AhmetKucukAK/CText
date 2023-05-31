using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTextCurrent.Properties;

namespace CTextCurrent
{
    public partial class Register : Form
    {
        Config db = new Config();
        bool changingWindow = false;
        public Register()
        {
            InitializeComponent();
            //Connecting to the provided database
            db.Connect("userdata");
        }

        private bool validateUsername()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(UsernameRegisterTextBox.Text))
            {
                RegisterErrorProvider.SetError(UsernameRegisterTextBox, "Input your username.");
                MessageBox.Show("The username field is empty.");
                isValid = false;
            }

            //Querry MySQL database for the data passed from textbox.
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + UsernameRegisterTextBox.Text + "';");

            //If username is used, the program informs user that the username is taken, otherwise it adds a new account onto the database.
            if (db.Count() == 1)
            {
                RegisterErrorProvider.SetError(UsernameRegisterTextBox, "Try a different username.");
                MessageBox.Show("This username is taken.");
                isValid = false;
            }
            return isValid;
        }

        private bool validatePassword()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(PasswordRegisterTextBox.Text))
            {
                RegisterErrorProvider.SetError(PasswordRegisterTextBox, "Input your password.");
                MessageBox.Show("The password field is empty.");
                isValid = false;
            }

            if (PasswordRegisterTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                RegisterErrorProvider.SetError(ConfirmPasswordTextBox, "Repeat your password.");
                MessageBox.Show("Your passwords do not match.");
                isValid = false;
            }
            return isValid;
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            RegisterErrorProvider.Clear();
            if (validateUsername() == true && validatePassword() == true)
            {
                try
                {
                    db.Execute("INSERT INTO user_info(username,password) VALUES ('" + UsernameRegisterTextBox.Text + "','" + PasswordRegisterTextBox.Text + "');");
                    db = null;
                    changingWindow= true;
                    LoginButton_Click(sender, e);
                }
                catch
                (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Button used to switch to the settings window.
        private void SettingsButtonRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Show();
            settings = null;
        }
        //Button used to switch to the login window.
        private void LoginButton_Click(object sender, EventArgs e)
        {
            db = null;
            Login login = new Login();
            login.Show();
            changingWindow = true;
            this.Close();

        }
        //Logic to close program if it's not switching to another window.
        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }
    }
}
