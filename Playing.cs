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
    public partial class Playing : Form
    {
        bool changingWindow = false;
        public Playing()
        {
            InitializeComponent();
        }

        private void PlayingReturnButton_Click(object sender, EventArgs e)
        {
            changingWindow= true;
            this.Close();
        }

        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }

        private void HelpPlayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the play section.\n" +
                "Select a game from the list and load it using the load button.\n" +
                "When the game loads, you are presented with a console to interact with the game." +
                "The biggest part of the screen will display the events and your actions within the game.\n" +
                "The section bellow is for your input. " +
                "Put command words like \"Use Axe\" to play the game.\n" +
                "The action wheel has premade options.\n" +
                "Select a premade command and it will be inserted into your input box, which you can submit, or change.");
        }
    }
}
