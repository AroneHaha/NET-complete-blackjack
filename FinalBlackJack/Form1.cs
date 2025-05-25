
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;


namespace FinalBlackJack
{


    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            termsTextPanel.AutoScroll = true;
            playNowButton.Enabled = false;

            mainMenuForm mainMenu = new mainMenuForm();
            this.Load += async (s, e) => await ShowLoadingScreen();

        }
        private backgroundmusic backgroundMusic;
        private async Task ShowLoadingScreen()
        {
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;

            loadingBar.Style = ProgressBarStyle.Marquee;
            loadingBar.MarqueeAnimationSpeed = 40;

            loadingText2.Text = "Loading assets...";
            await Task.Delay(2000);

            loadingText2.Text = "Almost there ...";
            await Task.Delay(1000);

            loadingText2.Text = "Get Ready!";
            await Task.Delay(1000);

            loadingPanel.Visible = false;
            if (backgroundMusic == null)
            {
                string musicPath = @"C:\BSIT 1\C#\blackjack\audio\bgmusic.wav";
                backgroundMusic = new backgroundmusic(musicPath);
                backgroundMusic.PlayLoop();
            }

            form1Panel.Visible = true;

        }

        private void playNowButton_Click(object sender, EventArgs e)
        {
            mainMenuForm mainMenu = new mainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loadingBar_Click(object sender, EventArgs e)
        {

        }

        private void loadingText2_Click(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void form1Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            playNowButton.Enabled = true;
            termsPanel.Visible = false; 

        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
