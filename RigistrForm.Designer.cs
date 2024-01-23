namespace WinFormsApp1
{
    partial class RigistrForm
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
            loginLB = new Label();
            PassLB = new Label();
            confLB = new Label();
            loginTB = new TextBox();
            passTB = new TextBox();
            confirmTB = new TextBox();
            cancelBtn = new Button();
            RegBtn = new Button();
            SuspendLayout();
            // 
            // loginLB
            // 
            loginLB.AutoSize = true;
            loginLB.Location = new Point(12, 11);
            loginLB.Name = "loginLB";
            loginLB.Size = new Size(37, 15);
            loginLB.TabIndex = 0;
            loginLB.Text = "Login";
            // 
            // PassLB
            // 
            PassLB.AutoSize = true;
            PassLB.Location = new Point(12, 47);
            PassLB.Name = "PassLB";
            PassLB.Size = new Size(57, 15);
            PassLB.TabIndex = 1;
            PassLB.Text = "Password";
            // 
            // confLB
            // 
            confLB.AutoSize = true;
            confLB.Location = new Point(12, 79);
            confLB.Name = "confLB";
            confLB.Size = new Size(104, 15);
            confLB.TabIndex = 2;
            confLB.Text = "Confirm password";
            // 
            // loginTB
            // 
            loginTB.Location = new Point(152, 9);
            loginTB.Name = "loginTB";
            loginTB.Size = new Size(166, 23);
            loginTB.TabIndex = 3;
            loginTB.Text = "min 5 simb";
            // 
            // passTB
            // 
            passTB.Location = new Point(152, 44);
            passTB.Name = "passTB";
            passTB.Size = new Size(166, 23);
            passTB.TabIndex = 4;
            passTB.Text = "min 5 simb";
            // 
            // confirmTB
            // 
            confirmTB.Location = new Point(152, 76);
            confirmTB.Name = "confirmTB";
            confirmTB.Size = new Size(166, 23);
            confirmTB.TabIndex = 5;
            confirmTB.Text = "min 5 simb";
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(196, 128);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(81, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // RegBtn
            // 
            RegBtn.Location = new Point(63, 128);
            RegBtn.Name = "RegBtn";
            RegBtn.Size = new Size(87, 23);
            RegBtn.TabIndex = 7;
            RegBtn.Text = "Registration";
            RegBtn.UseVisualStyleBackColor = true;
            RegBtn.Click += RegBtn_Click;
            // 
            // RigistrForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 163);
            Controls.Add(RegBtn);
            Controls.Add(cancelBtn);
            Controls.Add(confirmTB);
            Controls.Add(passTB);
            Controls.Add(loginTB);
            Controls.Add(confLB);
            Controls.Add(PassLB);
            Controls.Add(loginLB);
            Name = "RigistrForm";
            Text = "RigistrForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loginLB;
        private Label PassLB;
        private Label confLB;
        private TextBox loginTB;
        private TextBox passTB;
        private TextBox confirmTB;
        private Button cancelBtn;
        private Button RegBtn;
    }
}