using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class QuizForm : Form
    {
        private List<Word> words;
        private List<Word> askedWords;
        private Random random;

        public QuizForm()
        {
            InitializeComponent();
            words = Database.GetWords();
            askedWords = new List<Word>();
            random = new Random();
            ShowNextWord();
        }

        private void ShowNextWord()
        {
            var remainingWords = words.Except(askedWords).ToList();
            if (remainingWords.Count == 0)
            {
                MessageBox.Show("Test bitti!");
                this.Close();
                return;
            }

            int index = random.Next(remainingWords.Count);
            var word = remainingWords[index];

            askedWords.Add(word);
            lblEnglishWord.Text = word.English;
        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            string enteredTurkish = txtTurkishAnswer.Text;
            var currentWord = askedWords.Last();

            if (enteredTurkish.Equals(currentWord.Turkish, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Doğru cevap!");
                Database.AddLearnedWord(currentWord); // Doğru cevaplanan kelimeyi öğrenilmiş kelimelere ekle
                txtTurkishAnswer.Clear();
                ShowNextWord();
            }
            else
            {
                MessageBox.Show("Cevap yanlış, teste yeniden başlayın.");
                this.Close();
            }
        }
    }
}
