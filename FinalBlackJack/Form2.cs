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
using static System.Windows.Forms.DataFormats;

namespace FinalBlackJack
{

    public partial class mainMenuForm : Form
    {

        public mainMenuForm()
        {
            InitializeComponent();


            mainDisplayPanel.Dock = DockStyle.Fill;
            mainDisplayPanel.Show();
            mainDisplayPanel.BringToFront();

            loginPanel.Show();
            signupPanel.Hide();
            mainMenuPanel.Hide();
            navBarPanel.Hide();
            sideMenuPanel.Hide();
            profilePanel.Hide();

            mainDisplayPanel.Controls.Clear();
        }

        private clicksound clickSound;
        private void LoadView(UserControl control)
        {
            mainDisplayPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainDisplayPanel.Controls.Add(control);

        }

        private void registerText_Click(object sender, EventArgs e)
        {

        }

        int playerBalance = 0;
        private void loginButton_Click(object sender, EventArgs e)
        {
            homeUsername.Text = "Account: " + AccountData.usernames[AccountData.currentAccount];
            homeBalance.Text = "Balance: Php " + AccountData.accountsBalance[AccountData.currentAccount].ToString("C2");
            //string user = usernameLog.Text.Trim();
            //string pass = passwordLogin.Text;

            //int idx = AccountData.usernames.IndexOf(user);
            //if (idx == -1)
            //{
            //    MessageBox.Show("Username not found.");
            //    return;
            //}

            //if (AccountData.passwords[idx] == pass && AccountData.usernames[idx] == user)
            //{
            //    AccountData.currentAccount = idx;
            //    playerBalance = Convert.ToInt32(AccountData.accountsBalance[AccountData.currentAccount]);
            //    user = "";
            //    pass = "";

            //    MessageBox.Show("Login successful!");

            loginPanel.Hide();
            mainMenuPanel.Show();
            mainDisplayPanel.Show();
            navBarPanel.Show();
            LoadView(new logPassword());
            //}
            //else
            //{
            //    MessageBox.Show("Invalid password.");
            //    passwordLogin.Clear();
            //}
        }

        private void clicking()
        {
            string musicPath = @"C:\BSIT 1\C#\BLACKJACK ASSETS\audios\Audio\clicks.wav";
            clickSound = new clicksound(musicPath);
            clickSound.PlayOnce();
        }

        private void homenav()
        {
            string musicPath = @"C:\BSIT 1\C#\BLACKJACK ASSETS\audios\Audio\homenav.wav";
            clickSound = new clicksound(musicPath);
            clickSound.PlayOnce();
        }
        private void switchToSignup_Click(object sender, EventArgs e)
        {
            loginPanel.Hide();
            signupPanel.Show();
        }

        private void createaccountButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            signupPanel.Hide();

        }

        private void sidebarButton_Click(object sender, EventArgs e)
        {
            sideMenuPanel.Visible = !sideMenuPanel.Visible;
            sideMenuPanel.BringToFront();
        }


        private void homeButton_Click(object sender, EventArgs e)
        {

            clicking();
            LoadView(new logPassword());
            sideMenuPanel.Hide();
        }
        private void option1_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new thirdmainMenu());
            sideMenuPanel.Hide();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new firstMainMenu());
            sideMenuPanel.Hide();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new secondMainMenu());
            sideMenuPanel.Hide();

        }

        private void userNameLoginTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void usernameRegisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordRegisTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageNumber_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificationTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificationButton_Click(object sender, EventArgs e)
        {

        }





        private void firstmainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        string verifCode = "";
        private void profileButton_Click(object sender, EventArgs e)
        {
            homenav();
            profilePanel.Visible = !profilePanel.Visible;
            profilePanel.BringToFront();
        }

        private void form3Button_Click(object sender, EventArgs e)
        {
            mainGameForm mainGameForm1 = new mainGameForm();
            mainGameForm1.Show();
            this.Close();
        }

        private void verificationButton_Click_1(object sender, EventArgs e)
        {

            Random otp = new Random();

            try
            {
                verifCode = otp.Next(100000, 1000000).ToString(); // 6-digit OTP
                string verifLink = "markaronedc@gmail.com"; // NEED PALITAN NG NEW GMAIL
                string pass = "xogd neyn kdez ovts"; // GMAIL KEYPASS FOR VERIF --- markaronedc@gmail.com keypass    
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");

                mm.From = new MailAddress(verifLink);
                mm.To.Add(emailLog.Text);
                mm.Subject = "BlackJack Deluxe Account Code Verification";
                mm.Body = "Account Verification Code: " + verifCode;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(verifLink, pass);
                sc.EnableSsl = true;
                sc.Send(mm);

                MessageBox.Show("Code has been sent, please check your email.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void verifLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string newUser = usernameLog.Text.Trim();
            string newPass = passwordLog.Text.Trim();
            string newEmail = emailLog.Text.Trim();

            if (string.IsNullOrWhiteSpace(newUser) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(newEmail)) // CHECK FIELDS KUNG MAY LAMAN
            {
                MessageBox.Show("Please make sure to fill in Username, Password, and Email.");
                return;
            }

            if (AccountData.usernames.Contains(newUser)) // CHECK USER IF TAKEN
            {
                MessageBox.Show("That username is already taken.");
                usernameLog.Text = "";
                return;
            }

            if (int.TryParse(ageLog.Text, out int age)) // CHECK AGE IF BELOW 18
            {
                if (age < 18)
                {
                    MessageBox.Show("Below 18 years old is prohibited.");
                    ageLog.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
                ageLog.Text = "";
            }

            if (passwordLog.Text != confPasswordLog.Text) // PASS CONFIRMATOIN
            {
                MessageBox.Show("Password confirmation is incorrect.");
                passwordLog.Text = "";
                confPasswordLog.Text = "";
                return;
            }

            if (AccountData.emails.Contains(newEmail)) // CHECK EMAIL IF ALREADY REGISTERED
            {
                MessageBox.Show("That email is already registered.");
                emailLog.Text = "";
                return;
            }

            if (string.IsNullOrWhiteSpace(verifCode))
            {
                MessageBox.Show("Please request a verification code to process your account.");
                return;
            }

            if (verifLog.Text != verifCode)
            {
                MessageBox.Show("Invalid Verification Code.");
                verifLog.Text = "";
                return;
            }


            // ADD THE INFO OF ACCOUNTS WHEN IT PASS THROUGH THE IFS
            AccountData.usernames.Add(newUser);
            AccountData.passwords.Add(newPass);
            AccountData.emails.Add(newEmail);
            AccountData.accountsBalance.Add(0.00);
            verifCode = "";

            MessageBox.Show("Registration successful!");
            newUser = "";
            newPass = "";
            newEmail = "";

            usernameLog.Clear();
            passwordLog.Clear();
            emailLog.Clear();
            ageLog.Clear();
            confPasswordLog.Clear();
            verifLog.Clear();
            loginPanel.Visible = true;
            loginPanel.BringToFront();
        }

        private void mainDisplayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            homenav();
            sideMenuPanel.Visible = !sideMenuPanel.Visible;
            sideMenuPanel.BringToFront();
        }

        private void profilePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
