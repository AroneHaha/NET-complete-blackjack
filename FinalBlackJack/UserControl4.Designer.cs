namespace FinalBlackJack
{
    partial class logPassword
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
            form3Button = new Button();
            panel1 = new Panel();
            adsPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adsPictureBox).BeginInit();
            SuspendLayout();
            // 
            // form3Button
            // 
            form3Button.BackColor = Color.OrangeRed;
            form3Button.Font = new Font("Haettenschweiler", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            form3Button.ForeColor = Color.WhiteSmoke;
            form3Button.Location = new Point(397, 451);
            form3Button.Name = "form3Button";
            form3Button.Size = new Size(179, 56);
            form3Button.TabIndex = 0;
            form3Button.Text = "PLAY NOW";
            form3Button.UseVisualStyleBackColor = false;
            form3Button.Click += form3Button_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(adsPictureBox);
            panel1.Location = new Point(122, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 378);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // adsPictureBox
            // 
            adsPictureBox.BackColor = Color.Ivory;
            adsPictureBox.Location = new Point(0, 0);
            adsPictureBox.Name = "adsPictureBox";
            adsPictureBox.Size = new Size(753, 378);
            adsPictureBox.TabIndex = 0;
            adsPictureBox.TabStop = false;
            adsPictureBox.Click += adsPictureBox_Click;
            // 
            // logPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            Controls.Add(panel1);
            Controls.Add(form3Button);
            ForeColor = Color.DimGray;
            Name = "logPassword";
            Size = new Size(924, 558);
            Load += homeUserOption_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adsPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button form3Button;
        private Panel panel1;
        private PictureBox adsPictureBox;
    }
}
