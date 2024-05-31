using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace PL
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
            user = new();
            context = new PlakDBContext();
        }
        PlakDBContext context;
        Kullanici user;
        private void btnKayit_Click(object sender, EventArgs e)
        {
            //Kullanıcı Ad Soyad kontrolü
            if (string.IsNullOrEmpty(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad Soyad Boş Olamaz");
                return;
            }
            else
            {
                user.KullaniciAdSoyad = txtAdSoyad.Text;
            }

            //KullanıcıAdı kontrolü
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı Adı Boş Olamaz");
                return;
            }
            else
            {
                foreach (Kullanici us in context.Kullanicilar)
                {
                    if (us.KullaniciID == user.KullaniciID)
                    {
                        MessageBox.Show("Kullanıcı adı alınmış");
                        return;
                    }
                }
                user.KullaniciAdi = txtKullaniciAdi.Text;                
            }

            //şifre kontrolü
            if (string.IsNullOrWhiteSpace(txtSifre.Text))    //Şifre bos mu kontrolü
            {
                MessageBox.Show("Şifre alanı boş olamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!CheckPassword(txtSifre.Text)) // Şifre Kontrol
            {
                MessageBox.Show("Şifre en az 8 harfden olusmalı. Bunların en az 2 büyük harf, 3 küçük harf ve 2 özel karakter(!:+*) içermelidir ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSifreTekrar.Text)) // tekrar şifresi boşluk kontrolü
            {
                MessageBox.Show("Şifre Tekrar alanı boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)  
            {
                MessageBox.Show("Şifreler Aynı Değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.Sifre= sha256_hash(txtSifre.Text);

            context.Kullanicilar.Add(user);
            context.SaveChanges();
            MessageBox.Show("Başarılı Kayıt");
            this.Close();
        }


        static bool CheckPassword(string sifre)
        {
            // En az 8 karakter uzunluğunda olmalıdır.
            if (sifre.Length < 8)
                return false;

            // En az 2 büyük harf içermelidir.
            if (!sifre.Any(char.IsUpper) || sifre.Count(char.IsUpper) < 2)
                return false;

            // En az 3 küçük harf içermelidir.
            if (!sifre.Any(char.IsLower) || sifre.Count(char.IsLower) < 3)
                return false;

            // ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 2 tanesi içermelidir.
            string specialCharacters = "!:+*";
            int specialCount = sifre.Count(c => specialCharacters.Contains(c));
            if (specialCount < 2)
                return false;

            return true;
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
