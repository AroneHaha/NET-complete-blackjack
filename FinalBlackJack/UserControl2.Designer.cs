namespace FinalBlackJack
{
    partial class secondMainMenu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            saveButton = new Button();
            panel1 = new Panel();
            changeInfo = new Panel();
            label7 = new Label();
            changeOldPass = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            changeVerif = new TextBox();
            newPass = new Label();
            changeNewPass = new TextBox();
            changeConfirmPass = new TextBox();
            codeButton = new Button();
            cancelButton = new Button();
            saveBtn = new Button();
            changePasswordButton = new Button();
            settingsPassword = new Label();
            settingsUsername = new Label();
            musicOn = new RadioButton();
            musicOff = new RadioButton();
            panel1.SuspendLayout();
            changeInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Haettenschweiler", 40F);
            label1.Location = new Point(290, 27);
            label1.Name = "label1";
            label1.Size = new Size(277, 56);
            label1.TabIndex = 0;
            label1.Text = "GAME SETTINGS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Haettenschweiler", 21F);
            label2.Location = new Point(214, 131);
            label2.Name = "label2";
            label2.Size = new Size(254, 29);
            label2.TabIndex = 1;
            label2.Text = "Change Account Information";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Haettenschweiler", 21F);
            label3.Location = new Point(214, 292);
            label3.Name = "label3";
            label3.Size = new Size(227, 29);
            label3.TabIndex = 2;
            label3.Text = "Background Music (BGM)";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(349, 414);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(119, 39);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save Changes";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(changeInfo);
            panel1.Controls.Add(changePasswordButton);
            panel1.Controls.Add(settingsPassword);
            panel1.Controls.Add(settingsUsername);
            panel1.Controls.Add(musicOn);
            panel1.Controls.Add(musicOff);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Font = new Font("Corbel", 16F);
            panel1.Location = new Point(58, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 488);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // changeInfo
            // 
            changeInfo.BackColor = Color.DarkSeaGreen;
            changeInfo.Controls.Add(label7);
            changeInfo.Controls.Add(changeOldPass);
            changeInfo.Controls.Add(label6);
            changeInfo.Controls.Add(label5);
            changeInfo.Controls.Add(label4);
            changeInfo.Controls.Add(changeVerif);
            changeInfo.Controls.Add(newPass);
            changeInfo.Controls.Add(changeNewPass);
            changeInfo.Controls.Add(changeConfirmPass);
            changeInfo.Controls.Add(codeButton);
            changeInfo.Controls.Add(cancelButton);
            changeInfo.Controls.Add(saveBtn);
            changeInfo.Location = new Point(120, 27);
            changeInfo.Name = "changeInfo";
            changeInfo.Size = new Size(621, 426);
            changeInfo.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.25F);
            label7.Location = new Point(82, 145);
            label7.Name = "label7";
            label7.Size = new Size(164, 22);
            label7.TabIndex = 11;
            label7.Text = "Current Password :";
            // 
            // changeOldPass
            // 
            changeOldPass.Font = new Font("Microsoft Sans Serif", 13.25F);
            changeOldPass.Location = new Point(251, 142);
            changeOldPass.Name = "changeOldPass";
            changeOldPass.Size = new Size(273, 27);
            changeOldPass.TabIndex = 10;
            changeOldPass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.25F);
            label6.Location = new Point(88, 297);
            label6.Name = "label6";
            label6.Size = new Size(157, 22);
            label6.TabIndex = 9;
            label6.Text = "Verification Code :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Haettenschweiler", 45F);
            label5.Location = new Point(50, 30);
            label5.Name = "label5";
            label5.Size = new Size(541, 62);
            label5.TabIndex = 8;
            label5.Text = "Change Account Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.25F);
            label4.Location = new Point(80, 249);
            label4.Name = "label4";
            label4.Size = new Size(166, 22);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password :";
            label4.Click += label4_Click;
            // 
            // changeVerif
            // 
            changeVerif.Font = new Font("Microsoft Sans Serif", 13.25F);
            changeVerif.Location = new Point(251, 294);
            changeVerif.Name = "changeVerif";
            changeVerif.PlaceholderText = "Check your Gmail Account";
            changeVerif.Size = new Size(183, 27);
            changeVerif.TabIndex = 6;
            // 
            // newPass
            // 
            newPass.AutoSize = true;
            newPass.Font = new Font("Microsoft Sans Serif", 13.25F);
            newPass.Location = new Point(106, 193);
            newPass.Name = "newPass";
            newPass.Size = new Size(140, 22);
            newPass.TabIndex = 5;
            newPass.Text = "New Password :";
            // 
            // changeNewPass
            // 
            changeNewPass.Font = new Font("Microsoft Sans Serif", 13.25F);
            changeNewPass.Location = new Point(251, 193);
            changeNewPass.Name = "changeNewPass";
            changeNewPass.Size = new Size(273, 27);
            changeNewPass.TabIndex = 4;
            changeNewPass.UseSystemPasswordChar = true;
            // 
            // changeConfirmPass
            // 
            changeConfirmPass.Font = new Font("Microsoft Sans Serif", 13.25F);
            changeConfirmPass.Location = new Point(251, 246);
            changeConfirmPass.Name = "changeConfirmPass";
            changeConfirmPass.Size = new Size(273, 27);
            changeConfirmPass.TabIndex = 3;
            changeConfirmPass.UseSystemPasswordChar = true;
            changeConfirmPass.TextChanged += textBox1_TextChanged;
            // 
            // codeButton
            // 
            codeButton.BackColor = Color.Orange;
            codeButton.Font = new Font("Corbel", 12F);
            codeButton.Location = new Point(442, 289);
            codeButton.Name = "codeButton";
            codeButton.Size = new Size(107, 37);
            codeButton.TabIndex = 2;
            codeButton.Text = "Send Code";
            codeButton.UseVisualStyleBackColor = false;
            codeButton.Click += codeButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Red;
            cancelButton.Font = new Font("Segoe UI", 12F);
            cancelButton.Location = new Point(188, 362);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 40);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.ForestGreen;
            saveBtn.Font = new Font("Segoe UI", 12F);
            saveBtn.Location = new Point(320, 362);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(123, 40);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // changePasswordButton
            // 
            changePasswordButton.Location = new Point(566, 224);
            changePasswordButton.Name = "changePasswordButton";
            changePasswordButton.Size = new Size(145, 36);
            changePasswordButton.TabIndex = 10;
            changePasswordButton.Text = "cp Button";
            changePasswordButton.UseVisualStyleBackColor = true;
            changePasswordButton.Click += changePasswordButton_Click;
            // 
            // settingsPassword
            // 
            settingsPassword.AutoSize = true;
            settingsPassword.Font = new Font("Corbel", 14F);
            settingsPassword.Location = new Point(290, 231);
            settingsPassword.Name = "settingsPassword";
            settingsPassword.Size = new Size(259, 23);
            settingsPassword.TabIndex = 7;
            settingsPassword.Text = "Password : ****************";
            // 
            // settingsUsername
            // 
            settingsUsername.AutoSize = true;
            settingsUsername.Font = new Font("Corbel", 14F);
            settingsUsername.Location = new Point(290, 178);
            settingsUsername.Name = "settingsUsername";
            settingsUsername.Size = new Size(99, 23);
            settingsUsername.TabIndex = 6;
            settingsUsername.Text = "Username :";
            settingsUsername.Click += settingsUsername_Click;
            // 
            // musicOn
            // 
            musicOn.AutoSize = true;
            musicOn.Checked = true;
            musicOn.Font = new Font("Corbel", 14F);
            musicOn.Location = new Point(450, 346);
            musicOn.Name = "musicOn";
            musicOn.Size = new Size(52, 27);
            musicOn.TabIndex = 5;
            musicOn.TabStop = true;
            musicOn.Text = "On";
            musicOn.UseVisualStyleBackColor = true;
            // 
            // musicOff
            // 
            musicOff.AutoSize = true;
            musicOff.Font = new Font("Corbel", 14F);
            musicOff.Location = new Point(330, 346);
            musicOff.Name = "musicOff";
            musicOff.Size = new Size(101, 27);
            musicOff.TabIndex = 4;
            musicOff.Text = "No Music";
            musicOff.UseVisualStyleBackColor = true;
            // 
            // secondMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Green;
            Controls.Add(panel1);
            Name = "secondMainMenu";
            Size = new Size(952, 616);
            Load += secondMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            changeInfo.ResumeLayout(false);
            changeInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveButton;
        private Panel panel1;
        private RadioButton musicOn;
        private RadioButton musicOff;
        private Label settingsPassword;
        private Label settingsUsername;
        private Button changePasswordButton;
        private Panel changeInfo;
        private Button cancelButton;
        private Button saveBtn;
        private TextBox changeConfirmPass;
        private Button codeButton;
        private TextBox changeVerif;
        private Label newPass;
        private TextBox changeNewPass;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox changeOldPass;
    }
}
