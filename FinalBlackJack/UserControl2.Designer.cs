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
            cancelButton = new Button();
            saveBtn = new Button();
            changePasswordButton = new Button();
            settingsPassword = new Label();
            settingsUsername = new Label();
            musicOn = new RadioButton();
            musicOff = new RadioButton();
            codeButton = new Button();
            confirmPass = new TextBox();
            currentPass = new TextBox();
            newPass = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
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
            changeInfo.BackColor = Color.Olive;
            changeInfo.Controls.Add(label5);
            changeInfo.Controls.Add(label4);
            changeInfo.Controls.Add(textBox1);
            changeInfo.Controls.Add(newPass);
            changeInfo.Controls.Add(currentPass);
            changeInfo.Controls.Add(confirmPass);
            changeInfo.Controls.Add(codeButton);
            changeInfo.Controls.Add(cancelButton);
            changeInfo.Controls.Add(saveBtn);
            changeInfo.Location = new Point(132, 27);
            changeInfo.Name = "changeInfo";
            changeInfo.Size = new Size(579, 426);
            changeInfo.TabIndex = 8;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(441, 352);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 40);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(312, 352);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(123, 40);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
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
            // codeButton
            // 
            codeButton.Location = new Point(116, 283);
            codeButton.Name = "codeButton";
            codeButton.Size = new Size(129, 41);
            codeButton.TabIndex = 2;
            codeButton.Text = "Send Code";
            codeButton.UseVisualStyleBackColor = true;
            // 
            // confirmPass
            // 
            confirmPass.Location = new Point(211, 197);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(312, 34);
            confirmPass.TabIndex = 3;
            confirmPass.TextChanged += textBox1_TextChanged;
            // 
            // currentPass
            // 
            currentPass.Location = new Point(211, 140);
            currentPass.Name = "currentPass";
            currentPass.Size = new Size(312, 34);
            currentPass.TabIndex = 4;
            // 
            // newPass
            // 
            newPass.AutoSize = true;
            newPass.Location = new Point(48, 143);
            newPass.Name = "newPass";
            newPass.Size = new Size(157, 27);
            newPass.TabIndex = 5;
            newPass.Text = "New Password :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 287);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 34);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 200);
            label4.Name = "label4";
            label4.Size = new Size(189, 27);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 77);
            label5.Name = "label5";
            label5.Size = new Size(276, 27);
            label5.TabIndex = 8;
            label5.Text = "Change Account Information";
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
        private TextBox confirmPass;
        private Button codeButton;
        private TextBox textBox1;
        private Label newPass;
        private TextBox currentPass;
        private Label label5;
        private Label label4;
    }
}
