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
            extMaingameButton = new Button();
            rightButton = new Button();
            leftButton = new Button();
            manilaPicBox = new PictureBox();
            singaporePicBox = new PictureBox();
            hongkongPicBox = new PictureBox();
            topTextCity = new Label();
            cityChooserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manilaPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singaporePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hongkongPicBox).BeginInit();
            SuspendLayout();
            // 
            // cityChooserPanel
            // 
            cityChooserPanel.BackColor = SystemColors.ControlLightLight;
            cityChooserPanel.Controls.Add(cityPanel);
            cityChooserPanel.Controls.Add(extMaingameButton);
            cityChooserPanel.Controls.Add(rightButton);
            cityChooserPanel.Controls.Add(leftButton);
            cityChooserPanel.Controls.Add(manilaPicBox);
            cityChooserPanel.Controls.Add(singaporePicBox);
            cityChooserPanel.Controls.Add(hongkongPicBox);
            cityChooserPanel.Controls.Add(topTextCity);
            cityChooserPanel.Dock = DockStyle.Fill;
            cityChooserPanel.Location = new Point(0, 0);
            cityChooserPanel.Name = "cityChooserPanel";
            cityChooserPanel.Size = new Size(984, 611);
            cityChooserPanel.TabIndex = 0;
            cityChooserPanel.Paint += cityChooserPanel_Paint;
            // 
            // cityPanel
            // 
            cityPanel.BackColor = SystemColors.ControlLightLight;
            cityPanel.Dock = DockStyle.Fill;
            cityPanel.Location = new Point(0, 0);
            cityPanel.Name = "cityPanel";
            cityPanel.Size = new Size(984, 611);
            cityPanel.TabIndex = 5;
            cityPanel.Paint += cityPanel_Paint;
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
            // rightButton
            // 
            rightButton.Location = new Point(523, 504);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(127, 46);
            rightButton.TabIndex = 4;
            rightButton.Text = ">";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // leftButton
            // 
            leftButton.Location = new Point(334, 504);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(127, 46);
            leftButton.TabIndex = 3;
            leftButton.Text = "<";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
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
            // mainGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(cityChooserPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Black Jack Deluxe";
            Load += mainGameForm_Load;
            cityChooserPanel.ResumeLayout(false);
            cityChooserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)manilaPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)singaporePicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hongkongPicBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cityChooserPanel;
        private Button rightButton;
        private Button leftButton;
        private PictureBox manilaPicBox;
        private PictureBox singaporePicBox;
        private PictureBox hongkongPicBox;
        private Panel cityPanel;
        private Button extMaingameButton;
        private Label topTextCity;
    }
}