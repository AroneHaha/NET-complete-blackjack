using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FinalBlackJack.Program;

namespace FinalBlackJack
{
    public partial class secondMainMenu : UserControl
    {
        private homesounds clickSound;
        public secondMainMenu()
        {
            InitializeComponent();
            changeInfo.Hide();
        }

        private void secondMainMenu_Load(object sender, EventArgs e)
        {
            settingsUsername.Text = "Username : " + AccountData.usernames[AccountData.currentAccount];
            settingsEmail.Text = "Email : " + AccountData.emails[AccountData.currentAccount];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            clicking();
            if (musicOff.Checked)
            {
                AudioManager.BackgroundMusic?.Pause();
            }
            else if (musicOn.Checked)
            {
                AudioManager.BackgroundMusic?.Resume();
            }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void settingsUsername_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeUsernameButton_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            clicking();
            changeInfo.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clicking();
            changeInfo.Hide();
        }

        private bool isVerifSent = false;
        private void saveBtn_Click(object sender, EventArgs e)
        {
            clicking();
            if (changeOldPass.Text != AccountData.passwords[AccountData.currentAccount])
            {
                MessageBox.Show("Your input doesn't match your current password.");
                return;
            }

            if (changeNewPass.Text != changeConfirmPass.Text)
            {
                MessageBox.Show("Your new password and confirmation password do not match.");
                return;
            }

            if ((changeOldPass.Text == changeNewPass.Text) && (changeOldPass.Text == changeOldPass.Text))
            {
                MessageBox.Show("Looks like you're using your current password \nfor new one, please use another.");
                return;
            }

            if (isVerifSent == false)
            {
                MessageBox.Show("Please request for verification code.");
                return;
            }

            if (changeVerif.Text != verifCode)
            {
                MessageBox.Show("Incorrect verification code. Please try again.");
                return;
            }

            AccountData.passwords[AccountData.currentAccount] = changeNewPass.Text;
            MessageBox.Show("Your password has been successfully changed.");

            changeOldPass.Clear();
            changeNewPass.Clear();
            changeConfirmPass.Clear();
            isVerifSent = false;
            changeInfo.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string verifCode = "";
        private void codeButton_Click(object sender, EventArgs e)
        {
            homenav();
            Random otp = new Random();

            try
            {
                verifCode = otp.Next(100000, 1000000).ToString(); // 6-digit OTP
                string verifLink = "markaronedc@gmail.com"; // NEED PALITAN NG NEW GMAIL
                string pass = "xogd neyn kdez ovts"; // GMAIL KEYPASS FOR VERIF --- markaronedc@gmail.com keypass    
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");

                mm.From = new MailAddress(verifLink);
                mm.To.Add(AccountData.emails[AccountData.currentAccount]);
                mm.Subject = "BlackJack Deluxe: Changing Account Password Verification";
                mm.Body = "Hi " + AccountData.usernames[AccountData.currentAccount] + ",\r\n\r\nWe noticed a request to change your password for your Blackjack Deluxe account.\r\nTo ensure your account’s security, please use the One-Time Password (OTP) below to complete the process:\r\n\r\n🔐 OTP Code: " + verifCode;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(verifLink, pass);
                sc.EnableSsl = true;
                sc.Send(mm);

                isVerifSent = true;
                MessageBox.Show("Code has been sent, please check your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
