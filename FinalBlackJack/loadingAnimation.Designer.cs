namespace FinalBlackJack
{
    partial class loadingAnimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingAnimation));
            cityLoadingPanel = new Panel();
            label2 = new Label();
            label1 = new Label();
            hourGlassPic = new PictureBox();
            cityLoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hourGlassPic).BeginInit();
            SuspendLayout();
            // 
            // cityLoadingPanel
            // 
            cityLoadingPanel.BackColor = Color.Black;
            cityLoadingPanel.Controls.Add(label2);
            cityLoadingPanel.Controls.Add(label1);
            cityLoadingPanel.Controls.Add(hourGlassPic);
            cityLoadingPanel.Dock = DockStyle.Fill;
            cityLoadingPanel.Location = new Point(0, 0);
            cityLoadingPanel.Name = "cityLoadingPanel";
            cityLoadingPanel.Size = new Size(1000, 650);
            cityLoadingPanel.TabIndex = 0;
            cityLoadingPanel.Paint += cityLoadingPanel_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 70F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(67, 190);
            label2.Name = "label2";
            label2.Size = new Size(911, 125);
            label2.TabIndex = 2;
            label2.Text = "IKAW NA MAG ADD ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.ForeColor = Color.DarkOrange;
            label1.Location = new Point(321, 502);
            label1.Name = "label1";
            label1.Size = new Size(300, 72);
            label1.TabIndex = 1;
            label1.Text = "Please Wait";
            // 
            // hourGlassPic
            // 
            hourGlassPic.Image = (Image)resources.GetObject("hourGlassPic.Image");
            hourGlassPic.Location = new Point(711, 408);
            hourGlassPic.Name = "hourGlassPic";
            hourGlassPic.Size = new Size(187, 201);
            hourGlassPic.SizeMode = PictureBoxSizeMode.CenterImage;
            hourGlassPic.TabIndex = 0;
            hourGlassPic.TabStop = false;
            hourGlassPic.Click += hourGlassPic_Click;
            // 
            // loadingAnimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cityLoadingPanel);
            Name = "loadingAnimation";
            Size = new Size(1000, 650);
            cityLoadingPanel.ResumeLayout(false);
            cityLoadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hourGlassPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cityLoadingPanel;
        private Label label2;
        private Label label1;
        private PictureBox hourGlassPic;
    }
}
