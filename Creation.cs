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
    public partial class Creation : Form
    {
        bool changingWindow = false;
        public Creation()
        {
            InitializeComponent();
        }

        private void CreatorReturnButton_Click(object sender, EventArgs e)
        {
            changingWindow = true;
            this.Close();
        }

        private void Creation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changingWindow == false) { Environment.Exit(0); }
        }

        private void HelpMainButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the game creator.\n" +
                "Choose the scene of your game. Once you have chosen the scene, you will need to give your game a name, the game's objective, choose character types that the user can " +
                "choose, and provide starter items.");
        }
    }
}
