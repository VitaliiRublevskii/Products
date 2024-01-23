namespace WinFormsApp1
{
    partial class ProductForm
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
            userLabel = new Label();
            brandListBox = new ListBox();
            brandLabel = new Label();
            prodLabel = new Label();
            prodComboBox = new ComboBox();
            addProdBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(0, 0);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(41, 15);
            userLabel.TabIndex = 0;
            userLabel.Text = "Hello !";
            // 
            // brandListBox
            // 
            brandListBox.FormattingEnabled = true;
            brandListBox.ItemHeight = 15;
            brandListBox.Location = new Point(157, 55);
            brandListBox.Name = "brandListBox";
            brandListBox.Size = new Size(120, 94);
            brandListBox.TabIndex = 1;
            brandListBox.SelectedIndexChanged += brandListBox_SelectedIndexChanged;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(192, 37);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(40, 15);
            brandLabel.TabIndex = 2;
            brandLabel.Text = "Бренд";
            // 
            // prodLabel
            // 
            prodLabel.AutoSize = true;
            prodLabel.Location = new Point(192, 172);
            prodLabel.Name = "prodLabel";
            prodLabel.Size = new Size(53, 15);
            prodLabel.TabIndex = 3;
            prodLabel.Text = "Продукт";
            // 
            // prodComboBox
            // 
            prodComboBox.FormattingEnabled = true;
            prodComboBox.Location = new Point(156, 190);
            prodComboBox.Name = "prodComboBox";
            prodComboBox.Size = new Size(121, 23);
            prodComboBox.TabIndex = 4;
            // 
            // addProdBtn
            // 
            addProdBtn.Location = new Point(180, 261);
            addProdBtn.Name = "addProdBtn";
            addProdBtn.Size = new Size(75, 51);
            addProdBtn.TabIndex = 5;
            addProdBtn.Text = "Add product";
            addProdBtn.UseVisualStyleBackColor = true;
            addProdBtn.Click += addProdBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(180, 334);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 58);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 450);
            Controls.Add(cancelBtn);
            Controls.Add(addProdBtn);
            Controls.Add(prodComboBox);
            Controls.Add(prodLabel);
            Controls.Add(brandLabel);
            Controls.Add(brandListBox);
            Controls.Add(userLabel);
            Name = "ProductForm";
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userLabel;
        private ListBox brandListBox;
        private Label brandLabel;
        private Label prodLabel;
        private ComboBox prodComboBox;
        private Button addProdBtn;
        private Button cancelBtn;
    }
}