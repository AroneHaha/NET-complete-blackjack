namespace FinalBlackJack
{
    partial class mainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            loginPanel = new Panel();
            switchToSignup = new Button();
            registerText = new Label();
            loginButton = new Button();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            label4 = new Label();
            usernameLabel = new Label();
            passwordLabel = new Label();
            userLogin = new TextBox();
            passwordLogin = new TextBox();
            mainMenuPanel = new Panel();
            profilePanel = new Panel();
            sideMenuPanel = new FlowLayoutPanel();
            sideHomePanel = new Panel();
            homeButton = new Button();
            panel1 = new Panel();
            option2 = new Button();
            panel3 = new Panel();
            option3 = new Button();
            panel2 = new Panel();
            option1 = new Button();
            navBarPanel = new Panel();
            pictureBox1 = new PictureBox();
            profileButton = new Button();
            secondmainMenuPanel = new Panel();
            tittleNavBar = new Label();
            homeUsername = new Label();
            homeBalance = new Label();
            mainDisplayPanel = new Panel();
            form3Button = new Button();
            signupPanel = new Panel();
            ageLog = new TextBox();
            verifLog = new TextBox();
            verifBtn = new Button();
            emailLog = new TextBox();
            label9 = new Label();
            label8 = new Label();
            confPasswordLog = new TextBox();
            label7 = new Label();
            createAccountBtn = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            usernameLog = new TextBox();
            passwordLog = new TextBox();
            verificationText = new Label();
            loginPanel.SuspendLayout();
            mainMenuPanel.SuspendLayout();
            sideMenuPanel.SuspendLayout();
            sideHomePanel.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            navBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            signupPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.ForestGreen;
            loginPanel.Controls.Add(switchToSignup);
            loginPanel.Controls.Add(registerText);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(label10);
            loginPanel.Controls.Add(label4);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(userLogin);
            loginPanel.Controls.Add(passwordLogin);
            loginPanel.ForeColor = Color.Black;
            loginPanel.Location = new Point(0, -4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(456, 621);
            loginPanel.TabIndex = 0;
            // 
            // switchToSignup
            // 
            switchToSignup.BackColor = Color.Transparent;
            switchToSignup.FlatAppearance.BorderSize = 0;
            switchToSignup.FlatStyle = FlatStyle.Flat;
            switchToSignup.Font = new Font("Corbel", 8F);
            switchToSignup.ForeColor = Color.Red;
            switchToSignup.Location = new Point(266, 479);
            switchToSignup.Name = "switchToSignup";
            switchToSignup.Size = new Size(59, 21);
            switchToSignup.TabIndex = 9;
            switchToSignup.Text = "Click here";
            switchToSignup.UseVisualStyleBackColor = false;
            switchToSignup.Click += switchToSignup_Click;
            // 
            // registerText
            // 
            registerText.AutoSize = true;
            registerText.Font = new Font("Corbel", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registerText.ForeColor = Color.Black;
            registerText.Location = new Point(143, 483);
            registerText.Name = "registerText";
            registerText.Size = new Size(130, 13);
            registerText.TabIndex = 8;
            registerText.Text = "Don't have an account yet? ";
            registerText.Click += registerText_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.DarkOrange;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Haettenschweiler", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(181, 370);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(110, 37);
            loginButton.TabIndex = 7;
            loginButton.Text = "Log-In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(183, 167);
            label2.Name = "label2";
            label2.Size = new Size(76, 35);
            label2.TabIndex = 5;
            label2.Text = "Log-In";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 40F);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(72, 95);
            label1.Name = "label1";
            label1.Size = new Size(319, 56);
            label1.TabIndex = 4;
            label1.Text = "Black Jack Deluxe";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Corbel", 14F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(82, 263);
            label10.Name = "label10";
            label10.Size = new Size(103, 23);
            label10.TabIndex = 3;
            label10.Text = "Username : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 14F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(83, 316);
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 2;
            label4.Text = "Password : ";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Haettenschweiler", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(95, 263);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(83, 22);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username : ";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Haettenschweiler", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(96, 316);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(84, 22);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password : ";
            // 
            // userLogin
            // 
            userLogin.Location = new Point(184, 263);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(185, 23);
            userLogin.TabIndex = 1;
            userLogin.TextChanged += userNameLoginTextbox_TextChanged;
            // 
            // passwordLogin
            // 
            passwordLogin.Location = new Point(185, 316);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(185, 23);
            passwordLogin.TabIndex = 0;
            passwordLogin.TextChanged += passwordLoginTextBox_TextChanged;
            // 
            // mainMenuPanel
            // 
            mainMenuPanel.BackColor = Color.DarkOliveGreen;
            mainMenuPanel.Controls.Add(profilePanel);
            mainMenuPanel.Controls.Add(sideMenuPanel);
            mainMenuPanel.Controls.Add(navBarPanel);
            mainMenuPanel.Controls.Add(mainDisplayPanel);
            mainMenuPanel.Dock = DockStyle.Fill;
            mainMenuPanel.Location = new Point(0, 0);
            mainMenuPanel.Name = "mainMenuPanel";
            mainMenuPanel.Size = new Size(984, 611);
            mainMenuPanel.TabIndex = 9;
            mainMenuPanel.Paint += mainMenuPanel_Paint;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.ForestGreen;
            profilePanel.Dock = DockStyle.Right;
            profilePanel.Location = new Point(772, 66);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(212, 545);
            profilePanel.TabIndex = 4;
            profilePanel.Paint += profilePanel_Paint;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.Green;
            sideMenuPanel.Controls.Add(sideHomePanel);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Controls.Add(panel3);
            sideMenuPanel.Controls.Add(panel2);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 66);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(257, 545);
            sideMenuPanel.TabIndex = 1;
            // 
            // sideHomePanel
            // 
            sideHomePanel.BackColor = Color.Green;
            sideHomePanel.Controls.Add(homeButton);
            sideHomePanel.Location = new Point(3, 3);
            sideHomePanel.Name = "sideHomePanel";
            sideHomePanel.Size = new Size(248, 72);
            sideHomePanel.TabIndex = 5;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.DarkOrange;
            homeButton.FlatStyle = FlatStyle.Popup;
            homeButton.Font = new Font("Haettenschweiler", 20F);
            homeButton.ForeColor = Color.WhiteSmoke;
            homeButton.Location = new Point(3, 1);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(242, 70);
            homeButton.TabIndex = 1;
            homeButton.Text = "Home";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(option2);
            panel1.Location = new Point(3, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 75);
            panel1.TabIndex = 2;
            // 
            // option2
            // 
            option2.BackColor = Color.DarkOrange;
            option2.FlatStyle = FlatStyle.Popup;
            option2.Font = new Font("Haettenschweiler", 20F);
            option2.ForeColor = Color.WhiteSmoke;
            option2.Location = new Point(3, 3);
            option2.Name = "option2";
            option2.Size = new Size(242, 70);
            option2.TabIndex = 0;
            option2.Text = "How to Play";
            option2.UseVisualStyleBackColor = false;
            option2.Click += option2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Green;
            panel3.Controls.Add(option3);
            panel3.Location = new Point(3, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 75);
            panel3.TabIndex = 4;
            // 
            // option3
            // 
            option3.BackColor = Color.DarkOrange;
            option3.FlatStyle = FlatStyle.Popup;
            option3.Font = new Font("Haettenschweiler", 20F);
            option3.ForeColor = Color.WhiteSmoke;
            option3.Location = new Point(3, 2);
            option3.Name = "option3";
            option3.Size = new Size(242, 70);
            option3.TabIndex = 0;
            option3.Text = "Settings";
            option3.UseVisualStyleBackColor = false;
            option3.Click += option3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(option1);
            panel2.Location = new Point(3, 243);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 75);
            panel2.TabIndex = 3;
            // 
            // option1
            // 
            option1.BackColor = Color.DarkOrange;
            option1.FlatStyle = FlatStyle.Popup;
            option1.Font = new Font("Haettenschweiler", 20F);
            option1.ForeColor = Color.WhiteSmoke;
            option1.Location = new Point(3, 3);
            option1.Name = "option1";
            option1.Size = new Size(242, 70);
            option1.TabIndex = 0;
            option1.Text = "Log Out";
            option1.UseVisualStyleBackColor = false;
            option1.Click += option1_Click;
            // 
            // navBarPanel
            // 
            navBarPanel.BackColor = Color.DarkGreen;
            navBarPanel.Controls.Add(pictureBox1);
            navBarPanel.Controls.Add(profileButton);
            navBarPanel.Controls.Add(secondmainMenuPanel);
            navBarPanel.Controls.Add(tittleNavBar);
            navBarPanel.Controls.Add(homeUsername);
            navBarPanel.Controls.Add(homeBalance);
            navBarPanel.Dock = DockStyle.Top;
            navBarPanel.ForeColor = Color.Black;
            navBarPanel.Location = new Point(0, 0);
            navBarPanel.Name = "navBarPanel";
            navBarPanel.Size = new Size(984, 66);
            navBarPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(12, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.Transparent;
            profileButton.Location = new Point(772, 7);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(67, 53);
            profileButton.TabIndex = 4;
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            // 
            // secondmainMenuPanel
            // 
            secondmainMenuPanel.BackColor = Color.Gray;
            secondmainMenuPanel.Location = new Point(6, 63);
            secondmainMenuPanel.Name = "secondmainMenuPanel";
            secondmainMenuPanel.Size = new Size(984, 548);
            secondmainMenuPanel.TabIndex = 3;
            // 
            // tittleNavBar
            // 
            tittleNavBar.AutoSize = true;
            tittleNavBar.Font = new Font("Haettenschweiler", 28.25F);
            tittleNavBar.ForeColor = Color.Black;
            tittleNavBar.Location = new Point(75, 9);
            tittleNavBar.Name = "tittleNavBar";
            tittleNavBar.Size = new Size(233, 40);
            tittleNavBar.TabIndex = 2;
            tittleNavBar.Text = "Black Jack Deluxe";
            // 
            // homeUsername
            // 
            homeUsername.AutoSize = true;
            homeUsername.Font = new Font("Haettenschweiler", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeUsername.ForeColor = Color.WhiteSmoke;
            homeUsername.Location = new Point(849, 12);
            homeUsername.Name = "homeUsername";
            homeUsername.Size = new Size(39, 17);
            homeUsername.TabIndex = 1;
            homeUsername.Text = "User : ";
            // 
            // homeBalance
            // 
            homeBalance.AutoSize = true;
            homeBalance.Font = new Font("Haettenschweiler", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homeBalance.ForeColor = Color.WhiteSmoke;
            homeBalance.Location = new Point(849, 35);
            homeBalance.Name = "homeBalance";
            homeBalance.Size = new Size(54, 17);
            homeBalance.TabIndex = 0;
            homeBalance.Text = "Balance : ";
            // 
            // mainDisplayPanel
            // 
            mainDisplayPanel.BackColor = Color.PaleGoldenrod;
            mainDisplayPanel.Location = new Point(441, 252);
            mainDisplayPanel.Name = "mainDisplayPanel";
            mainDisplayPanel.Size = new Size(200, 100);
            mainDisplayPanel.TabIndex = 0;
            mainDisplayPanel.Paint += mainDisplayPanel_Paint;
            // 
            // form3Button
            // 
            form3Button.Location = new Point(0, 0);
            form3Button.Name = "form3Button";
            form3Button.Size = new Size(75, 23);
            form3Button.TabIndex = 0;
            // 
            // signupPanel
            // 
            signupPanel.BackColor = Color.ForestGreen;
            signupPanel.Controls.Add(ageLog);
            signupPanel.Controls.Add(verifLog);
            signupPanel.Controls.Add(verifBtn);
            signupPanel.Controls.Add(emailLog);
            signupPanel.Controls.Add(label9);
            signupPanel.Controls.Add(label8);
            signupPanel.Controls.Add(confPasswordLog);
            signupPanel.Controls.Add(label7);
            signupPanel.Controls.Add(createAccountBtn);
            signupPanel.Controls.Add(label3);
            signupPanel.Controls.Add(label5);
            signupPanel.Controls.Add(label6);
            signupPanel.Controls.Add(usernameLog);
            signupPanel.Controls.Add(passwordLog);
            signupPanel.Controls.Add(verificationText);
            signupPanel.ForeColor = Color.Black;
            signupPanel.Location = new Point(0, -1);
            signupPanel.Name = "signupPanel";
            signupPanel.Size = new Size(456, 612);
            signupPanel.TabIndex = 11;
            // 
            // ageLog
            // 
            ageLog.Location = new Point(129, 325);
            ageLog.Name = "ageLog";
            ageLog.Size = new Size(73, 23);
            ageLog.TabIndex = 17;
            // 
            // verifLog
            // 
            verifLog.Location = new Point(226, 420);
            verifLog.Name = "verifLog";
            verifLog.Size = new Size(147, 23);
            verifLog.TabIndex = 15;
            verifLog.TextChanged += verifLog_TextChanged;
            // 
            // verifBtn
            // 
            verifBtn.BackColor = Color.Red;
            verifBtn.Cursor = Cursors.Hand;
            verifBtn.FlatStyle = FlatStyle.Popup;
            verifBtn.Font = new Font("Haettenschweiler", 10F);
            verifBtn.ForeColor = Color.White;
            verifBtn.Location = new Point(381, 417);
            verifBtn.Name = "verifBtn";
            verifBtn.Size = new Size(54, 27);
            verifBtn.TabIndex = 14;
            verifBtn.Text = "Send Verification Code";
            verifBtn.UseVisualStyleBackColor = false;
            verifBtn.Click += verificationButton_Click_1;
            // 
            // emailLog
            // 
            emailLog.Location = new Point(203, 375);
            emailLog.Name = "emailLog";
            emailLog.Size = new Size(170, 23);
            emailLog.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Corbel", 14F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(70, 375);
            label9.Name = "label9";
            label9.Size = new Size(132, 23);
            label9.TabIndex = 12;
            label9.Text = "Email Address : ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Corbel", 14F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(70, 325);
            label8.Name = "label8";
            label8.Size = new Size(50, 23);
            label8.TabIndex = 11;
            label8.Text = "Age :";
            // 
            // confPasswordLog
            // 
            confPasswordLog.Location = new Point(238, 276);
            confPasswordLog.Name = "confPasswordLog";
            confPasswordLog.Size = new Size(166, 23);
            confPasswordLog.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 14F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(70, 276);
            label7.Name = "label7";
            label7.Size = new Size(166, 23);
            label7.TabIndex = 9;
            label7.Text = "Confirm Password : ";
            // 
            // createAccountBtn
            // 
            createAccountBtn.BackColor = Color.DarkOrange;
            createAccountBtn.Cursor = Cursors.Hand;
            createAccountBtn.FlatStyle = FlatStyle.Popup;
            createAccountBtn.Font = new Font("Haettenschweiler", 12F);
            createAccountBtn.ForeColor = Color.White;
            createAccountBtn.Location = new Point(158, 494);
            createAccountBtn.Name = "createAccountBtn";
            createAccountBtn.Size = new Size(135, 43);
            createAccountBtn.TabIndex = 7;
            createAccountBtn.Text = "Create Account";
            createAccountBtn.UseVisualStyleBackColor = false;
            createAccountBtn.Click += createAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Haettenschweiler", 45F);
            label3.ForeColor = Color.DarkOrange;
            label3.Location = new Point(29, 71);
            label3.Name = "label3";
            label3.Size = new Size(398, 62);
            label3.TabIndex = 5;
            label3.Text = "Register an Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 14F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(72, 176);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 3;
            label5.Text = "Username : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 14F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(72, 226);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 2;
            label6.Text = "Password : ";
            // 
            // usernameLog
            // 
            usernameLog.Location = new Point(181, 176);
            usernameLog.Name = "usernameLog";
            usernameLog.Size = new Size(185, 23);
            usernameLog.TabIndex = 1;
            // 
            // passwordLog
            // 
            passwordLog.Location = new Point(181, 229);
            passwordLog.Name = "passwordLog";
            passwordLog.Size = new Size(185, 23);
            passwordLog.TabIndex = 0;
            // 
            // verificationText
            // 
            verificationText.AutoSize = true;
            verificationText.Font = new Font("Corbel", 14F);
            verificationText.ForeColor = Color.Black;
            verificationText.Location = new Point(70, 420);
            verificationText.Name = "verificationText";
            verificationText.Size = new Size(150, 23);
            verificationText.TabIndex = 16;
            verificationText.Text = "Verification Code :";
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(984, 611);
            Controls.Add(mainMenuPanel);
            Controls.Add(signupPanel);
            Controls.Add(loginPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Black Jack Deluxe";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            mainMenuPanel.ResumeLayout(false);
            sideMenuPanel.ResumeLayout(false);
            sideHomePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            navBarPanel.ResumeLayout(false);
            navBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            signupPanel.ResumeLayout(false);
            signupPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox userLogin;
        private TextBox passwordLogin;
        private Label registerText;
        private Button loginButton;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private Button switchToSignup;
        private Panel mainMenuPanel;
        private Panel navBarPanel;
        private Label tittleNavBar;
        private Label homeUsername;
        private Label homeBalance;
        private FlowLayoutPanel sideMenuPanel;
        private Panel panel1;
        private Button option1;
        private Panel panel3;
        private Button option3;
        private Panel panel2;
        private Button option2;
        private Panel secondmainMenuPanel;
        private Panel mainDisplayPanel;
        private Panel sideHomePanel;
        private Button homeButton;
        private thirdmainMenu thirdmainMenu1;
        private Label label10;
        private Panel profilePanel;
        private Button profileButton;
        private Button form3Button;
        private Panel signupPanel;
        private TextBox verifLog;
        private Button verifBtn;
        private TextBox emailLog;
        private Label label9;
        private Label label8;
        private TextBox confPasswordLog;
        private Label label7;
        private Button createAccountBtn;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox usernameLog;
        private TextBox passwordLog;
        private Label verificationText;
        private Label label4;
        private TextBox ageLog;
        private PictureBox pictureBox1;
    }
}