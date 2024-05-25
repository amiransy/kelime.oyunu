namespace KelimeUygulamasi
{
    partial class LearnedWordsForm
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
            this.listViewLearnedWords = new System.Windows.Forms.ListView();
            this.columnHeaderEnglish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTurkish = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewLearnedWords
            // 
            this.listViewLearnedWords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderEnglish,
            this.columnHeaderTurkish});
            this.listViewLearnedWords.HideSelection = false;
            this.listViewLearnedWords.Location = new System.Drawing.Point(12, 12);
            this.listViewLearnedWords.Name = "listViewLearnedWords";
            this.listViewLearnedWords.Size = new System.Drawing.Size(360, 237);
            this.listViewLearnedWords.TabIndex = 0;
            this.listViewLearnedWords.UseCompatibleStateImageBehavior = false;
            this.listViewLearnedWords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderEnglish
            // 
            this.columnHeaderEnglish.Text = "İngilizce";
            this.columnHeaderEnglish.Width = 180;
            // 
            // columnHeaderTurkish
            // 
            this.columnHeaderTurkish.Text = "Türkçe";
            this.columnHeaderTurkish.Width = 180;
            // 
            // LearnedWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.listViewLearnedWords);
            this.Name = "LearnedWordsForm";
            this.Text = "Öğrenilmiş Kelimeler";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView listViewLearnedWords;
        private System.Windows.Forms.ColumnHeader columnHeaderEnglish;
        private System.Windows.Forms.ColumnHeader columnHeaderTurkish;
    }
}
