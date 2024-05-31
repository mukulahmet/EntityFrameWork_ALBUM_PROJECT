namespace PL
{
    partial class RegisterScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnKayit = new Button();
            txtAdSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            SuspendLayout();
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(295, 334);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(116, 46);
            btnKayit.TabIndex = 0;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(260, 86);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(190, 27);
            txtAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 86);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 149);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 3;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 208);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 267);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 5;
            label4.Text = "Şifre Tekrar:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(260, 149);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(190, 27);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(260, 208);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(190, 27);
            txtSifre.TabIndex = 7;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(260, 267);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(190, 27);
            txtSifreTekrar.TabIndex = 8;
            // 
            // RegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 451);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdSoyad);
            Controls.Add(btnKayit);
            Name = "RegisterScreen";
            Text = "RegisterScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayit;
        private TextBox txtAdSoyad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
    }
}