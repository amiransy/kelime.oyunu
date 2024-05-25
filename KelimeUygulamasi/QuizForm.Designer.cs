namespace KelimeUygulamasi
{
    partial class QuizForm
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
            this.lblEnglishWord = new System.Windows.Forms.Label();
            this.txtTurkishAnswer = new System.Windows.Forms.TextBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.AutoSize = true;
            this.lblEnglishWord.Location = new System.Drawing.Point(12, 20);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(72, 13);
            this.lblEnglishWord.TabIndex = 0;
            this.lblEnglishWord.Text = "İngilizce Kelime";
            // 
            // txtTurkishAnswer
            // 
            this.txtTurkishAnswer.Location = new System.Drawing.Point(15, 50);
            this.txtTurkishAnswer.Name = "txtTurkishAnswer";
            this.txtTurkishAnswer.Size = new System.Drawing.Size(200, 20);
            this.txtTurkishAnswer.TabIndex = 1;
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(15, 90);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAnswer.TabIndex = 2;
            this.btnCheckAnswer.Text = "Kontrol Et";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.txtTurkishAnswer);
            this.Controls.Add(this.lblEnglishWord);
            this.Name = "QuizForm";
            this.Text = "Test Yap";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEnglishWord;
        private System.Windows.Forms.TextBox txtTurkishAnswer;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}
