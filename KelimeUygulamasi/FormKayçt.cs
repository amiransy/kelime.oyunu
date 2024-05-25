using System;
using System.Windows.Forms;

namespace KelimeUygulamasi
{
    public partial class FormKayıt : Form
    {
        public FormKayıt()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string password = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz!");
                return;
            }

            User existingUser = Database.FindUser(username);
            if (existingUser != null)
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor!");
                return;
            }

            User newUser = new User(username, password);
            Database.AddUser(newUser);

            MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.");
            this.Close();
        }
    }
}
