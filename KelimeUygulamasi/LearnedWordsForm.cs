using System;
using System.Linq;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class LearnedWordsForm : Form
    {
        public LearnedWordsForm()
        {
            InitializeComponent();
            LoadLearnedWords();
        }

        private void LoadLearnedWords()
        {
            var learnedWords = Database.GetLearnedWords();
            if (learnedWords.Count == 0)
            {
                MessageBox.Show("Henüz öğrenilmiş kelime yok!");
                this.Close();
                return;
            }

            foreach (var word in learnedWords)
            {
                string[] row = { word.English, word.Turkish };
                var listViewItem = new ListViewItem(row);
                listViewLearnedWords.Items.Add(listViewItem);
            }
        }
    }
}
