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
    public partial class thirdmainMenu : UserControl
    {
        public thirdmainMenu()
        {
            InitializeComponent();
            StartForm startForm = new StartForm();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
