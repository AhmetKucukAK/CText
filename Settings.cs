using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTextCurrent.Properties;

namespace CTextCurrent
{
    public partial class Settings : Form
    {
        //Variable used for shutting down the system.
        bool changingWindow = false;
        //Default Font Setting sizes.
        static int DefaultFontTitle = 26;
        static int DefaultFontLabeling = 22;
        static int DefaultFontUserInput = 16;
        static int DefaultFontButton = 16;
        //Large Font Setting sizes.
        int LargeFontTitle = DefaultFontTitle + 22;
        int LargeFontLabeling = DefaultFontLabeling + 6;
        int LargeFontUserInput = DefaultFontUserInput + 6;
        int LargeFontButton = DefaultFontButton + 6;

        public Settings()
        {
            InitializeComponent();
        }
        //Returning to previous screen from settings button.
        private void SettingsReturnButton_Click(object sender, EventArgs e)
        {
            changingWindow = true;
            this.Close();
        }

        //Logic to close program if it's not switching to another window.
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }
        private void Apply_User_Settings()
        {
            //Applies user font settings.
            Apply_Font(Properties.Settings.Default["Font"].ToString(), Properties.Settings.Default["TextSize"].ToString());
            Apply_Colour(Properties.Settings.Default["TextColour"].ToString(), Properties.Settings.Default["BackgroundColour"].ToString());
            Apply_Case(Properties.Settings.Default["LetterCase"].ToString());
        }
        private void Apply_Font(string font, string size)
        {
            switch(size.ToLower())
            {
                //When the text size is set to "Large" applies bigger fonts to all of the form controls.
                case "large":
                    //Update title.
                    TitleSettings.Font = new Font(font, LargeFontTitle);
                    //Update labels.
                    LanguageLabel.Font = new Font(font, LargeFontLabeling);
                    TextSizeLabel.Font = new Font(font, LargeFontLabeling);
                    TextColourLabel.Font = new Font(font, LargeFontLabeling);
                    FontLabel.Font = new Font(font, LargeFontLabeling);
                    BackgroundColourLabel.Font = new Font(font, LargeFontLabeling);
                    LetterCaseLabel.Font = new Font(font, LargeFontLabeling);
                    //Update drop down lists.
                    LanguageDropDown.Font = new Font(font, LargeFontUserInput);
                    TextSizeDropDown.Font = new Font(font, LargeFontUserInput);
                    TextColourDropDown.Font = new Font(font, LargeFontUserInput);
                    FontDropDown.Font = new Font(font, LargeFontUserInput);
                    BackgroundColourDropDown.Font = new Font(font, LargeFontUserInput);
                    LetterCaseDropDown.Font = new Font(font, LargeFontUserInput);
                    //Update buttons.
                    SaveSettingsButton.Font = new Font(font, LargeFontButton);
                    SettingsReturnButton.Font = new Font(font, LargeFontButton);
                    ResetDefaultButton.Font = new Font(font, LargeFontButton);
                    break;
                //If default size, apply only the font setting.
                default:
                    //Update title.
                    TitleSettings.Font = new Font(font, DefaultFontTitle);
                    //Update labels.
                    LanguageLabel.Font = new Font(font, DefaultFontLabeling);
                    TextSizeLabel.Font = new Font(font, DefaultFontLabeling);
                    TextColourLabel.Font = new Font(font, DefaultFontLabeling);
                    FontLabel.Font = new Font(font, DefaultFontLabeling);
                    BackgroundColourLabel.Font = new Font(font, DefaultFontLabeling);
                    LetterCaseLabel.Font =  new Font(font, DefaultFontLabeling);
                    //Update drop down lists.
                    LanguageDropDown.Font = new Font(font, DefaultFontUserInput);
                    TextSizeDropDown.Font = new Font(font, DefaultFontUserInput);
                    TextColourDropDown.Font = new Font(font, DefaultFontUserInput);
                    FontDropDown.Font = new Font(font, DefaultFontUserInput);
                    BackgroundColourDropDown.Font = new Font(font, DefaultFontUserInput);
                    LetterCaseDropDown.Font = new Font(font, DefaultFontUserInput);
                    //Update buttons.
                    SaveSettingsButton.Font = new Font(font, DefaultFontButton);
                    SettingsReturnButton.Font = new Font(font, DefaultFontButton);
                    ResetDefaultButton.Font = new Font(font, DefaultFontButton);
                    break;
            }    
        }
        //Updates colour of controls.
        private void Apply_Colour(string textColour, string backgroundColour)
        {
            //Applies alternative colour to text.
            switch (textColour.ToLower()) 
            {
                case "yellow":
                    //Update title text.
                    TitleSettings.ForeColor = Color.Gold;
                    //Update labels' text.
                    LanguageLabel.ForeColor= Color.Gold;
                    TextSizeLabel.ForeColor = Color.Gold;
                    TextColourLabel.ForeColor = Color.Gold;
                    FontLabel.ForeColor = Color.Gold;
                    BackgroundColourLabel.ForeColor = Color.Gold;
                    LetterCaseLabel.ForeColor = Color.Gold;
                    //Update drop down lists' text.
                    LanguageDropDown.ForeColor = Color.Gold;
                    TextSizeDropDown.ForeColor = Color.Gold;
                    TextColourDropDown.ForeColor = Color.Gold;
                    FontDropDown.ForeColor = Color.Gold;
                    BackgroundColourDropDown.ForeColor = Color.Gold;
                    LetterCaseDropDown.ForeColor = Color.Gold;
                    //Update buttons' text.
                    SaveSettingsButton.ForeColor = Color.Gold;
                    SettingsReturnButton.ForeColor = Color.Gold;
                    ResetDefaultButton.ForeColor = Color.Gold;
                    //Update button colour.
                    SaveSettingsButton.BackColor = Color.DarkGreen;
                    SettingsReturnButton.BackColor = Color.Purple;
                    ResetDefaultButton.BackColor = Color.Black;
                    break;
            }
            //Applies alternative colour to form.
            switch (backgroundColour.ToLower()) 
            {
                case "dark":
                    BackColor = Color.MidnightBlue;
                    break;
            }
        }
        //Changes the case of text.
        private void Apply_Case(string Case)
        {
            switch(Case.ToLower()) 
            {
                //Changes all of the letters into uppercase.
                case "uppercase":
                    TitleSettings.Text = TitleSettings.Text.ToUpper();

                    LanguageLabel.Text = LanguageLabel.Text.ToUpper();
                    TextSizeLabel.Text = TextSizeLabel.Text.ToUpper();
                    TextColourLabel.Text = TextColourLabel.Text.ToUpper();
                    FontLabel.Text = FontLabel.Text.ToUpper();
                    BackgroundColourLabel.Text = BackgroundColourLabel.Text.ToUpper();
                    LetterCaseLabel.Text = LetterCaseLabel.Text.ToUpper();

                    SaveSettingsButton.Text = SaveSettingsButton.Text.ToUpper();
                    SettingsReturnButton.Text = SettingsReturnButton.Text.ToUpper();
                    ResetDefaultButton.Text = ResetDefaultButton.Text.ToUpper();
                    break;
            }
        }
        //Updates dropdown fields to show currently selected user settings.
        private void Settings_Load(object sender, EventArgs e)
        {
            
            //Applies user settings on screen.
            Apply_User_Settings();
            //Updates the values of drop down fields.
            LanguageDropDown.Text = Properties.Settings.Default["Language"].ToString();
            TextSizeDropDown.Text = Properties.Settings.Default["TextSize"].ToString();
            TextColourDropDown.Text = Properties.Settings.Default["TextColour"].ToString();
            FontDropDown.Text = Properties.Settings.Default["Font"].ToString();
            BackgroundColourDropDown.Text = Properties.Settings.Default["BackgroundColour"].ToString();
            LetterCaseDropDown.Text = Properties.Settings.Default["LetterCase"].ToString();
        }
        //Settings save button.
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["Language"] = LanguageDropDown.Text;
            Properties.Settings.Default["TextSize"] = TextSizeDropDown.Text;
            Properties.Settings.Default["TextColour"] = TextColourDropDown.Text;
            Properties.Settings.Default["Font"] = FontDropDown.Text;
            Properties.Settings.Default["BackgroundColour"] = BackgroundColourDropDown.Text;
            Properties.Settings.Default["LetterCase"] = LetterCaseDropDown.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings successfully saved.");
            changingWindow = true;
            Close();
        }

        private void ResetDefaultButton_Click(object sender, EventArgs e)
        {
            LanguageDropDown.Text = "English";
            TextSizeDropDown.Text = "Default";
            TextColourDropDown.Text = "Black";
            FontDropDown.Text = "Microsoft Sans Serif";
            BackgroundColourDropDown.Text = "Light";
            LetterCaseDropDown.Text = "Default";
            SaveSettingsButton_Click(sender, e);
        }
        //Example label reacts to text size changes.
        private void TextSizeDropDown_TextChanged(object sender, EventArgs e)
        {
            switch (TextSizeDropDown.Text.ToLower()) 
            {
                case "large":
                    ExampleLabel.Font = new Font(ExampleLabel.Font.Name, LargeFontLabeling);
                    break;
                default:
                    ExampleLabel.Font = new Font(ExampleLabel.Font.Name, DefaultFontLabeling);
                    break;
            }
        }
        //Example label reacts to text colour changes.
        private void TextColourDropDown_TextChanged(object sender, EventArgs e)
        {
            switch(TextColourDropDown.Text.ToLower()) 
            {
                case "yellow":
                    ExampleLabel.ForeColor = Color.Gold;
                    break;
                default:
                    ExampleLabel.ForeColor = Color.Black;
                    break;
            }
        }

        private void FontDropDown_TextChanged(object sender, EventArgs e)
        {
            switch(FontDropDown.Text.ToLower()) 
            {
                case "times new roman":
                    ExampleLabel.Font = new Font("Times New Roman", ExampleLabel.Font.Size);
                    break;

                default:
                    ExampleLabel.Font = new Font("Microsoft Sans Serif", ExampleLabel.Font.Size);
                    break;
            }
        }

        private void BackgroundColourDropDown_TextChanged(object sender, EventArgs e)
        {
            switch(BackgroundColourDropDown.Text.ToLower()) 
            {
                case "dark":
                    ExampleLabel.BackColor = Color.MidnightBlue;
                    break;
                default:
                    ExampleLabel.BackColor = Color.WhiteSmoke;
                    break;
            }
        }

        private void LetterCaseDropDown_TextChanged(object sender, EventArgs e)
        {
            switch(LetterCaseDropDown.Text.ToLower())
            {
                case "uppercase":
                    ExampleLabel.Text = ExampleLabel.Text.ToUpper();
                    break;
                default:
                    ExampleLabel.Text = "Example Text";
                    break;
            }
        }
    }


}
