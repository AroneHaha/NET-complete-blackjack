namespace FinalBlackJack
{
    partial class singaporePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(singaporePanel));
            rPlayer1 = new PictureBox();
            rPlayer2 = new PictureBox();
            rPlayer3 = new PictureBox();
            rPlayer4 = new PictureBox();
            rDealer3 = new PictureBox();
            rDealer2 = new PictureBox();
            rDealer1 = new PictureBox();
            panel1 = new Panel();
            currentRound = new Label();
            backButton = new Button();
            rChip100 = new PictureBox();
            rChip50 = new PictureBox();
            rChip25 = new PictureBox();
            rChip10 = new PictureBox();
            rChip1 = new PictureBox();
            rChip5 = new PictureBox();
            actionLog = new Label();
            r_totalWinnings = new Label();
            r_BankRoll = new Label();
            startRound = new Button();
            rBet = new Label();
            rCardFolded = new PictureBox();
            hitBtn = new Button();
            button2 = new Button();
            standBtn = new Button();
            rDealer4 = new PictureBox();
            botValue = new Label();
            playerValue = new Label();
            ((System.ComponentModel.ISupportInitialize)rPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rChip100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rChip50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rChip25).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rChip10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rChip1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rChip5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rCardFolded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer4).BeginInit();
            SuspendLayout();
            // 
            // rPlayer1
            // 
            rPlayer1.BackColor = Color.Transparent;
            rPlayer1.BorderStyle = BorderStyle.Fixed3D;
            rPlayer1.Location = new Point(334, 416);
            rPlayer1.Name = "rPlayer1";
            rPlayer1.Size = new Size(69, 96);
            rPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer1.TabIndex = 0;
            rPlayer1.TabStop = false;
            rPlayer1.Click += rPlayer1_Click;
            // 
            // rPlayer2
            // 
            rPlayer2.BackColor = Color.Transparent;
            rPlayer2.BorderStyle = BorderStyle.Fixed3D;
            rPlayer2.Location = new Point(409, 416);
            rPlayer2.Name = "rPlayer2";
            rPlayer2.Size = new Size(69, 96);
            rPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer2.TabIndex = 1;
            rPlayer2.TabStop = false;
            // 
            // rPlayer3
            // 
            rPlayer3.BackColor = Color.Transparent;
            rPlayer3.BorderStyle = BorderStyle.Fixed3D;
            rPlayer3.Location = new Point(484, 416);
            rPlayer3.Name = "rPlayer3";
            rPlayer3.Size = new Size(69, 96);
            rPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer3.TabIndex = 2;
            rPlayer3.TabStop = false;
            rPlayer3.Click += pictureBox3_Click;
            // 
            // rPlayer4
            // 
            rPlayer4.BackColor = Color.Transparent;
            rPlayer4.BorderStyle = BorderStyle.Fixed3D;
            rPlayer4.Location = new Point(559, 416);
            rPlayer4.Name = "rPlayer4";
            rPlayer4.Size = new Size(69, 96);
            rPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer4.TabIndex = 3;
            rPlayer4.TabStop = false;
            // 
            // rDealer3
            // 
            rDealer3.BackColor = Color.Transparent;
            rDealer3.BorderStyle = BorderStyle.Fixed3D;
            rDealer3.Location = new Point(489, 84);
            rDealer3.Name = "rDealer3";
            rDealer3.Size = new Size(69, 96);
            rDealer3.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer3.TabIndex = 7;
            rDealer3.TabStop = false;
            rDealer3.Click += pictureBox5_Click;
            // 
            // rDealer2
            // 
            rDealer2.BackColor = Color.Transparent;
            rDealer2.BorderStyle = BorderStyle.Fixed3D;
            rDealer2.Location = new Point(414, 84);
            rDealer2.Name = "rDealer2";
            rDealer2.Size = new Size(69, 96);
            rDealer2.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer2.TabIndex = 6;
            rDealer2.TabStop = false;
            // 
            // rDealer1
            // 
            rDealer1.BackColor = Color.Transparent;
            rDealer1.BorderStyle = BorderStyle.Fixed3D;
            rDealer1.Location = new Point(339, 84);
            rDealer1.Name = "rDealer1";
            rDealer1.Size = new Size(69, 96);
            rDealer1.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer1.TabIndex = 5;
            rDealer1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(playerValue);
            panel1.Controls.Add(botValue);
            panel1.Controls.Add(currentRound);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(rChip100);
            panel1.Controls.Add(rChip50);
            panel1.Controls.Add(rChip25);
            panel1.Controls.Add(rChip10);
            panel1.Controls.Add(rChip1);
            panel1.Controls.Add(rChip5);
            panel1.Controls.Add(actionLog);
            panel1.Controls.Add(r_totalWinnings);
            panel1.Controls.Add(r_BankRoll);
            panel1.Controls.Add(startRound);
            panel1.Controls.Add(rBet);
            panel1.Controls.Add(rCardFolded);
            panel1.Controls.Add(hitBtn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(standBtn);
            panel1.Controls.Add(rDealer4);
            panel1.Controls.Add(rPlayer4);
            panel1.Controls.Add(rDealer3);
            panel1.Controls.Add(rPlayer3);
            panel1.Controls.Add(rDealer1);
            panel1.Controls.Add(rPlayer2);
            panel1.Controls.Add(rDealer2);
            panel1.Controls.Add(rPlayer1);
            panel1.Location = new Point(3, -34);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 635);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // currentRound
            // 
            currentRound.AutoSize = true;
            currentRound.Font = new Font("Corbel", 16F, FontStyle.Bold);
            currentRound.ForeColor = Color.White;
            currentRound.Location = new Point(176, 594);
            currentRound.Name = "currentRound";
            currentRound.Size = new Size(90, 27);
            currentRound.TabIndex = 25;
            currentRound.Text = "Round : ";
            // 
            // backButton
            // 
            backButton.Location = new Point(17, 52);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 24;
            backButton.Text = "button1";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // rChip100
            // 
            rChip100.BackColor = Color.Transparent;
            rChip100.Cursor = Cursors.Hand;
            rChip100.Image = (Image)resources.GetObject("rChip100.Image");
            rChip100.Location = new Point(120, 349);
            rChip100.Name = "rChip100";
            rChip100.Size = new Size(57, 54);
            rChip100.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip100.TabIndex = 23;
            rChip100.TabStop = false;
            rChip100.Click += rChip100_Click;
            rChip100.MouseEnter += rChip100_MouseEnter_1;
            rChip100.MouseLeave += rChip100_MouseLeave;
            // 
            // rChip50
            // 
            rChip50.BackColor = Color.Transparent;
            rChip50.Cursor = Cursors.Hand;
            rChip50.Image = (Image)resources.GetObject("rChip50.Image");
            rChip50.Location = new Point(191, 372);
            rChip50.Name = "rChip50";
            rChip50.Size = new Size(57, 54);
            rChip50.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip50.TabIndex = 22;
            rChip50.TabStop = false;
            rChip50.Click += rChip50_Click;
            rChip50.MouseEnter += rChip50_MouseEnter_1;
            rChip50.MouseLeave += rChip50_MouseLeave_1;
            // 
            // rChip25
            // 
            rChip25.BackColor = Color.Transparent;
            rChip25.Cursor = Cursors.Hand;
            rChip25.Image = (Image)resources.GetObject("rChip25.Image");
            rChip25.Location = new Point(261, 391);
            rChip25.Name = "rChip25";
            rChip25.Size = new Size(57, 54);
            rChip25.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip25.TabIndex = 21;
            rChip25.TabStop = false;
            rChip25.Click += rChip25_Click;
            rChip25.MouseEnter += rChip25_MouseEnter;
            rChip25.MouseLeave += rChip25_MouseLeave;
            // 
            // rChip10
            // 
            rChip10.BackColor = Color.Transparent;
            rChip10.Cursor = Cursors.Hand;
            rChip10.Image = (Image)resources.GetObject("rChip10.Image");
            rChip10.Location = new Point(120, 418);
            rChip10.Name = "rChip10";
            rChip10.Size = new Size(57, 54);
            rChip10.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip10.TabIndex = 20;
            rChip10.TabStop = false;
            rChip10.Click += rChip10_Click;
            rChip10.MouseEnter += rChip10_MouseEnter_1;
            rChip10.MouseLeave += rChip10_MouseLeave_1;
            // 
            // rChip1
            // 
            rChip1.BackColor = Color.Transparent;
            rChip1.Cursor = Cursors.Hand;
            rChip1.Image = (Image)resources.GetObject("rChip1.Image");
            rChip1.Location = new Point(261, 460);
            rChip1.Name = "rChip1";
            rChip1.Size = new Size(57, 54);
            rChip1.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip1.TabIndex = 19;
            rChip1.TabStop = false;
            rChip1.Click += rChip1_Click;
            rChip1.MouseEnter += rChip1_MouseEnter;
            rChip1.MouseLeave += rChip1_MouseLeave;
            // 
            // rChip5
            // 
            rChip5.BackColor = Color.Transparent;
            rChip5.Cursor = Cursors.Hand;
            rChip5.Image = (Image)resources.GetObject("rChip5.Image");
            rChip5.Location = new Point(191, 443);
            rChip5.Name = "rChip5";
            rChip5.Size = new Size(57, 54);
            rChip5.SizeMode = PictureBoxSizeMode.StretchImage;
            rChip5.TabIndex = 18;
            rChip5.TabStop = false;
            rChip5.Click += rChip5_Click;
            rChip5.MouseEnter += rChip5_MouseEnter_1;
            rChip5.MouseLeave += rChip5_MouseLeave_1;
            // 
            // actionLog
            // 
            actionLog.AutoSize = true;
            actionLog.Font = new Font("Corbel", 16F, FontStyle.Bold);
            actionLog.ForeColor = Color.White;
            actionLog.Location = new Point(175, 558);
            actionLog.Name = "actionLog";
            actionLog.Size = new Size(130, 27);
            actionLog.TabIndex = 17;
            actionLog.Text = "Action Log : ";
            // 
            // r_totalWinnings
            // 
            r_totalWinnings.AutoSize = true;
            r_totalWinnings.Font = new Font("Corbel", 16F, FontStyle.Bold);
            r_totalWinnings.ForeColor = Color.White;
            r_totalWinnings.Location = new Point(617, 594);
            r_totalWinnings.Name = "r_totalWinnings";
            r_totalWinnings.Size = new Size(168, 27);
            r_totalWinnings.TabIndex = 16;
            r_totalWinnings.Text = "Total Winnings : ";
            // 
            // r_BankRoll
            // 
            r_BankRoll.AutoSize = true;
            r_BankRoll.Font = new Font("Corbel", 16F, FontStyle.Bold);
            r_BankRoll.ForeColor = Color.White;
            r_BankRoll.Location = new Point(617, 558);
            r_BankRoll.Name = "r_BankRoll";
            r_BankRoll.Size = new Size(108, 27);
            r_BankRoll.TabIndex = 15;
            r_BankRoll.Text = "Bankroll : ";
            // 
            // startRound
            // 
            startRound.BackColor = Color.Red;
            startRound.BackgroundImageLayout = ImageLayout.None;
            startRound.FlatAppearance.BorderSize = 0;
            startRound.FlatStyle = FlatStyle.Flat;
            startRound.Font = new Font("Corbel", 12F, FontStyle.Bold);
            startRound.ForeColor = SystemColors.ButtonHighlight;
            startRound.Location = new Point(406, 568);
            startRound.Name = "startRound";
            startRound.Size = new Size(147, 43);
            startRound.TabIndex = 14;
            startRound.Text = "Start Round";
            startRound.UseVisualStyleBackColor = false;
            startRound.Click += button4_Click;
            // 
            // rBet
            // 
            rBet.AutoSize = true;
            rBet.Font = new Font("Corbel", 16F, FontStyle.Bold);
            rBet.ForeColor = Color.Yellow;
            rBet.Location = new Point(334, 380);
            rBet.Name = "rBet";
            rBet.Size = new Size(118, 27);
            rBet.TabIndex = 13;
            rBet.Text = "Round Bet:";
            // 
            // rCardFolded
            // 
            rCardFolded.BackColor = Color.Transparent;
            rCardFolded.Image = (Image)resources.GetObject("rCardFolded.Image");
            rCardFolded.Location = new Point(643, 120);
            rCardFolded.Name = "rCardFolded";
            rCardFolded.Size = new Size(69, 96);
            rCardFolded.SizeMode = PictureBoxSizeMode.StretchImage;
            rCardFolded.TabIndex = 12;
            rCardFolded.TabStop = false;
            rCardFolded.Click += rCardFolded_Click;
            // 
            // hitBtn
            // 
            hitBtn.BackColor = Color.ForestGreen;
            hitBtn.BackgroundImageLayout = ImageLayout.None;
            hitBtn.FlatStyle = FlatStyle.Flat;
            hitBtn.Font = new Font("Corbel", 10F, FontStyle.Bold);
            hitBtn.Location = new Point(643, 407);
            hitBtn.Name = "hitBtn";
            hitBtn.Size = new Size(94, 36);
            hitBtn.TabIndex = 11;
            hitBtn.Text = "HIT";
            hitBtn.UseVisualStyleBackColor = false;
            hitBtn.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Corbel", 10F, FontStyle.Bold);
            button2.Location = new Point(643, 492);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 10;
            button2.Text = "DOUBLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // standBtn
            // 
            standBtn.BackColor = Color.Yellow;
            standBtn.BackgroundImageLayout = ImageLayout.None;
            standBtn.FlatStyle = FlatStyle.Flat;
            standBtn.Font = new Font("Corbel", 10F, FontStyle.Bold);
            standBtn.Location = new Point(643, 450);
            standBtn.Name = "standBtn";
            standBtn.Size = new Size(94, 36);
            standBtn.TabIndex = 9;
            standBtn.Text = "STAND";
            standBtn.UseVisualStyleBackColor = false;
            standBtn.Click += button1_Click;
            // 
            // rDealer4
            // 
            rDealer4.BackColor = Color.Transparent;
            rDealer4.BorderStyle = BorderStyle.Fixed3D;
            rDealer4.Location = new Point(564, 84);
            rDealer4.Name = "rDealer4";
            rDealer4.Size = new Size(69, 96);
            rDealer4.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer4.TabIndex = 8;
            rDealer4.TabStop = false;
            // 
            // botValue
            // 
            botValue.AutoSize = true;
            botValue.Font = new Font("Corbel", 16F, FontStyle.Bold);
            botValue.ForeColor = Color.Yellow;
            botValue.Location = new Point(158, 252);
            botValue.Name = "botValue";
            botValue.Size = new Size(76, 27);
            botValue.TabIndex = 26;
            botValue.Text = "Cards: ";
            // 
            // playerValue
            // 
            playerValue.AutoSize = true;
            playerValue.Font = new Font("Corbel", 16F, FontStyle.Bold);
            playerValue.ForeColor = Color.Yellow;
            playerValue.Location = new Point(158, 279);
            playerValue.Name = "playerValue";
            playerValue.Size = new Size(76, 27);
            playerValue.TabIndex = 27;
            playerValue.Text = "Cards: ";
            // 
            // singaporePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(142, 22, 22);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "singaporePanel";
            Size = new Size(929, 609);
            Load += singaporePanel_Load;
            ((System.ComponentModel.ISupportInitialize)rPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rChip100).EndInit();
            ((System.ComponentModel.ISupportInitialize)rChip50).EndInit();
            ((System.ComponentModel.ISupportInitialize)rChip25).EndInit();
            ((System.ComponentModel.ISupportInitialize)rChip10).EndInit();
            ((System.ComponentModel.ISupportInitialize)rChip1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rChip5).EndInit();
            ((System.ComponentModel.ISupportInitialize)rCardFolded).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox rPlayer1;
        private PictureBox rPlayer2;
        private PictureBox rPlayer3;
        private PictureBox rPlayer4;
        private PictureBox rDealer3;
        private PictureBox rDealer2;
        private PictureBox rDealer1;
        private Panel panel1;
        private PictureBox rDealer4;
        private Button hitBtn;
        private Button button2;
        private Button standBtn;
        private PictureBox rCardFolded;
        private Label rBet;
        private Button startRound;
        private Label r_BankRoll;
        private Label actionLog;
        private Label r_totalWinnings;
        private PictureBox rChip100;
        private PictureBox rChip50;
        private PictureBox rChip25;
        private PictureBox rChip10;
        private PictureBox rChip1;
        private PictureBox rChip5;
        private Button backButton;
        private Label currentRound;
        private Label playerValue;
        private Label botValue;
    }
}
