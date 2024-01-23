namespace WinFormsApp1
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLabel = new Label();
            passLabel = new Label();
            loginTextBox = new TextBox();
            passTB = new TextBox();
            enterBtn = new Button();
            clearButton = new Button();
            regisrtBtn = new Button();
            SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(12, 9);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(64, 15);
            loginLabel.TabIndex = 0;
            loginLabel.Text = "Enter login";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(12, 38);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(87, 15);
            passLabel.TabIndex = 1;
            passLabel.Text = "Enter password";
            // 
            // loginTextBox
            // 
            loginTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginTextBox.ForeColor = Color.MidnightBlue;
            loginTextBox.Location = new Point(133, 6);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(158, 26);
            loginTextBox.TabIndex = 2;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // passTB
            // 
            passTB.Location = new Point(133, 35);
            passTB.Name = "passTB";
            passTB.PasswordChar = '*';
            passTB.Size = new Size(158, 23);
            passTB.TabIndex = 3;
            // 
            // enterBtn
            // 
            enterBtn.Location = new Point(93, 76);
            enterBtn.Name = "enterBtn";
            enterBtn.Size = new Size(75, 23);
            enterBtn.TabIndex = 4;
            enterBtn.Text = "Enter";
            enterBtn.UseVisualStyleBackColor = true;
            enterBtn.Click += enterBtn_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(12, 76);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // regisrtBtn
            // 
            regisrtBtn.Location = new Point(192, 76);
            regisrtBtn.Name = "regisrtBtn";
            regisrtBtn.Size = new Size(99, 23);
            regisrtBtn.TabIndex = 6;
            regisrtBtn.Text = "Registration";
            regisrtBtn.UseVisualStyleBackColor = true;
            regisrtBtn.Click += regisrtBtn_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 111);
            Controls.Add(regisrtBtn);
            Controls.Add(clearButton);
            Controls.Add(enterBtn);
            Controls.Add(passTB);
            Controls.Add(loginTextBox);
            Controls.Add(passLabel);
            Controls.Add(loginLabel);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLabel;
        private Label passLabel;
        private TextBox loginTextBox;
        private TextBox passTB;
        private Button enterBtn;
        private Button clearButton;
        private Button regisrtBtn;
    }
}