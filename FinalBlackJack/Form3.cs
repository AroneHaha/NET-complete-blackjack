using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FinalBlackJack
{
    public partial class mainGameForm : Form
    {
        private List<(string Name, PictureBox PictureBox)> cities;
        private Dictionary<string, Image> cityBackgrounds;
        private loadingAnimation loadingAnimation = new loadingAnimation();
        private int centerIndex = 0;
        

        public mainGameForm()
        {
            InitializeComponent();
            cityPanel.Hide();


        }
        private void mainGameForm_Load(object sender, EventArgs e)
        {
            cities = new List<(string, PictureBox)>
            {
                ("Sahara Grand Pavilion Resort", manilaPicBox),
                ("Obi Wan Castle In Shangrila", singaporePicBox),
                ("Cobact Club of Doom", hongkongPicBox)
            };
            
            cityBackgrounds = new Dictionary<string, Image>
{
        { "Sahara Grand Pavilion Resort", Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\city1.jpg") },
        { "Obi Wan Castle In Shangrila", Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\city3.jpg") },
        { "Cobact Club of Doom", Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\city2.jpg") }
};
            UpdateCarouselDisplay();
        }

        private void UpdateCarouselDisplay()
        {
            int formWidth = 1000;
            int formHeight = 650;

            int centerWidth = 500;
            int centerHeight = 325;

            int sideWidth = 320;
            int sideHeight = 208;

            int centerX = (formWidth - centerWidth) / 2;
            int centerY = (formHeight - centerHeight) / 2;

            int spacing = 25;

            for (int i = 0; i < cities.Count; i++)
            {
                var (name, picBox) = cities[i];

                if (i == centerIndex)
                {
                    picBox.Size = new Size(centerWidth, centerHeight);
                    picBox.Location = new Point(centerX, centerY);
                    picBox.BringToFront();
                    picBox.BorderStyle = BorderStyle.Fixed3D;
                }
                else if ((i + 1) % cities.Count == centerIndex)
                {

                    picBox.Size = new Size(sideWidth, sideHeight);
                    picBox.Location = new Point(centerX - sideWidth - spacing, (formHeight - sideHeight) / 2);
                    picBox.SendToBack();
                    picBox.BorderStyle = BorderStyle.None;
                }
                else
                {

                    picBox.Size = new Size(sideWidth, sideHeight);
                    picBox.Location = new Point(centerX + centerWidth + spacing, (formHeight - sideHeight) / 2);
                    picBox.SendToBack();
                    picBox.BorderStyle = BorderStyle.None;
                }

            }
            if (cityBackgrounds.TryGetValue(cities[centerIndex].Name, out Image bgImage))
            {
                cityChooserPanel.BackgroundImage = bgImage;
                cityChooserPanel.BackgroundImageLayout = ImageLayout.Stretch;
            }

            topTextCity.Text = cities[centerIndex].Name;

        }



        private void LoadView(UserControl control)
        {
            cityPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            cityPanel.Controls.Add(control);
            

        }
        public void ReturnToCarousel()
        {
            cityPanel.Hide();
            UpdateCarouselDisplay();

        }



        private void cityChooserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            centerIndex = (centerIndex + 1) % cities.Count;
            UpdateCarouselDisplay();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            centerIndex = (centerIndex - 1 + cities.Count) % cities.Count;
            UpdateCarouselDisplay();
        }
        private async Task ShowLoadingAnimation()
        {
            loadingAnimation.Dock = DockStyle.Fill;
            this.Controls.Add(loadingAnimation);
            loadingAnimation.BringToFront();
            loadingAnimation.Visible = true;

            await Task.Delay(4000);

            loadingAnimation.Visible = false;
            this.Controls.Remove(loadingAnimation);
        }
        private async void manilaPicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Sahara Grand Pavilion Resort")
            {
                await ShowLoadingAnimation();
                cityPanel.Show();
                cityPanel.BringToFront();
                LoadView(new firstCity());
                

            }
        }

        private async void singaporePicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Obi Wan Castle In Shangrila")
            {
                await ShowLoadingAnimation();
                cityPanel.Show();
                cityPanel.BringToFront();
                LoadView(new singaporePanel());
            }
        }

        private async void hongkongPicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Cobact Club of Doom")
            {
                await ShowLoadingAnimation();
                cityPanel.Show();
                cityPanel.BringToFront();
                LoadView(new hongkongPanel());
            }
        }

        private void cityPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void extMaingameButton_Click(object sender, EventArgs e)
        {
            mainMenuForm mainGameForm = new mainMenuForm();
            mainGameForm.showMainMenuPanel();
            
            mainGameForm.Show();
            this.Close();
        }
    }
}
