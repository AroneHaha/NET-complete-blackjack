using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace FinalBlackJack
{
    public partial class mainMenuForm : Form
    {
        public int accountIndex;
        public string usernameHolder;
        public string passwordHolder;
        public string emailHolder;
        public int accountBalanceHolder;
        public int accountTotalMatches;
        public int accountBustCount;
        public int accountWinnings;
        public double accountWinrate;

        public string walletChoice = "";
        public string historyAct = "";

        private homesounds clickSound;

        public mainMenuForm()
        {
            InitializeComponent();

            RefreshAccountData();

            this.Shown += mainMenuForm_Shown;
            mainDisplayPanel.Dock = DockStyle.Fill;
            mainDisplayPanel.Show();
            mainDisplayPanel.BringToFront();

            loginPanel.Show();
            signupPanel.Hide();
            mainMenuPanel.Hide();
            navBarPanel.Hide();
            sideMenuPanel.Hide();
            profilePanel.Hide();
            walletPanel.Hide();

            mainDisplayPanel.Controls.Clear();

        }

        private void mainMenuForm_Shown(object sender, EventArgs e)
        {
            // Only update stats if a user is logged in
            if (AccountData.currentAccount >= 0 && AccountData.currentAccount < AccountData.usernames.Count)
            {
                UpdateStatsAfterGame();
            }
        }


        public void makeDeposit()
        {
            try
            {
                historyAct = "Deposit";
                int amountToAdd = int.Parse(walletAmount.Text);
                MessageBox.Show("Transaction process is done, please check your account balance update.");
                AccountData.accountsBalance[AccountData.currentAccount] += amountToAdd;
                accountBalanceHolder = AccountData.accountsBalance[AccountData.currentAccount];
                walletBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
                homeBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
                resetWalletInfo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values only.");
            }
        }

        public void makeWithdrawal()
        {
            try
            {
                historyAct = "Withdrawal";
                int amountToAdd = int.Parse(walletAmount.Text);
                MessageBox.Show("Transaction process is done, please check your account balance update.");
                AccountData.accountsBalance[AccountData.currentAccount] -= amountToAdd;
                accountBalanceHolder = AccountData.accountsBalance[AccountData.currentAccount];
                walletBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
                homeBalance.Text = "Balance : PHP" + accountBalanceHolder.ToString();
                resetWalletInfo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values only.");
                walletPassword.Clear();
            }
        }

        public void resetWalletInfo()
        {
            walletAmount.Clear();
            walletPassword.Clear();
            walletChoice = "";
            widthdrawXdepo.Hide();
            confirmPanel.Hide();
        }

        public void RefreshAccountData()
        {
            if (AccountData.currentAccount < 0 || AccountData.currentAccount >= AccountData.usernames.Count)
            {
                accountWinrate = 0.0;
                accountTotalMatches = 0;
                accountBustCount = 0;
                accountWinnings = 0;
                return;
            }

            accountIndex = AccountData.currentAccount;
            usernameHolder = AccountData.usernames[accountIndex];
            passwordHolder = AccountData.passwords[accountIndex];
            emailHolder = AccountData.emails[accountIndex];
            accountBalanceHolder = AccountData.accountsBalance[accountIndex];

            int wins = AccountData.totalWins[accountIndex];
            int losses = AccountData.totalLosses[accountIndex];
            int totalGames = wins + losses;

            accountTotalMatches = totalGames;
            accountBustCount = AccountData.bustCount[accountIndex];
            accountWinnings = AccountData.totalWinnings[accountIndex];

            accountWinrate = totalGames > 0 ? Math.Round((double)wins / totalGames * 100, 2) : 0.0;
        }

        // New method to update stats and UI after a game
        public void UpdateStatsAfterGame()
        {

            RefreshAccountData();
            homeUsername.Text = "User : " + usernameHolder;
            homeBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
            matchesTxt.Text = "Matches : " + accountTotalMatches.ToString();
            bustTxt.Text = "Bust Count : " + accountBustCount.ToString();
            totalWinningsTxt.Text = "Winnings : PHP " + accountWinnings.ToString();
            walletBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
            winrateTxt.Text = "Winrate : " + accountWinrate.ToString("F2") + "%";
            updateHistory();
        }

        public void LoadView(UserControl control)
        {
            mainDisplayPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainDisplayPanel.Controls.Add(control);
        }

        public void showMainMenuPanel()
        {
            navBarPanel.Visible = true;
            sideMenuPanel.Visible = false;
        }

        public void signOutPanel()
        {
            mainDisplayPanel.Visible = false;
            mainMenuPanel.Visible = false;
            navBarPanel.Visible = false;
            loginPanel.Visible = true;
            loginPanel.BringToFront();
        }

        private void updateHistory()
        {
            if (AccountData.transactions[AccountData.currentAccount].Count > 0)
            {
                Transaction latestTransaction = AccountData.transactions[AccountData.currentAccount].Last();
                transacAct.Text = "Activity : " + latestTransaction.Activity;
                TransacTime.Text = "Time and Date : " + latestTransaction.Time;
                TransacAmount.Text = "Amount : PHP " + latestTransaction.Amount;
            }
            else
            {
                transacAct.Text = "Activity : None";
                TransacTime.Text = "Time and Date : None";
                TransacAmount.Text = "Amount : PHP 0";
            }
        }

        private void registerText_Click(object sender, EventArgs e)
        {
        }

        private int playerBalance = 0;
        private void loginButton_Click(object sender, EventArgs e)
        {
            homeUsername.Text = "Account: " + AccountData.usernames[AccountData.currentAccount];
            homeBalance.Text = "Balance: PHP " + AccountData.accountsBalance[AccountData.currentAccount].ToString("C2");
            string user = userLogin.Text.Trim();
            string pass = passwordLogin.Text;

            int idx = AccountData.usernames.IndexOf(user);
            if (idx == -1)
            {
                MessageBox.Show("Username not found.");
                return;
            }

            if (AccountData.passwords[idx] == pass && AccountData.usernames[idx] == user)
            {
                AccountData.currentAccount = idx;
                playerBalance = Convert.ToInt32(AccountData.accountsBalance[AccountData.currentAccount]);

                userLogin.Clear();
                passwordLogin.Clear();
                user = "";
                pass = "";

                RefreshAccountData();

                MessageBox.Show("Login successful!");

                homeUsername.Text = "User : " + usernameHolder;
                homeBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
                matchesTxt.Text = "Matches : " + accountTotalMatches.ToString();
                bustTxt.Text = "Bust Count : " + accountBustCount.ToString();
                totalWinningsTxt.Text = "Winnings : PHP " + accountWinnings.ToString();
                walletBalance.Text = "Balance : PHP " + accountBalanceHolder.ToString();
                winrateTxt.Text = "Winrate : " + accountWinrate.ToString("F2") + "%";

                updateHistory();

                signupPanel.Hide();
                loginPanel.Hide();
                mainMenuPanel.Show();
                mainDisplayPanel.Show();
                navBarPanel.Show();
                LoadView(new logPassword());
            }
            else
            {
                MessageBox.Show("Invalid password.");
                passwordLogin.Clear();
            }
        }

        private void clicking()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\clicks.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }
        private void errorSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\no-bet.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void depoSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\deposit.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void withSound()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\withdraw.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }
        private void homenav()
        {
            string musicPath = @"C:\BSIT 1\C#\blackjack\audio\homenav.wav";
            clickSound = new homesounds(musicPath);
            clickSound.PlayOnce();
        }

        private void switchToSignup_Click(object sender, EventArgs e)
        {
            userLogin.Clear();
            passwordLogin.Clear();
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
            walletPanel.Hide();
            profilePanel.Hide();
        }

        private void option1_Click(object sender, EventArgs e)
        {
            clicking();
            AccountData.currentAccount = 0;
            LoadView(new thirdmainMenu());
            sideMenuPanel.Hide();
            walletPanel.Hide();
            profilePanel.Hide();
        }

        private void option2_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new firstMainMenu());
            sideMenuPanel.Hide();
            walletPanel.Hide();
            profilePanel.Hide();
        }

        private void option3_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new secondMainMenu());
            sideMenuPanel.Hide();
            walletPanel.Hide();
            profilePanel.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            clicking();
            LoadView(new aboutPanel());
            sideMenuPanel.Hide();
            walletPanel.Hide();
            profilePanel.Hide();
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
            mainMenuForm parentMenuForm = this.FindForm() as mainMenuForm;

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

            if (string.IsNullOrWhiteSpace(newUser) || string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(newEmail))
            {
                errorSound();
                MessageBox.Show("Please make sure to fill in Username, Password, and Email.");
                return;
            }

            if (AccountData.usernames.Contains(newUser))
            {
                errorSound();
                MessageBox.Show("That username is already taken.");
                usernameLog.Text = "";
                return;
            }

            if (newPass.Length < 8)
            {
                errorSound();
                MessageBox.Show("Your password must be at least 8 characters.");
                passwordLog.Text = "";
                confPasswordLog.Text = "";
                return;
            }

            if (int.TryParse(ageLog.Text, out int age))
            {
                if (age < 18)
                {
                    errorSound();
                    MessageBox.Show("Below 18 years old is prohibited.");
                    ageLog.Text = "";
                    return;
                }
            }
            else
            {
                errorSound();
                MessageBox.Show("Please enter a valid number.");
                ageLog.Text = "";
                return;
            }

            if (passwordLog.Text != confPasswordLog.Text)
            {
                errorSound();
                MessageBox.Show("Password confirmation is incorrect.");
                passwordLog.Text = "";
                confPasswordLog.Text = "";
                return;
            }

            if (AccountData.emails.Contains(newEmail))
            {
                errorSound();
                MessageBox.Show("That email is already registered.");
                emailLog.Text = "";
                return;
            }

            if (string.IsNullOrWhiteSpace(verifCode))
            {
                errorSound();
                MessageBox.Show("Please request a verification code to process your account.");
                return;
            }

            if (verifLog.Text != verifCode)
            {
                errorSound();
                MessageBox.Show("Invalid Verification Code.");
                verifLog.Text = "";
                return;
            }

            AccountData.usernames.Add(newUser);
            AccountData.passwords.Add(newPass);
            AccountData.emails.Add(newEmail);
            AccountData.accountsBalance.Add(0);
            AccountData.totalWins.Add(0);
            AccountData.totalLosses.Add(0);
            AccountData.bustCount.Add(0);
            AccountData.totalWinnings.Add(0);
            AccountData.transactions.Add(new List<Transaction>());
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

        private void backButton_Click(object sender, EventArgs e)
        {
            usernameLog.Clear();
            passwordLog.Clear();
            emailLog.Clear();
            ageLog.Clear();
            confPasswordLog.Clear();
            verifLog.Clear();
            signupPanel.Hide();
            loginPanel.Show();
            loginPanel.BringToFront();
        }

        private void walletButton_Click(object sender, EventArgs e)
        {

            widthdrawXdepo.Hide();
            confirmPanel.Hide();
            historyPanel.Hide();

            homenav();
            walletPanel.Visible = !walletPanel.Visible;
            if (walletPanel.Visible)
            {
                
                walletPanel.BringToFront();
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            clicking();
            walletChoice = "deposit";
            walletPassword.Clear();
            walletAmount.Clear();
            widthdrawXdepo.Visible = !widthdrawXdepo.Visible;
        }

        private void widthdrawButton_Click(object sender, EventArgs e)
        {
            clicking();
            walletChoice = "withdraw";
            walletPassword.Clear();
            walletAmount.Clear();
            widthdrawXdepo.Visible = !widthdrawXdepo.Visible;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            clicking();
            confirmPanel.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            widthdrawXdepo.Hide();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            walletPanel.Hide();
        }

        private void walletPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void lossTxt_Click(object sender, EventArgs e)
        {
        }

        private void navBarPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void homeUsername_Click(object sender, EventArgs e)
        {
        }

        private void matchesTxt_Click(object sender, EventArgs e)
        {
        }

        private void secondmainMenuPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            clicking();
            walletPanel.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            UpdateStatsAfterGame();
            homenav();
            profilePanel.Visible = !profilePanel.Visible;
            profilePanel.BringToFront();
        }

        private void userBox_MouseEnter(object sender, EventArgs e)
        {
            userBox.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\user-hovered.png");
        }

        private void userBox_MouseLeave(object sender, EventArgs e)
        {
            userBox.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\user.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            navBar.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\bar-hovered.png");
        }

        private void navBar_MouseLeave(object sender, EventArgs e)
        {
            navBar.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\bar real.png");
        }

        private void walletAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void walletConfirmPassword_Click(object sender, EventArgs e)
        {
            int amount;
            clicking();
            if (!int.TryParse(walletAmount.Text, out amount))
            {
                errorSound();
                MessageBox.Show("Please enter a valid number for the amount.");
                walletAmount.Clear();
                return;
            }

            if (amount <= 0)
            {
                errorSound();
                MessageBox.Show("Amount must be greater than zero.");
                walletAmount.Clear();
                return;
            }

            if ((walletChoice == "withdraw") && (AccountData.accountsBalance[AccountData.currentAccount] < amount))
            {
                errorSound();
                MessageBox.Show("You have insufficient balance to make the withdrawal.");
                walletAmount.Clear();
                return;
            }

            if (walletPassword.Text == passwordHolder)
            {
                string activity = walletChoice == "deposit" ? "Deposit" : "Withdrawal";
                string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string amountStr = walletAmount.Text;

                AccountData.transactions[AccountData.currentAccount].Add(new Transaction(activity, time, amountStr));

                if (walletChoice == "deposit")
                {
                    depoSound();
                    makeDeposit();
                }
                else
                {
                    withSound();
                    makeWithdrawal();
                }
            }
            else
            {
                errorSound();
                MessageBox.Show("Incorrect password. Please try again.");
                walletPassword.Clear();
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            historyPanel.Visible = !historyPanel.Visible;
        }

        private void closeHistory_Click(object sender, EventArgs e)
        {
            historyPanel.Hide();
        }

        private void fogotPassowrdButton_Click(object sender, EventArgs e)
        {
            userLogin.Clear();
            passwordLogin.Clear();
            changePassPanel.Hide();
            forgotPassPanel.Visible = true;
            loginPanel.Visible = false;
            signupPanel.Visible = false;
        }

        private void exitForgotPassButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            forgotPassPanel.Visible = false;
        }

        private void confirmButton_Click_1(object sender, EventArgs e)
        {
            changePassPanel.Visible = true;
            forgotPassPanel.Visible = true;
        }

        private void cancelChangePassButton_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            forgotPassPanel.Visible = false;
        }

        private void confirmChangePass_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            forgotPassPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void exitProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePassPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (changeConfPw.Text != changePw.Text)
            {
                MessageBox.Show("Password confirmation does not match.");
                changeConfPw.Clear();
                changePw.Clear();
                return;
            }

            if (changePw.Text.Length < 8)
            {
                MessageBox.Show("Your password must be at least 8 characters.");
                changeConfPw.Clear();
                changePw.Clear();
                return;
            }

            MessageBox.Show("Your account has been successfully retrieved.");
            AccountData.passwords[AccountData.currentAccount] = changePw.Text;

            changePw.Clear();
            changeConfPw.Clear();
            loginPanel.Show();
            forgotPassPanel.Visible = false;
            changePassPanel.Visible = false;
            loginPanel.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            forgotPassPanel.Visible = false;
        }

        private void sendCodeButton_Click(object sender, EventArgs e)
        {
        }

        string forgotPasswordCode = "";
        Boolean isForgotCodeSent = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!AccountData.usernames.Contains(forgotUsername.Text))
            {
                MessageBox.Show("No matching account was found.");
                forgotUsername.Clear();
                forgotCode.Clear();
                return;
            }

            Random otp = new Random();
            try
            {
                forgotPasswordCode = otp.Next(100000, 1000000).ToString(); // 6-digit OTP
                string verifLink = "markaronedc@gmail.com"; // NEED PALITAN NG NEW GMAIL
                string pass = "xogd neyn kdez ovts"; // GMAIL KEYPASS FOR VERIF --- markaronedc@gmail.com keypass    
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");

                mm.From = new MailAddress(verifLink);
                mm.To.Add(AccountData.emails[AccountData.currentAccount]);
                mm.Subject = "BlackJack Deluxe: Lost Account Password";
                mm.Body = "Hi " + AccountData.usernames[AccountData.currentAccount] + ",\r\n\r\nIt seems like you're having a trouble with logging in your account and requested for Account Recovery.\r\nTo proceed with resolving the issue, please use the One-Time Password (OTP) below to complete the process:\r\n\r\n🔐 OTP Code: " + forgotPasswordCode;

                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(verifLink, pass);
                sc.EnableSsl = true;
                sc.Send(mm);

                isForgotCodeSent = true;
                MessageBox.Show("Code has been sent to registered email of this account.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(forgotUsername.Text) || string.IsNullOrWhiteSpace(forgotCode.Text))
            {
                errorSound();
                MessageBox.Show("Please fill in all requirements.");
                return;
            }

            if (!AccountData.usernames.Contains(forgotUsername.Text))
            {
                errorSound();
                MessageBox.Show("No matching account was found.");
                forgotUsername.Clear();
                forgotCode.Clear();
                return;
            }

            if (isForgotCodeSent == false)
            {
                errorSound();
                MessageBox.Show("Please request for Password Reset code.");
                forgotCode.Clear();
                return;
            }

            if (forgotCode.Text != forgotPasswordCode)
            {
                errorSound();
                MessageBox.Show("Incorrect verification code. Please try again.");
                forgotCode.Clear();
                return;
            }

            isForgotCodeSent = false;
            forgotCode.Clear();
            forgotUsername.Clear();

            MessageBox.Show("Your credentials are validated, proceed to change your password.");
            changePassPanel.Visible = true;
            forgotPassPanel.Visible = false;
            changePassPanel.Enabled = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            isForgotCodeSent = false;
            forgotCode.Clear();
            forgotUsername.Clear();
            loginPanel.Visible = true;
            forgotPassPanel.Visible = false;
        }

        private void pictureBox1_MouseEnter_1(object sender, EventArgs e)
        {
            forgotBack.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\back-hover.png");
        }

        private void forgotBack_MouseLeave(object sender, EventArgs e)
        {
            forgotBack.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\back.png");
        }

        private void forgotPassPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void changePw_TextChanged(object sender, EventArgs e)
        {
        }

        private void sideMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool wasWithdrawVisible = false;
        private void historyBtn_Click(object sender, EventArgs e)
        {
            updateHistory();
            homenav();

            // If historyPanel is not visible yet (we're about to show it)
            if (!historyPanel.Visible)
            {
                // Save current state of withdraw panel and hide it
                wasWithdrawVisible = widthdrawXdepo.Visible;
                widthdrawXdepo.Hide();
                historyPanel.Visible = true;
            }
            else
            {
                // We're hiding historyPanel now
                historyPanel.Visible = false;

                // Restore withdraw panel visibility if it was previously open
                if (wasWithdrawVisible)
                {
                    widthdrawXdepo.Show();
                }
            }

            historyPanel.BringToFront();
        }

        private void historyBtn_MouseEnter(object sender, EventArgs e)
        {
            historyBtn.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\history-hover.png");
        }

        private void historyBtn_MouseLeave(object sender, EventArgs e)
        {
            historyBtn.Image = Image.FromFile(@"C:\BSIT 1\C#\blackjack\images\history.png");
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {
            // Example with validation:
            if (AccountData.currentAccount >= 0 && AccountData.currentAccount < AccountData.usernames.Count)
            {
                UpdateStatsAfterGame();
            }
        }
    }
}