using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddWordForm addWordForm = new AddWordForm();
            addWordForm.ShowDialog();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm();
            quizForm.ShowDialog();
        }

        private void LearnedWordsButton_Click(object sender, EventArgs e)
        {
            LearnedWordsForm learnedWordsForm = new LearnedWordsForm();
            learnedWordsForm.ShowDialog();
        }
    }
}
