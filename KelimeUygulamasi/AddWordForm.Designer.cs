namespace KelimeUygulamasi
{
    partial class AddWordForm
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
            this.txtTurkish = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.lblTurkish = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTurkish
            // 
            this.txtTurkish.Location = new System.Drawing.Point(110, 20);
            this.txtTurkish.Name = "txtTurkish";
            this.txtTurkish.Size = new System.Drawing.Size(160, 20);
            this.txtTurkish.TabIndex = 0;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(110, 60);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(160, 20);
            this.txtEnglish.TabIndex = 1;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(110, 100);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(75, 23);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Kelime Ekle";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // lblTurkish
            // 
            this.lblTurkish.AutoSize = true;
            this.lblTurkish.Location = new System.Drawing.Point(30, 23);
            this.lblTurkish.Name = "lblTurkish";
            this.lblTurkish.Size = new System.Drawing.Size(40, 13);
            this.lblTurkish.TabIndex = 3;
            this.lblTurkish.Text = "Türkçe";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(30, 63);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(47, 13);
            this.lblEnglish.TabIndex = 4;
            this.lblEnglish.Text = "İngilizce";
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblTurkish);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtTurkish);
            this.Name = "AddWordForm";
            this.Text = "Kelime Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTurkish;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label lblTurkish;
        private System.Windows.Forms.Label lblEnglish;
    }
}
