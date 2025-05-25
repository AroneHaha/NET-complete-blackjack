using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



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
            mainMenuForm parentForm = this.FindForm() as mainMenuForm;
            if (parentForm != null)
            {
                AccountData.currentAccount = 0;
                parentForm.signOutPanel();
            }


        }
        
        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is mainMenuForm mainForm)
            {
                mainForm.LoadView(new logPassword());
            }

            this.Visible = false;

        }
    }
}
