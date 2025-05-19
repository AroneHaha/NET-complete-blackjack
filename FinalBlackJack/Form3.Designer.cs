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
            rightButton = new Button();
            leftButton = new Button();
            manilaPicBox = new PictureBox();
            singaporePicBox = new PictureBox();
            hongkongPicBox = new PictureBox();
            cityChooserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)manilaPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)singaporePicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hongkongPicBox).BeginInit();
            SuspendLayout();
            // 
            // cityChooserPanel
            // 
            cityChooserPanel.BackColor = Color.Purple;
            cityChooserPanel.Controls.Add(cityPanel);
            cityChooserPanel.Controls.Add(rightButton);
            cityChooserPanel.Controls.Add(leftButton);
            cityChooserPanel.Controls.Add(manilaPicBox);
            cityChooserPanel.Controls.Add(singaporePicBox);
            cityChooserPanel.Controls.Add(hongkongPicBox);
            cityChooserPanel.Dock = DockStyle.Fill;
            cityChooserPanel.Location = new Point(0, 0);
            cityChooserPanel.Name = "cityChooserPanel";
            cityChooserPanel.Size = new Size(984, 611);
            cityChooserPanel.TabIndex = 0;
            cityChooserPanel.Paint += cityChooserPanel_Paint;
            // 
            // cityPanel
            // 
            cityPanel.BackColor = Color.Violet;
            cityPanel.Dock = DockStyle.Fill;
            cityPanel.Location = new Point(0, 0);
            cityPanel.Name = "cityPanel";
            cityPanel.Size = new Size(984, 611);
            cityPanel.TabIndex = 5;
            cityPanel.Paint += cityPanel_Paint;
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
            manilaPicBox.Location = new Point(261, 141);
            manilaPicBox.Name = "manilaPicBox";
            manilaPicBox.Size = new Size(449, 320);
            manilaPicBox.TabIndex = 0;
            manilaPicBox.TabStop = false;
            manilaPicBox.Click += manilaPicBox_Click;
            // 
            // singaporePicBox
            // 
            singaporePicBox.BackColor = Color.DimGray;
            singaporePicBox.Location = new Point(12, 131);
            singaporePicBox.Name = "singaporePicBox";
            singaporePicBox.Size = new Size(449, 320);
            singaporePicBox.TabIndex = 1;
            singaporePicBox.TabStop = false;
            singaporePicBox.Click += singaporePicBox_Click;
            // 
            // hongkongPicBox
            // 
            hongkongPicBox.BackColor = Color.DarkGray;
            hongkongPicBox.Location = new Point(523, 130);
            hongkongPicBox.Name = "hongkongPicBox";
            hongkongPicBox.Size = new Size(449, 320);
            hongkongPicBox.TabIndex = 2;
            hongkongPicBox.TabStop = false;
            hongkongPicBox.Click += hongkongPicBox_Click;
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
    }
}