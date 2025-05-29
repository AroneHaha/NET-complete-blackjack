namespace FinalBlackJack
{
    partial class thirdmainMenu
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
            text1 = new Label();
            confirmButton = new Button();
            cancelButton = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // text1
            // 
            text1.AutoSize = true;
            text1.Font = new Font("Haettenschweiler", 30.25F);
            text1.ForeColor = Color.Black;
            text1.Location = new Point(193, 175);
            text1.Name = "text1";
            text1.Size = new Size(457, 43);
            text1.TabIndex = 1;
            text1.Text = "Are you sure you want to log out? ";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.LimeGreen;
            confirmButton.Font = new Font("Corbel", 14F);
            confirmButton.ForeColor = Color.Black;
            confirmButton.Location = new Point(419, 235);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(116, 48);
            confirmButton.TabIndex = 2;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Font = new Font("Corbel", 14F);
            cancelButton.ForeColor = Color.Black;
            cancelButton.Location = new Point(304, 235);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(109, 48);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(text1);
            panel1.Controls.Add(confirmButton);
            panel1.Location = new Point(81, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 456);
            panel1.TabIndex = 4;
            // 
            // thirdmainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(panel1);
            Name = "thirdmainMenu";
            Size = new Size(1000, 583);
            Load += thirdmainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label text1;
        private Button confirmButton;
        private Button cancelButton;
        private Panel panel1;
    }
}
