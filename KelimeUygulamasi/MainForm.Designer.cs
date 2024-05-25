namespace KelimeUygulamasi
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            addButton = new Button();
            testButton = new Button();
            learnedWordsButton = new Button();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(217, 123);
            addButton.Margin = new Padding(6, 7, 6, 7);
            addButton.Name = "addButton";
            addButton.Size = new Size(217, 74);
            addButton.TabIndex = 0;
            addButton.Text = "Kelime Ekle";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // testButton
            // 
            testButton.Location = new Point(217, 246);
            testButton.Margin = new Padding(6, 7, 6, 7);
            testButton.Name = "testButton";
            testButton.Size = new Size(217, 74);
            testButton.TabIndex = 1;
            testButton.Text = "Test Yap";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += TestButton_Click;
            // 
            // learnedWordsButton
            // 
            learnedWordsButton.Location = new Point(217, 369);
            learnedWordsButton.Margin = new Padding(6, 7, 6, 7);
            learnedWordsButton.Name = "learnedWordsButton";
            learnedWordsButton.Size = new Size(217, 122);
            learnedWordsButton.TabIndex = 2;
            learnedWordsButton.Text = "Öğrenilmiş Kelimeler";
            learnedWordsButton.UseVisualStyleBackColor = true;
            learnedWordsButton.Click += LearnedWordsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 615);
            Controls.Add(learnedWordsButton);
            Controls.Add(testButton);
            Controls.Add(addButton);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "Ana Sayfa";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button learnedWordsButton;
    }
}
