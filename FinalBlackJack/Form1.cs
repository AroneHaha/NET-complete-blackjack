
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
using static FinalBlackJack.Program;


namespace FinalBlackJack
{

    public partial class StartForm : Form
    {
        private homesounds clickSound;
        private void clicking()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\clicks.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        public StartForm()
        {
            InitializeComponent();
            loadingText2.Focus();
            termsTextPanel.AutoScroll = true;
            playNowButton.Enabled = false;

            mainMenuForm mainMenu = new mainMenuForm();
            this.Load += async (s, e) => await ShowLoadingScreen();

            playNowButton.Visible = false;
            exitButton.Visible = false;

        }
        private backgroundmusic backgroundMusic;
        private async Task ShowLoadingScreen()
        {
            loadingPanel.BringToFront();
            loadingPanel.Visible = true;

            loadingBar.Style = ProgressBarStyle.Marquee;
            loadingBar.MarqueeAnimationSpeed = 40;

            loadingText2.Text = "Loading assets";
            await Task.Delay(2000);

            loadingText2.Text = "Almost there...";
            await Task.Delay(1000);

            loadingText2.Text = "Get Ready!";
            await Task.Delay(1000);

            loadingPanel.Visible = false;

            if (backgroundMusic == null)
            {
                string musicPath = @"C:\BSIT 1\C#\blackjack\audio\bgmusic.wav";
                AudioManager.BackgroundMusic = new backgroundmusic(musicPath);
                playNowButton.Focus();
                AudioManager.BackgroundMusic.PlayLoop();

                backgroundMusic = AudioManager.BackgroundMusic;  
            }

            form1Panel.Visible = true;
        }


        private void playNowButton_Click(object sender, EventArgs e)
        {
            clicking();
            mainMenuForm mainMenu = new mainMenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            label2.Focus();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            playNowButton.Enabled = true;
            playNowButton.Visible = true;
            exitButton.Visible = true;
            termsPanel.Visible = false;
        }

        private void declineButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            clicking();
        }

        private void tittleText_Click(object sender, EventArgs e)
        {

        }

        private void loadingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
