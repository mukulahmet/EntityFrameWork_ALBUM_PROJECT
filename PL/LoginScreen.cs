using System.Security.Cryptography;
using System.Text;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models;

namespace PL
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            context = new PlakDBContext();
            user = new Kullanici();
        }

        PlakDBContext context;
        Kullanici user;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = sha256_hash(txtSifre.Text);

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullan�c� ad� veya parola bo� b�rak�lamaz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            user = context.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            if (user == null)
            {
                MessageBox.Show("Kullan�c� ad� veya parola hatal�", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Giri� Ba�ar�l�");
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.ShowDialog();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
    }
}
