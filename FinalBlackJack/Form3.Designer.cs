namespace FinalBlackJack
{
    partial class mainGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGameForm));
            cityChooserPanel = new Panel();
            cityPanel = new Panel();
            transactionPanel = new Panel();
            cancelBuyinButton = new Button();
            buyinTotalBalance = new Label();
            label2 = new Label();
            walletBalance = new Label();
            playTableButton = new Button();
            buyinAmount = new TextBox();
            label1 = new Label();
            extMaingameButton = new Button();
            manilaPicBox = new PictureBox();
            singaporePicBox = new PictureBox();
            hongkongPicBox = new PictureBox();
            topTextCity = new Label();
            left = new PictureBox();
            right = new PictureBox();
            cityChooserPanel.SuspendLayout();
            transactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manilaPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singaporePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hongkongPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)right).BeginInit();
            SuspendLayout();
            // 
            // cityChooserPanel
            // 
            cityChooserPanel.BackColor = SystemColors.ControlLightLight;
            cityChooserPanel.Controls.Add(cityPanel);
            cityChooserPanel.Controls.Add(transactionPanel);
            cityChooserPanel.Controls.Add(extMaingameButton);
            cityChooserPanel.Controls.Add(manilaPicBox);
            cityChooserPanel.Controls.Add(singaporePicBox);
            cityChooserPanel.Controls.Add(hongkongPicBox);
            cityChooserPanel.Controls.Add(topTextCity);
            cityChooserPanel.Controls.Add(left);
            cityChooserPanel.Controls.Add(right);
            cityChooserPanel.Dock = DockStyle.Fill;
            cityChooserPanel.Location = new Point(0, 0);
            cityChooserPanel.Name = "cityChooserPanel";
            cityChooserPanel.Size = new Size(984, 636);
            cityChooserPanel.TabIndex = 0;
            cityChooserPanel.Paint += cityChooserPanel_Paint;
            // 
            // cityPanel
            // 
            cityPanel.BackColor = SystemColors.ControlLightLight;
            cityPanel.Dock = DockStyle.Fill;
            cityPanel.Location = new Point(0, 0);
            cityPanel.Name = "cityPanel";
            cityPanel.Size = new Size(984, 636);
            cityPanel.TabIndex = 5;
            cityPanel.Paint += cityPanel_Paint;
            // 
            // transactionPanel
            // 
            transactionPanel.BackColor = Color.RoyalBlue;
            transactionPanel.Controls.Add(cancelBuyinButton);
            transactionPanel.Controls.Add(buyinTotalBalance);
            transactionPanel.Controls.Add(label2);
            transactionPanel.Controls.Add(walletBalance);
            transactionPanel.Controls.Add(playTableButton);
            transactionPanel.Controls.Add(buyinAmount);
            transactionPanel.Controls.Add(label1);
            transactionPanel.Location = new Point(245, 162);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(511, 327);
            transactionPanel.TabIndex = 8;
            // 
            // cancelBuyinButton
            // 
            cancelBuyinButton.BackColor = Color.Red;
            cancelBuyinButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cancelBuyinButton.ForeColor = Color.White;
            cancelBuyinButton.Location = new Point(141, 261);
            cancelBuyinButton.Name = "cancelBuyinButton";
            cancelBuyinButton.Size = new Size(118, 38);
            cancelBuyinButton.TabIndex = 8;
            cancelBuyinButton.Text = "Cancel";
            cancelBuyinButton.UseVisualStyleBackColor = false;
            cancelBuyinButton.Click += button1_Click_1;
            // 
            // buyinTotalBalance
            // 
            buyinTotalBalance.AutoSize = true;
            buyinTotalBalance.Font = new Font("Segoe UI", 17F);
            buyinTotalBalance.ForeColor = Color.White;
            buyinTotalBalance.Location = new Point(231, 138);
            buyinTotalBalance.Name = "buyinTotalBalance";
            buyinTotalBalance.Size = new Size(72, 31);
            buyinTotalBalance.TabIndex = 7;
            buyinTotalBalance.Text = "Php 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 187);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 6;
            label2.Text = "Buy-in Amount :";
            // 
            // walletBalance
            // 
            walletBalance.AutoSize = true;
            walletBalance.Font = new Font("Segoe UI", 17F);
            walletBalance.ForeColor = Color.White;
            walletBalance.Location = new Point(76, 138);
            walletBalance.Name = "walletBalance";
            walletBalance.Size = new Size(165, 31);
            walletBalance.TabIndex = 5;
            walletBalance.Text = "Total Balance : ";
            // 
            // playTableButton
            // 
            playTableButton.BackColor = Color.MidnightBlue;
            playTableButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            playTableButton.ForeColor = Color.White;
            playTableButton.Location = new Point(265, 261);
            playTableButton.Name = "playTableButton";
            playTableButton.Size = new Size(118, 38);
            playTableButton.TabIndex = 4;
            playTableButton.Text = "Confirm";
            playTableButton.UseVisualStyleBackColor = false;
            playTableButton.Click += depositButton_Click;
            // 
            // buyinAmount
            // 
            buyinAmount.Location = new Point(231, 193);
            buyinAmount.Name = "buyinAmount";
            buyinAmount.Size = new Size(212, 23);
            buyinAmount.TabIndex = 3;
            buyinAmount.TextChanged += buyinAmount_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 45F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(157, 28);
            label1.Name = "label1";
            label1.Size = new Size(214, 62);
            label1.TabIndex = 2;
            label1.Text = "My Wallet";
            // 
            // extMaingameButton
            // 
            extMaingameButton.Location = new Point(830, 541);
            extMaingameButton.Name = "extMaingameButton";
            extMaingameButton.Size = new Size(75, 23);
            extMaingameButton.TabIndex = 6;
            extMaingameButton.Text = "Home";
            extMaingameButton.UseVisualStyleBackColor = true;
            extMaingameButton.Click += extMaingameButton_Click;
            // 
            // manilaPicBox
            // 
            manilaPicBox.BackColor = Color.Black;
            manilaPicBox.Image = (Image)resources.GetObject("manilaPicBox.Image");
            manilaPicBox.Location = new Point(261, 141);
            manilaPicBox.Name = "manilaPicBox";
            manilaPicBox.Size = new Size(449, 320);
            manilaPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            manilaPicBox.TabIndex = 0;
            manilaPicBox.TabStop = false;
            manilaPicBox.Click += manilaPicBox_Click;
            // 
            // singaporePicBox
            // 
            singaporePicBox.BackColor = Color.DimGray;
            singaporePicBox.ErrorImage = null;
            singaporePicBox.Image = (Image)resources.GetObject("singaporePicBox.Image");
            singaporePicBox.Location = new Point(12, 131);
            singaporePicBox.Name = "singaporePicBox";
            singaporePicBox.Size = new Size(449, 320);
            singaporePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            singaporePicBox.TabIndex = 1;
            singaporePicBox.TabStop = false;
            singaporePicBox.Click += singaporePicBox_Click;
            // 
            // hongkongPicBox
            // 
            hongkongPicBox.BackColor = Color.DarkGray;
            hongkongPicBox.Image = (Image)resources.GetObject("hongkongPicBox.Image");
            hongkongPicBox.Location = new Point(523, 130);
            hongkongPicBox.Name = "hongkongPicBox";
            hongkongPicBox.Size = new Size(449, 320);
            hongkongPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            hongkongPicBox.TabIndex = 2;
            hongkongPicBox.TabStop = false;
            hongkongPicBox.Click += hongkongPicBox_Click;
            // 
            // topTextCity
            // 
            topTextCity.AutoSize = true;
            topTextCity.Font = new Font("Segoe UI", 50F);
            topTextCity.Location = new Point(100, 9);
            topTextCity.Name = "topTextCity";
            topTextCity.Size = new Size(214, 89);
            topTextCity.TabIndex = 7;
            topTextCity.Text = "label1";
            topTextCity.TextAlign = ContentAlignment.TopCenter;
            // 
            // left
            // 
            left.BackColor = Color.Transparent;
            left.Image = (Image)resources.GetObject("left.Image");
            left.Location = new Point(383, 509);
            left.Name = "left";
            left.Size = new Size(78, 74);
            left.SizeMode = PictureBoxSizeMode.StretchImage;
            left.TabIndex = 9;
            left.TabStop = false;
            left.Click += pictureBox1_Click;
            left.MouseEnter += pictureBox1_MouseEnter;
            left.MouseLeave += left_MouseLeave;
            // 
            // right
            // 
            right.BackColor = Color.Transparent;
            right.Image = (Image)resources.GetObject("right.Image");
            right.Location = new Point(523, 509);
            right.Name = "right";
            right.Size = new Size(78, 74);
            right.SizeMode = PictureBoxSizeMode.StretchImage;
            right.TabIndex = 10;
            right.TabStop = false;
            right.Click += pictureBox2_Click;
            right.MouseEnter += right_MouseEnter;
            right.MouseLeave += right_MouseLeave;
            // 
            // mainGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 636);
            Controls.Add(cityChooserPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Black Jack Deluxe";
            Load += mainGameForm_Load;
            cityChooserPanel.ResumeLayout(false);
            cityChooserPanel.PerformLayout();
            transactionPanel.ResumeLayout(false);
            transactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manilaPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)singaporePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hongkongPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)left).EndInit();
            ((System.ComponentModel.ISupportInitialize)right).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cityChooserPanel;
        private PictureBox manilaPicBox;
        private PictureBox singaporePicBox;
        private PictureBox hongkongPicBox;
        private Panel cityPanel;
        private Button extMaingameButton;
        private Label topTextCity;
        private Panel transactionPanel;
        private Label label1;
        private Button playTableButton;
        private Label label2;
        private Label walletBalance;
        private Label buyinTotalBalance;
        private Button cancelBuyinButton;
        public TextBox buyinAmount;
        private PictureBox right;
        private PictureBox left;
    }
}