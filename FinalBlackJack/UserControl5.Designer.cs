namespace FinalBlackJack
{
    partial class manilaPanel
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
            exitButton = new Button();
            manila = new Label();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(761, 533);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 0;
            exitButton.Text = "button1";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // manila
            // 
            manila.AutoSize = true;
            manila.Location = new Point(336, 56);
            manila.Name = "manila";
            manila.Size = new Size(52, 15);
            manila.TabIndex = 1;
            manila.Text = "MANILA";
            // 
            // manilaPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(manila);
            Controls.Add(exitButton);
            Name = "manilaPanel";
            Size = new Size(925, 634);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private Label manila;
    }
}
