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
            hourGlassPic = new PictureBox();
            label1 = new Label();
            cityLoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hourGlassPic).BeginInit();
            SuspendLayout();
            // 
            // cityLoadingPanel
            // 
            cityLoadingPanel.BackColor = Color.Black;
            cityLoadingPanel.Controls.Add(hourGlassPic);
            cityLoadingPanel.Controls.Add(label1);
            cityLoadingPanel.Dock = DockStyle.Fill;
            cityLoadingPanel.Location = new Point(0, 0);
            cityLoadingPanel.Name = "cityLoadingPanel";
            cityLoadingPanel.Size = new Size(1000, 650);
            cityLoadingPanel.TabIndex = 0;
            cityLoadingPanel.Paint += cityLoadingPanel_Paint;
            // 
            // hourGlassPic
            // 
            hourGlassPic.Image = (Image)resources.GetObject("hourGlassPic.Image");
            hourGlassPic.Location = new Point(878, 526);
            hourGlassPic.Name = "hourGlassPic";
            hourGlassPic.Size = new Size(67, 62);
            hourGlassPic.SizeMode = PictureBoxSizeMode.StretchImage;
            hourGlassPic.TabIndex = 0;
            hourGlassPic.TabStop = false;
            hourGlassPic.Click += hourGlassPic_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(871, 584);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 1;
            label1.Text = "Loading";
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
        private PictureBox hourGlassPic;
        private Label label1;
    }
}
