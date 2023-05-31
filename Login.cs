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
    public partial class Login : Form
    {
        Config db = new Config();
        bool changingWindow = false;
        //Default Font Setting sizes.
        static int DefaultFontTitle = 36;
        static int DefaultFontLabeling = 22;
        static int DefaultFontUserInput = 16;
        static int DefaultFontButton = 16;
        //Large Font Setting sizes.
        int LargeFontTitle = DefaultFontTitle + 36;
        int LargeFontLabeling = DefaultFontLabeling + 6;
        int LargeFontUserInput = DefaultFontUserInput + 6;
        int LargeFontButton = DefaultFontButton + 6;
        
            public Login()
        {
            InitializeComponent();
            //This will connect to the stated database.
            db.Connect("userdata");
            
        }

        //Button to submit login attempt.
        private void LogInButton_Click(object sender, EventArgs e)
        {
            //Querry MySQL database for the data passed from textboxes to validate user login.
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + UsernameLoginTextBox.Text + "' AND password ='" + PasswordLoginTextBox.Text + "';");

            if (db.Count() == 1) 
            {
                string loggedInUsername = db.Results(0, "username");
                Properties.Settings.Default["Username"] = loggedInUsername;
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                changingWindow = true;
                this.Close();
            }
            else { MessageBox.Show("Wrong username and password combination."); }

        }

        //Button used to switch to the settings window.
        private void SettingsButtonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings settings = new Settings();
            settings.ShowDialog();
            this.Show();
            settings = null;
        }

        //Button used to switch to the register window.
        private void RegisterButton_Click(object sender, EventArgs e)
        {
  
            Register register = new Register();
            register.Show();
            changingWindow = true;
            this.Close();
        }

        //Logic to close program if it's not switching to another window.
        private void Login_FormClosing(object sender, EventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }
        private void Apply_Font(string font, string size)
        {
            switch (size.ToLower())
            {
                //When the text size is set to "Large" applies bigger fonts to all of the form controls.
                case "large":
                    //Update title.
                    TitleLogin.Font = new Font(font, LargeFontTitle);
                    //Update labels.
                    UsernameLoginLabel.Font = new Font(font, LargeFontLabeling);
                    PasswordLoginLabel.Font = new Font(font, LargeFontLabeling);
                    NoAccountLabel.Font = new Font(font, LargeFontLabeling);
                    SettingsLoginLabel.Font = new Font(font, LargeFontLabeling);
                    //Update input fields.
                    UsernameLoginTextBox.Font = new Font(font, LargeFontUserInput);
                    PasswordLoginTextBox.Font = new Font(font, LargeFontUserInput);
                    //Update buttons.
                    LogInButton.Font = new Font(font, LargeFontButton);
                    RegisterButton.Font = new Font(font, LargeFontButton);
                    break;
                //If default size, apply only the font setting.
                default:
                    //Update title.
                    TitleLogin.Font = new Font(font, DefaultFontTitle);
                    //Update labels.
                    UsernameLoginLabel.Font = new Font(font, DefaultFontLabeling);
                    PasswordLoginLabel.Font = new Font(font, DefaultFontLabeling);
                    NoAccountLabel.Font = new Font(font, DefaultFontLabeling);
                    SettingsLoginLabel.Font = new Font(font, DefaultFontLabeling);
                    //Update input fields.
                    UsernameLoginTextBox.Font = new Font(font, DefaultFontUserInput);
                    PasswordLoginTextBox.Font = new Font(font, DefaultFontUserInput);
                    //Update buttons.
                    LogInButton.Font = new Font(font, DefaultFontButton);
                    RegisterButton.Font = new Font(font, DefaultFontButton);
                    break;
        }
    }
        private void Apply_Colour(string textColour, string backgroundColour) 
        {
            //Applies alternative colour to text.
            switch (textColour.ToLower())
            {
                case "yellow":
                    //Update title text.
                    TitleLogin.ForeColor = Color.Gold;
                    //Update labels' text.
                    UsernameLoginLabel.ForeColor = Color.Gold;
                    PasswordLoginLabel.ForeColor = Color.Gold;
                    NoAccountLabel.ForeColor = Color.Gold;
                    SettingsLoginLabel.ForeColor = Color.Gold;
                    //Update drop down lists' text.
                    UsernameLoginTextBox.ForeColor = Color.Gold;
                    PasswordLoginTextBox.ForeColor = Color.Gold;
                    //Update buttons' text.
                    LogInButton.ForeColor = Color.Gold;
                    RegisterButton.ForeColor = Color.Gold;
                    //Update buttons' colour.
                    LogInButton.BackColor = Color.Black;
                    RegisterButton.BackColor = Color.Black;
                    //Settings
                    break;
                default:
                    //Update title text.
                    TitleLogin.ForeColor = Color.Black;
                    //Update labels' text.
                    UsernameLoginLabel.ForeColor = Color.Black;
                    PasswordLoginLabel.ForeColor = Color.Black;
                    NoAccountLabel.ForeColor = Color.Black;
                    SettingsLoginLabel.ForeColor = Color.Black;
                    //Update drop down lists' text.
                    UsernameLoginTextBox.ForeColor = Color.Black;
                    PasswordLoginTextBox.ForeColor = Color.Black;
                    //Update buttons' text.
                    LogInButton.ForeColor = Color.Black;
                    RegisterButton.ForeColor = Color.Black;
                    //Update buttons' colour.
                    LogInButton.BackColor= Color.LightGray;
                    RegisterButton.BackColor = Color.LightGray;
                    break;
            }
            //Applies alternative colour to form.
            switch (backgroundColour.ToLower())
            {
                case "dark":
                    BackColor = Color.MidnightBlue;
                    break;
                default:
                    BackColor = Color.WhiteSmoke;
                    break;
            }
        }
        private void Apply_Case(string Case)
        {
            switch (Case.ToLower())
            {
                //Changes all of the letters into uppercase.
                case "uppercase":
                    TitleLogin.Text = TitleLogin.Text.ToUpper();

                    UsernameLoginLabel.Text = UsernameLoginLabel.Text.ToUpper();
                    PasswordLoginLabel.Text = PasswordLoginLabel.Text.ToUpper();
                    NoAccountLabel.Text = NoAccountLabel.Text.ToUpper();
                    SettingsLoginLabel.Text = SettingsLoginLabel.Text.ToUpper();

                    LogInButton.Text = LogInButton.Text.ToUpper();
                    RegisterButton.Text = RegisterButton.Text.ToUpper();
                    SettingsButtonLogin.Text = SettingsButtonLogin.Text.ToUpper();
                    break;
                default:
                    TitleLogin.Text = "Login";

                    UsernameLoginLabel.Text = "Username";
                    PasswordLoginLabel.Text = "Password";
                    NoAccountLabel.Text = "Don't have \r\nan account?";

                    RegisterButton.Text = "Register";
                    SettingsLoginLabel.Text = "Settings";
                    break;
            }
        }
        private void Apply_User_Settings()
        {
            //Applies user font settings.
            Apply_Font(Properties.Settings.Default["Font"].ToString(), Properties.Settings.Default["TextSize"].ToString());
            Apply_Colour(Properties.Settings.Default["TextColour"].ToString(), Properties.Settings.Default["BackgroundColour"].ToString());
            Apply_Case(Properties.Settings.Default["LetterCase"].ToString());
        }
        private void Login_Load(object sender, EventArgs e)
        {
                Apply_User_Settings();
        }
    }
}
