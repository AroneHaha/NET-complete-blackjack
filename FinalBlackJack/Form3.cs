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
    public partial class mainGameForm : Form
    {
        private List<(string Name, PictureBox PictureBox)> cities;
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
        ("Manila", manilaPicBox),
        ("Singapore", singaporePicBox),
        ("Hong Kong", hongkongPicBox)
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

        private void manilaPicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Manila")

                cityPanel.Show();
            cityPanel.BringToFront();

            LoadView(new manilaPanel());
        }

        private void singaporePicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Singapore")

                cityPanel.Show();
            cityPanel.BringToFront();

            LoadView(new singaporePanel());



        }

        private void hongkongPicBox_Click(object sender, EventArgs e)
        {
            if (cities[centerIndex].Name == "Hong Kong")

                cityPanel.Show();
            cityPanel.BringToFront();

            LoadView(new hongkongPanel());



        }

        private void cityPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
