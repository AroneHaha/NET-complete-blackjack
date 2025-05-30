namespace FinalBlackJack
{
    partial class hongkongPanel
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hongkongPanel));
            exitButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            surrenderPanel = new Panel();
            label12 = new Label();
            yesButton = new Button();
            CancelButton = new Button();
            dealerDialogue = new Label();
            returnAllBet = new PictureBox();
            returnBet = new PictureBox();
            playerDraw4 = new PictureBox();
            playerDraw3 = new PictureBox();
            playerDraw1 = new PictureBox();
            playerDraw2 = new PictureBox();
            dealerDraw4 = new PictureBox();
            dealerDraw3 = new PictureBox();
            dealerDraw1 = new PictureBox();
            dealerDraw2 = new PictureBox();
            playerValue = new Label();
            botValue = new Label();
            currentRound = new Label();
            r25m = new PictureBox();
            r10m = new PictureBox();
            r5m = new PictureBox();
            r1m = new PictureBox();
            r250k = new PictureBox();
            r500k = new PictureBox();
            actionLog = new Label();
            r_totalWinnings = new Label();
            r_BankRoll = new Label();
            startRound = new Button();
            rBet = new Label();
            rCardFolded = new PictureBox();
            hitBtn = new Button();
            doubleBtn = new Button();
            standBtn = new Button();
            rDealer4 = new PictureBox();
            rPlayer4 = new PictureBox();
            rDealer3 = new PictureBox();
            rPlayer3 = new PictureBox();
            rDealer1 = new PictureBox();
            rPlayer2 = new PictureBox();
            rDealer2 = new PictureBox();
            rPlayer1 = new PictureBox();
            initialDraw = new System.Windows.Forms.Timer(components);
            pCardAnimation3 = new System.Windows.Forms.Timer(components);
            pCardAnimation4 = new System.Windows.Forms.Timer(components);
            dCardAnimation3 = new System.Windows.Forms.Timer(components);
            dCardAnimation4 = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            returnTip = new ToolTip(components);
            returnAllTip = new ToolTip(components);
            panel1.SuspendLayout();
            surrenderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)returnAllBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)returnBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r25m).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r10m).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r5m).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r1m).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r250k).BeginInit();
            ((System.ComponentModel.ISupportInitialize)r500k).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rCardFolded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer1).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(17, 17);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(90, 52);
            exitButton.TabIndex = 0;
            exitButton.Text = "button1";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(surrenderPanel);
            panel1.Controls.Add(dealerDialogue);
            panel1.Controls.Add(returnAllBet);
            panel1.Controls.Add(returnBet);
            panel1.Controls.Add(playerDraw4);
            panel1.Controls.Add(playerDraw3);
            panel1.Controls.Add(playerDraw1);
            panel1.Controls.Add(playerDraw2);
            panel1.Controls.Add(dealerDraw4);
            panel1.Controls.Add(dealerDraw3);
            panel1.Controls.Add(dealerDraw1);
            panel1.Controls.Add(dealerDraw2);
            panel1.Controls.Add(playerValue);
            panel1.Controls.Add(botValue);
            panel1.Controls.Add(currentRound);
            panel1.Controls.Add(r25m);
            panel1.Controls.Add(r10m);
            panel1.Controls.Add(r5m);
            panel1.Controls.Add(r1m);
            panel1.Controls.Add(r250k);
            panel1.Controls.Add(r500k);
            panel1.Controls.Add(actionLog);
            panel1.Controls.Add(r_totalWinnings);
            panel1.Controls.Add(r_BankRoll);
            panel1.Controls.Add(startRound);
            panel1.Controls.Add(rBet);
            panel1.Controls.Add(rCardFolded);
            panel1.Controls.Add(hitBtn);
            panel1.Controls.Add(doubleBtn);
            panel1.Controls.Add(standBtn);
            panel1.Controls.Add(rDealer4);
            panel1.Controls.Add(rPlayer4);
            panel1.Controls.Add(rDealer3);
            panel1.Controls.Add(rPlayer3);
            panel1.Controls.Add(rDealer1);
            panel1.Controls.Add(rPlayer2);
            panel1.Controls.Add(rDealer2);
            panel1.Controls.Add(rPlayer1);
            panel1.Location = new Point(5, -51);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 642);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(4, 64);
            button1.Name = "button1";
            button1.Size = new Size(97, 34);
            button1.TabIndex = 42;
            button1.Text = "Leave";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // surrenderPanel
            // 
            surrenderPanel.BackColor = Color.DodgerBlue;
            surrenderPanel.BorderStyle = BorderStyle.FixedSingle;
            surrenderPanel.Controls.Add(label12);
            surrenderPanel.Controls.Add(yesButton);
            surrenderPanel.Controls.Add(CancelButton);
            surrenderPanel.Location = new Point(320, 221);
            surrenderPanel.Name = "surrenderPanel";
            surrenderPanel.Size = new Size(328, 195);
            surrenderPanel.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.FlatStyle = FlatStyle.Popup;
            label12.Font = new Font("Haettenschweiler", 40F);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(56, 40);
            label12.Name = "label12";
            label12.Size = new Size(216, 56);
            label12.TabIndex = 5;
            label12.Text = "Surrender?";
            // 
            // yesButton
            // 
            yesButton.BackColor = Color.Red;
            yesButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            yesButton.Location = new Point(168, 134);
            yesButton.Name = "yesButton";
            yesButton.Size = new Size(92, 32);
            yesButton.TabIndex = 2;
            yesButton.Text = "Concede";
            yesButton.UseVisualStyleBackColor = false;
            yesButton.Click += yesButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Gainsboro;
            CancelButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CancelButton.Location = new Point(67, 135);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(92, 31);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // dealerDialogue
            // 
            dealerDialogue.AutoSize = true;
            dealerDialogue.Font = new Font("Corbel", 16F, FontStyle.Bold | FontStyle.Italic);
            dealerDialogue.ForeColor = Color.Yellow;
            dealerDialogue.Location = new Point(106, 609);
            dealerDialogue.Name = "dealerDialogue";
            dealerDialogue.Size = new Size(92, 27);
            dealerDialogue.TabIndex = 28;
            dealerDialogue.Text = "Dealer : ";
            // 
            // returnAllBet
            // 
            returnAllBet.Cursor = Cursors.Hand;
            returnAllBet.Image = (Image)resources.GetObject("returnAllBet.Image");
            returnAllBet.Location = new Point(335, 490);
            returnAllBet.Name = "returnAllBet";
            returnAllBet.Size = new Size(39, 37);
            returnAllBet.SizeMode = PictureBoxSizeMode.StretchImage;
            returnAllBet.TabIndex = 39;
            returnAllBet.TabStop = false;
            returnAllBet.Click += returnAllBet_Click;
            // 
            // returnBet
            // 
            returnBet.Cursor = Cursors.Hand;
            returnBet.Image = (Image)resources.GetObject("returnBet.Image");
            returnBet.Location = new Point(335, 445);
            returnBet.Name = "returnBet";
            returnBet.Size = new Size(39, 36);
            returnBet.SizeMode = PictureBoxSizeMode.StretchImage;
            returnBet.TabIndex = 38;
            returnBet.TabStop = false;
            returnBet.Click += returnBet_Click;
            // 
            // playerDraw4
            // 
            playerDraw4.BackColor = Color.Transparent;
            playerDraw4.Image = (Image)resources.GetObject("playerDraw4.Image");
            playerDraw4.Location = new Point(656, 150);
            playerDraw4.Name = "playerDraw4";
            playerDraw4.Size = new Size(69, 96);
            playerDraw4.SizeMode = PictureBoxSizeMode.StretchImage;
            playerDraw4.TabIndex = 36;
            playerDraw4.TabStop = false;
            // 
            // playerDraw3
            // 
            playerDraw3.BackColor = Color.Transparent;
            playerDraw3.Image = (Image)resources.GetObject("playerDraw3.Image");
            playerDraw3.Location = new Point(656, 150);
            playerDraw3.Name = "playerDraw3";
            playerDraw3.Size = new Size(69, 96);
            playerDraw3.SizeMode = PictureBoxSizeMode.StretchImage;
            playerDraw3.TabIndex = 35;
            playerDraw3.TabStop = false;
            // 
            // playerDraw1
            // 
            playerDraw1.BackColor = Color.Transparent;
            playerDraw1.Image = (Image)resources.GetObject("playerDraw1.Image");
            playerDraw1.Location = new Point(656, 150);
            playerDraw1.Name = "playerDraw1";
            playerDraw1.Size = new Size(69, 96);
            playerDraw1.SizeMode = PictureBoxSizeMode.StretchImage;
            playerDraw1.TabIndex = 34;
            playerDraw1.TabStop = false;
            // 
            // playerDraw2
            // 
            playerDraw2.BackColor = Color.Transparent;
            playerDraw2.Image = (Image)resources.GetObject("playerDraw2.Image");
            playerDraw2.Location = new Point(656, 150);
            playerDraw2.Name = "playerDraw2";
            playerDraw2.Size = new Size(69, 96);
            playerDraw2.SizeMode = PictureBoxSizeMode.StretchImage;
            playerDraw2.TabIndex = 33;
            playerDraw2.TabStop = false;
            // 
            // dealerDraw4
            // 
            dealerDraw4.BackColor = Color.Transparent;
            dealerDraw4.Image = (Image)resources.GetObject("dealerDraw4.Image");
            dealerDraw4.Location = new Point(656, 150);
            dealerDraw4.Name = "dealerDraw4";
            dealerDraw4.Size = new Size(69, 96);
            dealerDraw4.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerDraw4.TabIndex = 32;
            dealerDraw4.TabStop = false;
            // 
            // dealerDraw3
            // 
            dealerDraw3.BackColor = Color.Transparent;
            dealerDraw3.Image = (Image)resources.GetObject("dealerDraw3.Image");
            dealerDraw3.Location = new Point(656, 150);
            dealerDraw3.Name = "dealerDraw3";
            dealerDraw3.Size = new Size(69, 96);
            dealerDraw3.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerDraw3.TabIndex = 31;
            dealerDraw3.TabStop = false;
            // 
            // dealerDraw1
            // 
            dealerDraw1.BackColor = Color.Transparent;
            dealerDraw1.Image = (Image)resources.GetObject("dealerDraw1.Image");
            dealerDraw1.Location = new Point(656, 150);
            dealerDraw1.Name = "dealerDraw1";
            dealerDraw1.Size = new Size(69, 96);
            dealerDraw1.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerDraw1.TabIndex = 30;
            dealerDraw1.TabStop = false;
            // 
            // dealerDraw2
            // 
            dealerDraw2.BackColor = Color.Transparent;
            dealerDraw2.Image = (Image)resources.GetObject("dealerDraw2.Image");
            dealerDraw2.Location = new Point(656, 150);
            dealerDraw2.Name = "dealerDraw2";
            dealerDraw2.Size = new Size(69, 96);
            dealerDraw2.SizeMode = PictureBoxSizeMode.StretchImage;
            dealerDraw2.TabIndex = 29;
            dealerDraw2.TabStop = false;
            // 
            // playerValue
            // 
            playerValue.AutoSize = true;
            playerValue.Font = new Font("Corbel", 16F, FontStyle.Bold);
            playerValue.ForeColor = Color.White;
            playerValue.Location = new Point(649, 387);
            playerValue.Name = "playerValue";
            playerValue.Size = new Size(76, 27);
            playerValue.TabIndex = 27;
            playerValue.Text = "Cards: ";
            // 
            // botValue
            // 
            botValue.AutoSize = true;
            botValue.Font = new Font("Corbel", 16F, FontStyle.Bold);
            botValue.ForeColor = Color.White;
            botValue.Location = new Point(649, 251);
            botValue.Name = "botValue";
            botValue.Size = new Size(76, 27);
            botValue.TabIndex = 26;
            botValue.Text = "Cards: ";
            // 
            // currentRound
            // 
            currentRound.AutoSize = true;
            currentRound.Font = new Font("Corbel", 16F, FontStyle.Bold);
            currentRound.ForeColor = Color.White;
            currentRound.Location = new Point(334, 364);
            currentRound.Name = "currentRound";
            currentRound.Size = new Size(90, 27);
            currentRound.TabIndex = 25;
            currentRound.Text = "Round : ";
            // 
            // r25m
            // 
            r25m.BackColor = Color.Transparent;
            r25m.Cursor = Cursors.Hand;
            r25m.Image = (Image)resources.GetObject("r25m.Image");
            r25m.Location = new Point(126, 387);
            r25m.Name = "r25m";
            r25m.Size = new Size(60, 60);
            r25m.SizeMode = PictureBoxSizeMode.StretchImage;
            r25m.TabIndex = 23;
            r25m.TabStop = false;
            r25m.Click += rChip100_Click;
            r25m.MouseEnter += rChip30k_MouseEnter;
            r25m.MouseLeave += rChip30k_MouseLeave;
            // 
            // r10m
            // 
            r10m.BackColor = Color.Transparent;
            r10m.Cursor = Cursors.Hand;
            r10m.Image = (Image)resources.GetObject("r10m.Image");
            r10m.Location = new Point(192, 406);
            r10m.Name = "r10m";
            r10m.Size = new Size(60, 60);
            r10m.SizeMode = PictureBoxSizeMode.StretchImage;
            r10m.TabIndex = 22;
            r10m.TabStop = false;
            r10m.Click += rChip50_Click;
            r10m.MouseEnter += rChip20k_MouseEnter;
            r10m.MouseLeave += rChip20k_MouseLeave;
            // 
            // r5m
            // 
            r5m.BackColor = Color.Transparent;
            r5m.Cursor = Cursors.Hand;
            r5m.Image = (Image)resources.GetObject("r5m.Image");
            r5m.Location = new Point(258, 408);
            r5m.Name = "r5m";
            r5m.Size = new Size(60, 60);
            r5m.SizeMode = PictureBoxSizeMode.StretchImage;
            r5m.TabIndex = 21;
            r5m.TabStop = false;
            r5m.Click += rChip25_Click;
            r5m.MouseEnter += rChip10k_MouseEnter;
            r5m.MouseLeave += rChip10k_MouseLeave;
            // 
            // r1m
            // 
            r1m.BackColor = Color.Transparent;
            r1m.Cursor = Cursors.Hand;
            r1m.Image = (Image)resources.GetObject("r1m.Image");
            r1m.Location = new Point(126, 456);
            r1m.Name = "r1m";
            r1m.Size = new Size(60, 60);
            r1m.SizeMode = PictureBoxSizeMode.StretchImage;
            r1m.TabIndex = 20;
            r1m.TabStop = false;
            r1m.Click += rChip10_Click;
            r1m.MouseEnter += rChip5k_MouseEnter;
            r1m.MouseLeave += rChip5k_MouseLeave;
            // 
            // r250k
            // 
            r250k.BackColor = Color.Transparent;
            r250k.Cursor = Cursors.Hand;
            r250k.Image = (Image)resources.GetObject("r250k.Image");
            r250k.Location = new Point(258, 477);
            r250k.Name = "r250k";
            r250k.Size = new Size(60, 60);
            r250k.SizeMode = PictureBoxSizeMode.StretchImage;
            r250k.TabIndex = 19;
            r250k.TabStop = false;
            r250k.Click += rChip1_Click;
            r250k.MouseEnter += rChip1_MouseEnter;
            r250k.MouseLeave += rChip1k_MouseLeave;
            // 
            // r500k
            // 
            r500k.BackColor = Color.Transparent;
            r500k.Cursor = Cursors.Hand;
            r500k.Image = (Image)resources.GetObject("r500k.Image");
            r500k.Location = new Point(192, 477);
            r500k.Name = "r500k";
            r500k.Size = new Size(60, 60);
            r500k.SizeMode = PictureBoxSizeMode.StretchImage;
            r500k.TabIndex = 18;
            r500k.TabStop = false;
            r500k.Click += rChip5_Click;
            r500k.MouseEnter += rChip2p5_MouseEnter;
            r500k.MouseLeave += rChip2p5_MouseLeave;
            // 
            // actionLog
            // 
            actionLog.AutoSize = true;
            actionLog.Font = new Font("Corbel", 16F, FontStyle.Bold);
            actionLog.ForeColor = Color.White;
            actionLog.Location = new Point(106, 582);
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
            r_totalWinnings.Location = new Point(631, 614);
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
            r_BankRoll.Location = new Point(631, 585);
            r_BankRoll.Name = "r_BankRoll";
            r_BankRoll.Size = new Size(108, 27);
            r_BankRoll.TabIndex = 15;
            r_BankRoll.Text = "Bankroll : ";
            // 
            // startRound
            // 
            startRound.BackColor = Color.DimGray;
            startRound.BackgroundImageLayout = ImageLayout.None;
            startRound.Enabled = false;
            startRound.FlatAppearance.BorderSize = 0;
            startRound.Font = new Font("Corbel", 12F, FontStyle.Bold);
            startRound.ForeColor = SystemColors.ButtonHighlight;
            startRound.Location = new Point(406, 596);
            startRound.Name = "startRound";
            startRound.Size = new Size(147, 43);
            startRound.TabIndex = 14;
            startRound.Text = "Start Round";
            startRound.UseVisualStyleBackColor = false;
            startRound.Click += startRound_Click;
            // 
            // rBet
            // 
            rBet.AutoSize = true;
            rBet.Font = new Font("Corbel", 16F, FontStyle.Bold);
            rBet.ForeColor = Color.Yellow;
            rBet.Location = new Point(334, 395);
            rBet.Name = "rBet";
            rBet.Size = new Size(134, 27);
            rBet.TabIndex = 13;
            rBet.Text = "Round Bet: 0";
            // 
            // rCardFolded
            // 
            rCardFolded.BackColor = Color.Transparent;
            rCardFolded.Image = (Image)resources.GetObject("rCardFolded.Image");
            rCardFolded.Location = new Point(656, 150);
            rCardFolded.Name = "rCardFolded";
            rCardFolded.Size = new Size(69, 96);
            rCardFolded.SizeMode = PictureBoxSizeMode.StretchImage;
            rCardFolded.TabIndex = 12;
            rCardFolded.TabStop = false;
            // 
            // hitBtn
            // 
            hitBtn.BackColor = Color.DimGray;
            hitBtn.BackgroundImageLayout = ImageLayout.None;
            hitBtn.Enabled = false;
            hitBtn.Font = new Font("Corbel", 10F, FontStyle.Bold);
            hitBtn.Location = new Point(645, 424);
            hitBtn.Name = "hitBtn";
            hitBtn.Size = new Size(94, 36);
            hitBtn.TabIndex = 11;
            hitBtn.Text = "HIT";
            hitBtn.UseVisualStyleBackColor = false;
            hitBtn.Click += hitBtn_Click;
            // 
            // doubleBtn
            // 
            doubleBtn.BackColor = Color.DimGray;
            doubleBtn.BackgroundImageLayout = ImageLayout.None;
            doubleBtn.Enabled = false;
            doubleBtn.Font = new Font("Corbel", 10F, FontStyle.Bold);
            doubleBtn.Location = new Point(645, 509);
            doubleBtn.Name = "doubleBtn";
            doubleBtn.Size = new Size(94, 36);
            doubleBtn.TabIndex = 10;
            doubleBtn.Text = "DOUBLE";
            doubleBtn.UseVisualStyleBackColor = false;
            doubleBtn.Click += doubleBtn_Click;
            // 
            // standBtn
            // 
            standBtn.BackColor = Color.DimGray;
            standBtn.BackgroundImageLayout = ImageLayout.None;
            standBtn.Enabled = false;
            standBtn.Font = new Font("Corbel", 10F, FontStyle.Bold);
            standBtn.Location = new Point(645, 467);
            standBtn.Name = "standBtn";
            standBtn.Size = new Size(94, 36);
            standBtn.TabIndex = 9;
            standBtn.Text = "STAND";
            standBtn.UseVisualStyleBackColor = false;
            standBtn.Click += standBtn_Click;
            // 
            // rDealer4
            // 
            rDealer4.BackColor = Color.Transparent;
            rDealer4.Location = new Point(562, 110);
            rDealer4.Name = "rDealer4";
            rDealer4.Size = new Size(69, 96);
            rDealer4.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer4.TabIndex = 8;
            rDealer4.TabStop = false;
            // 
            // rPlayer4
            // 
            rPlayer4.BackColor = Color.Transparent;
            rPlayer4.Location = new Point(561, 437);
            rPlayer4.Name = "rPlayer4";
            rPlayer4.Size = new Size(69, 96);
            rPlayer4.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer4.TabIndex = 3;
            rPlayer4.TabStop = false;
            // 
            // rDealer3
            // 
            rDealer3.BackColor = Color.Transparent;
            rDealer3.Location = new Point(487, 110);
            rDealer3.Name = "rDealer3";
            rDealer3.Size = new Size(69, 96);
            rDealer3.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer3.TabIndex = 7;
            rDealer3.TabStop = false;
            // 
            // rPlayer3
            // 
            rPlayer3.BackColor = Color.Transparent;
            rPlayer3.Location = new Point(486, 437);
            rPlayer3.Name = "rPlayer3";
            rPlayer3.Size = new Size(69, 96);
            rPlayer3.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer3.TabIndex = 2;
            rPlayer3.TabStop = false;
            // 
            // rDealer1
            // 
            rDealer1.BackColor = Color.Transparent;
            rDealer1.Location = new Point(337, 110);
            rDealer1.Name = "rDealer1";
            rDealer1.Size = new Size(69, 96);
            rDealer1.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer1.TabIndex = 5;
            rDealer1.TabStop = false;
            // 
            // rPlayer2
            // 
            rPlayer2.BackColor = Color.Transparent;
            rPlayer2.Location = new Point(411, 437);
            rPlayer2.Name = "rPlayer2";
            rPlayer2.Size = new Size(69, 96);
            rPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer2.TabIndex = 1;
            rPlayer2.TabStop = false;
            // 
            // rDealer2
            // 
            rDealer2.BackColor = Color.Transparent;
            rDealer2.Location = new Point(412, 110);
            rDealer2.Name = "rDealer2";
            rDealer2.Size = new Size(69, 96);
            rDealer2.SizeMode = PictureBoxSizeMode.StretchImage;
            rDealer2.TabIndex = 6;
            rDealer2.TabStop = false;
            // 
            // rPlayer1
            // 
            rPlayer1.BackColor = Color.Transparent;
            rPlayer1.Location = new Point(336, 437);
            rPlayer1.Name = "rPlayer1";
            rPlayer1.Size = new Size(69, 96);
            rPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            rPlayer1.TabIndex = 0;
            rPlayer1.TabStop = false;
            // 
            // initialDraw
            // 
            initialDraw.Interval = 2;
            initialDraw.Tick += initialDraw_Tick;
            // 
            // pCardAnimation3
            // 
            pCardAnimation3.Interval = 2;
            pCardAnimation3.Tick += pCardAnimation3_Tick;
            // 
            // pCardAnimation4
            // 
            pCardAnimation4.Interval = 2;
            pCardAnimation4.Tick += pCardAnimation4_Tick;
            // 
            // dCardAnimation3
            // 
            dCardAnimation3.Interval = 2;
            dCardAnimation3.Tick += dCardAnimation3_Tick;
            // 
            // dCardAnimation4
            // 
            dCardAnimation4.Interval = 2;
            dCardAnimation4.Tick += dCardAnimation4_Tick;
            // 
            // timer1
            // 
            timer1.Interval = 5;
            // 
            // returnTip
            // 
            returnTip.Popup += returnTip_Popup;
            // 
            // returnAllTip
            // 
            returnAllTip.Popup += returnAllTip_Popup;
            // 
            // hongkongPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(exitButton);
            DoubleBuffered = true;
            Name = "hongkongPanel";
            Size = new Size(929, 611);
            Load += hongkongPanel_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            surrenderPanel.ResumeLayout(false);
            surrenderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)returnAllBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)returnBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw4).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw3).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerDraw2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerDraw2).EndInit();
            ((System.ComponentModel.ISupportInitialize)r25m).EndInit();
            ((System.ComponentModel.ISupportInitialize)r10m).EndInit();
            ((System.ComponentModel.ISupportInitialize)r5m).EndInit();
            ((System.ComponentModel.ISupportInitialize)r1m).EndInit();
            ((System.ComponentModel.ISupportInitialize)r250k).EndInit();
            ((System.ComponentModel.ISupportInitialize)r500k).EndInit();
            ((System.ComponentModel.ISupportInitialize)rCardFolded).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer4).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer3).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)rPlayer1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private Panel panel1;
        private PictureBox returnAllBet;
        private PictureBox returnBet;
        private PictureBox playerDraw4;
        private PictureBox playerDraw3;
        private PictureBox playerDraw1;
        private PictureBox playerDraw2;
        private PictureBox dealerDraw4;
        private PictureBox dealerDraw3;
        private PictureBox dealerDraw1;
        private PictureBox dealerDraw2;
        private Label playerValue;
        private Label botValue;
        private Label currentRound;
        private PictureBox r25m;
        private PictureBox r10m;
        private PictureBox r5m;
        private PictureBox r1m;
        private PictureBox r250k;
        private PictureBox r500k;
        private Label actionLog;
        private Label r_totalWinnings;
        private Label r_BankRoll;
        private Button startRound;
        private Label rBet;
        private PictureBox rCardFolded;
        private Button hitBtn;
        private Button doubleBtn;
        private Button standBtn;
        private PictureBox rDealer4;
        private PictureBox rPlayer4;
        private PictureBox rDealer3;
        private PictureBox rPlayer3;
        private PictureBox rDealer1;
        private PictureBox rPlayer2;
        private PictureBox rDealer2;
        private PictureBox rPlayer1;
        private System.Windows.Forms.Timer initialDraw;
        private System.Windows.Forms.Timer pCardAnimation3;
        private System.Windows.Forms.Timer pCardAnimation4;
        private System.Windows.Forms.Timer dCardAnimation3;
        private System.Windows.Forms.Timer dCardAnimation4;
        private System.Windows.Forms.Timer timer1;
        private ToolTip returnTip;
        private ToolTip returnAllTip;
        private Label dealerDialogue;
        private Panel surrenderPanel;
        private Button yesButton;
        private Button CancelButton;
        private Label label12;
        private Button button1;
    }
}
