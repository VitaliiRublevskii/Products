namespace WinFormsApp1
{
    partial class ProductAddForm
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
            NameLB = new Label();
            modelLB = new Label();
            memoryLB = new Label();
            priceLB = new Label();
            dimensionsLB = new Label();
            nameTB = new TextBox();
            modelTB = new TextBox();
            memoryTB = new TextBox();
            priceTB = new TextBox();
            dimensionTB = new TextBox();
            addBtn = new Button();
            canselBtn = new Button();
            SuspendLayout();
            // 
            // NameLB
            // 
            NameLB.AutoSize = true;
            NameLB.Location = new Point(41, 21);
            NameLB.Name = "NameLB";
            NameLB.Size = new Size(39, 15);
            NameLB.TabIndex = 0;
            NameLB.Text = "Name";
            // 
            // modelLB
            // 
            modelLB.AutoSize = true;
            modelLB.Location = new Point(41, 63);
            modelLB.Name = "modelLB";
            modelLB.Size = new Size(41, 15);
            modelLB.TabIndex = 1;
            modelLB.Text = "Model";
            // 
            // memoryLB
            // 
            memoryLB.AutoSize = true;
            memoryLB.Location = new Point(41, 103);
            memoryLB.Name = "memoryLB";
            memoryLB.Size = new Size(52, 15);
            memoryLB.TabIndex = 2;
            memoryLB.Text = "Memory";
            // 
            // priceLB
            // 
            priceLB.AutoSize = true;
            priceLB.Location = new Point(41, 144);
            priceLB.Name = "priceLB";
            priceLB.Size = new Size(33, 15);
            priceLB.TabIndex = 3;
            priceLB.Text = "Price";
            // 
            // dimensionsLB
            // 
            dimensionsLB.AutoSize = true;
            dimensionsLB.Location = new Point(41, 184);
            dimensionsLB.Name = "dimensionsLB";
            dimensionsLB.Size = new Size(69, 15);
            dimensionsLB.TabIndex = 4;
            dimensionsLB.Text = "Dimensions";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(161, 18);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(172, 23);
            nameTB.TabIndex = 5;
            // 
            // modelTB
            // 
            modelTB.Location = new Point(161, 60);
            modelTB.Name = "modelTB";
            modelTB.Size = new Size(172, 23);
            modelTB.TabIndex = 6;
            // 
            // memoryTB
            // 
            memoryTB.Location = new Point(161, 100);
            memoryTB.Name = "memoryTB";
            memoryTB.Size = new Size(172, 23);
            memoryTB.TabIndex = 7;
            // 
            // priceTB
            // 
            priceTB.Location = new Point(161, 141);
            priceTB.Name = "priceTB";
            priceTB.Size = new Size(172, 23);
            priceTB.TabIndex = 8;
            // 
            // dimensionTB
            // 
            dimensionTB.Location = new Point(161, 181);
            dimensionTB.Name = "dimensionTB";
            dimensionTB.Size = new Size(172, 23);
            dimensionTB.TabIndex = 9;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(41, 253);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(113, 23);
            addBtn.TabIndex = 10;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // canselBtn
            // 
            canselBtn.Location = new Point(202, 253);
            canselBtn.Name = "canselBtn";
            canselBtn.Size = new Size(110, 23);
            canselBtn.TabIndex = 11;
            canselBtn.Text = "Cancel";
            canselBtn.UseVisualStyleBackColor = true;
            canselBtn.Click += canselBtn_Click;
            // 
            // ProductAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 324);
            Controls.Add(canselBtn);
            Controls.Add(addBtn);
            Controls.Add(dimensionTB);
            Controls.Add(priceTB);
            Controls.Add(memoryTB);
            Controls.Add(modelTB);
            Controls.Add(nameTB);
            Controls.Add(dimensionsLB);
            Controls.Add(priceLB);
            Controls.Add(memoryLB);
            Controls.Add(modelLB);
            Controls.Add(NameLB);
            Name = "ProductAddForm";
            Text = "ProductAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLB;
        private Label modelLB;
        private Label memoryLB;
        private Label priceLB;
        private Label dimensionsLB;
        private TextBox nameTB;
        private TextBox modelTB;
        private TextBox memoryTB;
        private TextBox priceTB;
        private TextBox dimensionTB;
        private Button addBtn;
        private Button canselBtn;
    }
}