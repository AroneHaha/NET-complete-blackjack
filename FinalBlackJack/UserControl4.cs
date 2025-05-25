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
        private List<Image> imahes = new List<Image>();
        private int currentImageIndex = 0;
        private System.Windows.Forms.Timer imageTimer = new System.Windows.Forms.Timer();

        public logPassword()
        {
            InitializeComponent();
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds1.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds2.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imaheAds3.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imahesAds4.jpg"));
            imahes.Add(Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\imahesAds5.jpg"));


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

            mainGameForm gameForm = new mainGameForm();
            gameForm.Show();


            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
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
    }
}
