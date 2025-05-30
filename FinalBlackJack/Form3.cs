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
        private homesounds clickSound;
        private List<(string Name, PictureBox PictureBox)> cities;
        private Dictionary<string, Image> cityBackgrounds;
        private loadingAnimation loadingAnimation = new loadingAnimation();
        private int centerIndex = 0;
        private mainMenuForm menuForm;
        private string selectedCity = "";
        public string tableChoice = "";

        private int greenMin = 1000;
        private int greenMax = 15000;

        private int blueMin = 30000;
        private int blueMax = 250000;

        private int redMin = 500000;
        private int redMax = 100000000;

        public mainGameForm(mainMenuForm menu)
        {
            InitializeComponent();
            buyinTotalBalance.Text = AccountData.accountsBalance[AccountData.currentAccount].ToString();
            cityPanel.Hide();
            menuForm = menu;
            transactionPanel.Hide();
        }
        private void clicking()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\clicks.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }
        private void homenav()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\homenav.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }
        private void door()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\door.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void error()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\no-bet.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void arrows()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\choosemap.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
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

            // Hide all city labels first
            topTextCity.Visible = false;
            TopTextCity2.Visible = false;
            TopTextCity3.Visible = false;

            // Show the correct city label
            switch (cities[centerIndex].Name)
            {
                case "Sahara Grand Pavilion Resort":
                    topTextCity.Visible = true;
                    break;
                case "Obi Wan Castle In Shangrila":
                    TopTextCity2.Visible = true;
                    break;
                case "Cobact Club of Doom":
                    TopTextCity3.Visible = true;
                    break;
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

        private void cityChooserPanel_Paint(object sender, PaintEventArgs e) { }

        private void rightButton_Click(object sender, EventArgs e)
        {
            centerIndex = (centerIndex + 1) % cities.Count;
            UpdateCarouselDisplay();
            transactionPanel.Hide();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            centerIndex = (centerIndex - 1 + cities.Count) % cities.Count;
            UpdateCarouselDisplay();
            transactionPanel.Hide();
        }

        private async Task ShowLoadingAnimation()
        {
            loadingAnimation.Dock = DockStyle.Fill;
            this.Controls.Add(loadingAnimation);
            loadingAnimation.BringToFront();
            loadingAnimation.Visible = true;

            await Task.Delay(2000);

            loadingAnimation.Visible = false;
            this.Controls.Remove(loadingAnimation);
        }

        private void showTransactionPanel()
        {
            transactionPanel.Visible = true;
            transactionPanel.BringToFront();
        }

        private async void manilaPicBox_Click(object sender, EventArgs e)
        {
            homenav();
            tableChoice = "green";
            buyinTotalBalance.Text = AccountData.accountsBalance[AccountData.currentAccount].ToString();
            if (cities[centerIndex].Name == "Sahara Grand Pavilion Resort")
            {
                selectedCity = "Sahara Grand Pavilion Resort";
                showTransactionPanel();
            }
        }

        private async void singaporePicBox_Click(object sender, EventArgs e)
        {
            homenav();
            tableChoice = "blue";
            buyinTotalBalance.Text = AccountData.accountsBalance[AccountData.currentAccount].ToString();
            if (cities[centerIndex].Name == "Obi Wan Castle In Shangrila")
            {
                selectedCity = "Obi Wan Castle In Shangrila";
                showTransactionPanel();
            }
        }

        private async void hongkongPicBox_Click(object sender, EventArgs e)
        {
            homenav();
            tableChoice = "red";
            buyinTotalBalance.Text = AccountData.accountsBalance[AccountData.currentAccount].ToString();
            if (cities[centerIndex].Name == "Cobact Club of Doom")
            {
                selectedCity = "Cobact Club of Doom";
                showTransactionPanel();
            }
        }

        private void cityPanel_Paint(object sender, PaintEventArgs e) { }

        private void extMaingameButton_Click(object sender, EventArgs e)
        {
            homenav();
            menuForm.UpdateStatsAfterGame();
            menuForm.showMainMenuPanel();
            menuForm.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            transactionPanel.Hide();
        }

        private async void confirmButton_Click(object sender, EventArgs e) { }

        private bool buyinExceptions(int min, int max)
        {
            if (string.IsNullOrWhiteSpace(buyinAmount.Text))
            {
                error();
                MessageBox.Show("Please enter a buy-in amount.");
                return false;
            }
            if (!int.TryParse(buyinAmount.Text, out int buyin) || buyin <= 0)
            {
                error();
                MessageBox.Show("Please enter a valid positive integer for the buy-in amount.");
                return false;
            }
            if (buyin > AccountData.accountsBalance[AccountData.currentAccount])
            {
                error();
                MessageBox.Show("Insufficient balance for the buy-in amount.");
                return false;
            }
            if (buyin < min || buyin > max)
            {
                error();
                MessageBox.Show($"Buy-in amount must be between {min} and {max}.");
                return false;
            }
            return true;
        }

        private void buyinHold()
        {
            if (int.TryParse(buyinAmount.Text, out int buyin))
            {
                buyinHolder.buyIn[0] = buyin;
            }
        }

        private async void depositButton_Click(object sender, EventArgs e)
        {
            switch (selectedCity)
            {
                case "Sahara Grand Pavilion Resort":
                    if (!buyinExceptions(greenMin, greenMax)) return;
                    door();
                    buyinHold();
                    await ShowLoadingAnimation();
                    cityPanel.Show();
                    cityPanel.BringToFront();
                    LoadView(new firstCity());
                    break;

                case "Obi Wan Castle In Shangrila":
                    if (!buyinExceptions(blueMin, blueMax)) return;
                    door();
                    buyinHold();
                    await ShowLoadingAnimation();
                    cityPanel.Show();
                    cityPanel.BringToFront();
                    LoadView(new singaporePanel());
                    break;

                case "Cobact Club of Doom":
                    if (!buyinExceptions(redMin, redMax)) return;
                    door();
                    buyinHold();
                    await ShowLoadingAnimation();
                    cityPanel.Show();
                    cityPanel.BringToFront();
                    LoadView(new hongkongPanel());
                    break;

                default:
                    MessageBox.Show("No city selected.", "Error");
                    return;
            }

            transactionPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clicking();
            tableChoice = "";
            buyinAmount.Clear();
            transactionPanel.Hide();
        }

        private void buyinAmount_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            arrows();
            buyinAmount.Clear();
            centerIndex = (centerIndex - 1 + cities.Count) % cities.Count;
            UpdateCarouselDisplay();
            transactionPanel.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            arrows();
            buyinAmount.Clear();
            centerIndex = (centerIndex + 1) % cities.Count;
            UpdateCarouselDisplay();
            transactionPanel.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            left.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\lefth.png");
        }

        private void left_MouseLeave(object sender, EventArgs e)
        {
            left.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\left.png");
        }

        private void right_MouseEnter(object sender, EventArgs e)
        {
            right.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\righth.png");
        }

        private void right_MouseLeave(object sender, EventArgs e)
        {
            right.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\right.png");
        }

        private void topTextCity_Click(object sender, EventArgs e) { }

        private void TopTextCity3_Click(object sender, EventArgs e)
        {

        }

        private void TopTextCity2_Click(object sender, EventArgs e)
        {

        }
    }
}
