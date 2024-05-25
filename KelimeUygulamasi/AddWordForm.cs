using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class AddWordForm : Form
    {
        public AddWordForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string turkishWord = txtTurkish.Text;
            string englishWord = txtEnglish.Text;

            if (string.IsNullOrWhiteSpace(turkishWord) || string.IsNullOrWhiteSpace(englishWord))
            {
                MessageBox.Show("Her iki kelime alanı da doldurulmalıdır!");
                return;
            }

            Word newWord = new Word(turkishWord, englishWord);
            Database.AddWord(newWord);

            MessageBox.Show("Kelime başarıyla eklendi!");
            this.Close();
        }
    }
}
