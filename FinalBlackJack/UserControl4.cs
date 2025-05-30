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
    public partial class logPassword : UserControl
    {
        private homesounds clickSound;
        private List<Image> imahes = new List<Image>();
        private int currentImageIndex = 0;
        private System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();

        public logPassword()
        {
            InitializeComponent();
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheMainAds1.png"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds1.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds2.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds3.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imahesAds4.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imahesAds5.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAdsEaster.png"));


            adsPictureBox.Image = imahes[0];
            adsPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            imageTimer.Interval = 3000;
            imageTimer.Tick += ImageTimer_Tick;
            imageTimer.Start();
        }

        private void ImageTimer_Tick(object sender, EventArgs e)
        {
            currentImageIndex = (currentImageIndex + 1) % imahes.Count;
            adsPictureBox.Image = imahes[currentImageIndex];
        }

        private void form3Button_Click(object sender, EventArgs e)
        {

            mainMenuForm parentMenuForm = this.FindForm() as mainMenuForm;
            clicking();

            if (parentMenuForm != null)
            {
                mainGameForm gameForm = new mainGameForm(parentMenuForm);
                gameForm.Show();
                parentMenuForm.Hide();
            }
            else
            {
                MessageBox.Show("Parent form not found.");
            }

        }

        private void clicking()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\clicks.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void homeUserOption_Load(object sender, EventArgs e)
        {

        }

        private void adsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
