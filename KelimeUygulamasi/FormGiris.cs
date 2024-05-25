using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = txtGirisKullaniciAdi.Text;
            string password = txtGirisSifre.Text;

            User user = Database.FindUser(username);
            if (user == null)
            {
                MessageBox.Show("Geçersiz kullanıcı adı!");
                return;
            }

            if (user.Password != password)
            {
                MessageBox.Show("Geçersiz şifre!");
                return;
            }

            Program.CurrentUser = user;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            FormKayıt registerForm = new FormKayıt();
            registerForm.ShowDialog();
        }
    }
}
