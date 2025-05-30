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
            TopTextCity3 = new Label();
            TopTextCity2 = new Label();
            cityPanel = new Panel();
            transactionPanel = new Panel();
            panel1 = new Panel();
            buyinAmount = new TextBox();
            cancelBuyinButton = new Button();
            label1 = new Label();
            playTableButton = new Button();
            label2 = new Label();
            buyinTotalBalance = new Label();
            walletBalance = new Label();
            extMaingameButton = new Button();
            manilaPicBox = new PictureBox();
            singaporePicBox = new PictureBox();
            hongkongPicBox = new PictureBox();
            topTextCity = new Label();
            left = new PictureBox();
            right = new PictureBox();
            cityChooserPanel.SuspendLayout();
            transactionPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            cityChooserPanel.Controls.Add(TopTextCity3);
            cityChooserPanel.Controls.Add(TopTextCity2);
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
            // TopTextCity3
            // 
            TopTextCity3.AutoSize = true;
            TopTextCity3.BackColor = Color.Transparent;
            TopTextCity3.Font = new Font("Haettenschweiler", 55F);
            TopTextCity3.ForeColor = Color.White;
            TopTextCity3.Location = new Point(259, 62);
            TopTextCity3.Name = "TopTextCity3";
            TopTextCity3.Size = new Size(484, 77);
            TopTextCity3.TabIndex = 12;
            TopTextCity3.Text = "Cobact Club of Doom";
            TopTextCity3.TextAlign = ContentAlignment.TopCenter;
            TopTextCity3.Click += TopTextCity3_Click;
            // 
            // TopTextCity2
            // 
            TopTextCity2.AutoSize = true;
            TopTextCity2.BackColor = Color.Transparent;
            TopTextCity2.Font = new Font("Haettenschweiler", 55F);
            TopTextCity2.ForeColor = Color.White;
            TopTextCity2.Location = new Point(180, 62);
            TopTextCity2.Name = "TopTextCity2";
            TopTextCity2.Size = new Size(640, 77);
            TopTextCity2.TabIndex = 11;
            TopTextCity2.Text = "Obi Wan Castle In Shangrila";
            TopTextCity2.TextAlign = ContentAlignment.TopCenter;
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
            transactionPanel.Controls.Add(panel1);
            transactionPanel.Location = new Point(245, 162);
            transactionPanel.Name = "transactionPanel";
            transactionPanel.Size = new Size(511, 327);
            transactionPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(buyinAmount);
            panel1.Controls.Add(cancelBuyinButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(playTableButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buyinTotalBalance);
            panel1.Controls.Add(walletBalance);
            panel1.Location = new Point(34, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(445, 271);
            panel1.TabIndex = 9;
            // 
            // buyinAmount
            // 
            buyinAmount.Location = new Point(216, 150);
            buyinAmount.Name = "buyinAmount";
            buyinAmount.Size = new Size(189, 23);
            buyinAmount.TabIndex = 3;
            buyinAmount.TextChanged += buyinAmount_TextChanged;
            // 
            // cancelBuyinButton
            // 
            cancelBuyinButton.BackColor = Color.Red;
            cancelBuyinButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            cancelBuyinButton.ForeColor = Color.White;
            cancelBuyinButton.Location = new Point(101, 208);
            cancelBuyinButton.Name = "cancelBuyinButton";
            cancelBuyinButton.Size = new Size(118, 38);
            cancelBuyinButton.TabIndex = 8;
            cancelBuyinButton.Text = "Cancel";
            cancelBuyinButton.UseVisualStyleBackColor = false;
            cancelBuyinButton.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 45F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(122, 18);
            label1.Name = "label1";
            label1.Size = new Size(214, 62);
            label1.TabIndex = 2;
            label1.Text = "My Wallet";
            // 
            // playTableButton
            // 
            playTableButton.BackColor = Color.MidnightBlue;
            playTableButton.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            playTableButton.ForeColor = Color.White;
            playTableButton.Location = new Point(225, 208);
            playTableButton.Name = "playTableButton";
            playTableButton.Size = new Size(118, 38);
            playTableButton.TabIndex = 4;
            playTableButton.Text = "Confirm";
            playTableButton.UseVisualStyleBackColor = false;
            playTableButton.Click += depositButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 144);
            label2.Name = "label2";
            label2.Size = new Size(175, 31);
            label2.TabIndex = 6;
            label2.Text = "Buy-in amount :";
            // 
            // buyinTotalBalance
            // 
            buyinTotalBalance.AutoSize = true;
            buyinTotalBalance.Font = new Font("Segoe UI", 17F);
            buyinTotalBalance.ForeColor = Color.White;
            buyinTotalBalance.Location = new Point(214, 107);
            buyinTotalBalance.Name = "buyinTotalBalance";
            buyinTotalBalance.Size = new Size(72, 31);
            buyinTotalBalance.TabIndex = 7;
            buyinTotalBalance.Text = "Php 0";
            // 
            // walletBalance
            // 
            walletBalance.AutoSize = true;
            walletBalance.Font = new Font("Segoe UI", 17F);
            walletBalance.ForeColor = Color.White;
            walletBalance.Location = new Point(53, 106);
            walletBalance.Name = "walletBalance";
            walletBalance.Size = new Size(165, 31);
            walletBalance.TabIndex = 5;
            walletBalance.Text = "Total Balance : ";
            // 
            // extMaingameButton
            // 
            extMaingameButton.BackColor = Color.Red;
            extMaingameButton.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            extMaingameButton.Location = new Point(22, 15);
            extMaingameButton.Name = "extMaingameButton";
            extMaingameButton.Size = new Size(53, 43);
            extMaingameButton.TabIndex = 6;
            extMaingameButton.Text = "<";
            extMaingameButton.TextAlign = ContentAlignment.TopCenter;
            extMaingameButton.UseVisualStyleBackColor = false;
            extMaingameButton.Click += extMaingameButton_Click;
            // 
            // manilaPicBox
            // 
            manilaPicBox.BackColor = Color.Black;
            manilaPicBox.Cursor = Cursors.Hand;
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
            singaporePicBox.Cursor = Cursors.Hand;
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
            hongkongPicBox.Cursor = Cursors.Hand;
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
            topTextCity.BackColor = Color.Transparent;
            topTextCity.Font = new Font("Haettenschweiler", 55F);
            topTextCity.ForeColor = Color.White;
            topTextCity.Location = new Point(160, 62);
            topTextCity.Name = "topTextCity";
            topTextCity.Size = new Size(692, 77);
            topTextCity.TabIndex = 7;
            topTextCity.Text = "Sahara Grand Pavilion Resort";
            topTextCity.TextAlign = ContentAlignment.TopCenter;
            topTextCity.Click += topTextCity_Click;
            // 
            // left
            // 
            left.BackColor = Color.Transparent;
            left.Image = (Image)resources.GetObject("left.Image");
            left.Location = new Point(375, 520);
            left.Name = "left";
            left.Size = new Size(66, 55);
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
            right.Location = new Point(537, 520);
            right.Name = "right";
            right.Size = new Size(66, 55);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label TopTextCity2;
        private Label TopTextCity3;
    }
}