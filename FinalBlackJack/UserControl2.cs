using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalBlackJack
{
    public partial class secondMainMenu : UserControl
    {

        public secondMainMenu()
        {
            InitializeComponent();
   
        }

        private void secondMainMenu_Load(object sender, EventArgs e)
        {
            settingsUsername.Text = "Username : " + AccountData.usernames[AccountData.currentAccount];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (musicOff.Checked)
            {
                
            }
            else if (musicOn.Checked)
            {
                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void settingsUsername_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
