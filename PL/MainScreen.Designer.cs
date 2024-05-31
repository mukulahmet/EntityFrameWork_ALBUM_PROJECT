namespace PL
{
    partial class MainScreen
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
            dgTumAlbumler = new DataGridView();
            txtAlbumunAdi = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSanatci = new TextBox();
            txtFiyat = new TextBox();
            txtIndirim = new TextBox();
            dtpTarih = new DateTimePicker();
            cbDevamEdiyor = new CheckBox();
            cbDevamEtmiyor = new CheckBox();
            label6 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnClose = new Button();
            dgSatisiDurmus = new DataGridView();
            dgSatisiDevamEden = new DataGridView();
            dgEnSonEklenen10 = new DataGridView();
            dgIndirimdeki = new DataGridView();
            btnListeleriGetir = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgTumAlbumler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSatisiDurmus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgSatisiDevamEden).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEnSonEklenen10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgIndirimdeki).BeginInit();
            SuspendLayout();
            // 
            // dgTumAlbumler
            // 
            dgTumAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTumAlbumler.Location = new Point(434, 50);
            dgTumAlbumler.Name = "dgTumAlbumler";
            dgTumAlbumler.RowHeadersWidth = 51;
            dgTumAlbumler.Size = new Size(671, 250);
            dgTumAlbumler.TabIndex = 0;
            dgTumAlbumler.CellClick += dgTumAlbumler_CellClick;
            // 
            // txtAlbumunAdi
            // 
            txtAlbumunAdi.Location = new Point(133, 50);
            txtAlbumunAdi.Name = "txtAlbumunAdi";
            txtAlbumunAdi.Size = new Size(250, 27);
            txtAlbumunAdi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Albümün Adı:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(36, 271);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 83);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Sanatçı/Grup:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 117);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 5;
            label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 151);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 184);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 7;
            label5.Text = "İndirim Oranı:";
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(133, 83);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(250, 27);
            txtSanatci.TabIndex = 8;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(133, 151);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(250, 27);
            txtFiyat.TabIndex = 10;
            // 
            // txtIndirim
            // 
            txtIndirim.Location = new Point(133, 184);
            txtIndirim.Name = "txtIndirim";
            txtIndirim.Size = new Size(250, 27);
            txtIndirim.TabIndex = 11;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(133, 117);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 12;
            // 
            // cbDevamEdiyor
            // 
            cbDevamEdiyor.AutoSize = true;
            cbDevamEdiyor.Location = new Point(133, 229);
            cbDevamEdiyor.Name = "cbDevamEdiyor";
            cbDevamEdiyor.Size = new Size(124, 24);
            cbDevamEdiyor.TabIndex = 13;
            cbDevamEdiyor.Text = "Devam Ediyor";
            cbDevamEdiyor.UseVisualStyleBackColor = true;
            // 
            // cbDevamEtmiyor
            // 
            cbDevamEtmiyor.AutoSize = true;
            cbDevamEtmiyor.Location = new Point(263, 228);
            cbDevamEtmiyor.Name = "cbDevamEtmiyor";
            cbDevamEtmiyor.Size = new Size(133, 24);
            cbDevamEtmiyor.TabIndex = 14;
            cbDevamEtmiyor.Text = "Devam Etmiyor";
            cbDevamEtmiyor.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 228);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 15;
            label6.Text = "Satış:";
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(163, 271);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(295, 271);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(88, 29);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnClose.ForeColor = Color.Red;
            btnClose.Location = new Point(1107, -1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(54, 38);
            btnClose.TabIndex = 18;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgSatisiDurmus
            // 
            dgSatisiDurmus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSatisiDurmus.Location = new Point(32, 347);
            dgSatisiDurmus.Name = "dgSatisiDurmus";
            dgSatisiDurmus.RowHeadersWidth = 51;
            dgSatisiDurmus.Size = new Size(274, 280);
            dgSatisiDurmus.TabIndex = 19;
            // 
            // dgSatisiDevamEden
            // 
            dgSatisiDevamEden.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgSatisiDevamEden.Location = new Point(312, 347);
            dgSatisiDevamEden.Name = "dgSatisiDevamEden";
            dgSatisiDevamEden.RowHeadersWidth = 51;
            dgSatisiDevamEden.Size = new Size(261, 280);
            dgSatisiDevamEden.TabIndex = 20;
            // 
            // dgEnSonEklenen10
            // 
            dgEnSonEklenen10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEnSonEklenen10.Location = new Point(579, 347);
            dgEnSonEklenen10.Name = "dgEnSonEklenen10";
            dgEnSonEklenen10.RowHeadersWidth = 51;
            dgEnSonEklenen10.Size = new Size(261, 280);
            dgEnSonEklenen10.TabIndex = 21;
            // 
            // dgIndirimdeki
            // 
            dgIndirimdeki.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgIndirimdeki.Location = new Point(846, 347);
            dgIndirimdeki.Name = "dgIndirimdeki";
            dgIndirimdeki.RowHeadersWidth = 51;
            dgIndirimdeki.Size = new Size(261, 280);
            dgIndirimdeki.TabIndex = 22;
            // 
            // btnListeleriGetir
            // 
            btnListeleriGetir.Location = new Point(459, 644);
            btnListeleriGetir.Name = "btnListeleriGetir";
            btnListeleriGetir.Size = new Size(245, 39);
            btnListeleriGetir.TabIndex = 23;
            btnListeleriGetir.Text = "Listele";
            btnListeleriGetir.UseVisualStyleBackColor = true;
            btnListeleriGetir.Click += btnListeleriGetir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 324);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 24;
            label7.Text = "Satışı Durmuş Albümler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 324);
            label8.Name = "label8";
            label8.Size = new Size(197, 20);
            label8.TabIndex = 25;
            label8.Text = "Satışı Devam Eden Albümler";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(579, 324);
            label9.Name = "label9";
            label9.Size = new Size(177, 20);
            label9.TabIndex = 26;
            label9.Text = "En Son Eklenen 10 Albüm";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(846, 324);
            label10.Name = "label10";
            label10.Size = new Size(149, 20);
            label10.TabIndex = 27;
            label10.Text = "İndirimdeki Albümler";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 29);
            panel1.TabIndex = 28;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 694);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnListeleriGetir);
            Controls.Add(dgIndirimdeki);
            Controls.Add(dgEnSonEklenen10);
            Controls.Add(dgSatisiDevamEden);
            Controls.Add(dgSatisiDurmus);
            Controls.Add(btnClose);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(label6);
            Controls.Add(cbDevamEtmiyor);
            Controls.Add(cbDevamEdiyor);
            Controls.Add(dtpTarih);
            Controls.Add(txtIndirim);
            Controls.Add(txtFiyat);
            Controls.Add(txtSanatci);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(txtAlbumunAdi);
            Controls.Add(dgTumAlbumler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainScreen";
            Text = "MainScreen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)dgTumAlbumler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSatisiDurmus).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgSatisiDevamEden).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEnSonEklenen10).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgIndirimdeki).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTumAlbumler;
        private TextBox txtAlbumunAdi;
        private Label label1;
        private Button btnEkle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSanatci;
        private TextBox txtFiyat;
        private TextBox txtIndirim;
        private DateTimePicker dtpTarih;
        private CheckBox cbDevamEdiyor;
        private CheckBox cbDevamEtmiyor;
        private Label label6;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnClose;
        private DataGridView dgSatisiDurmus;
        private DataGridView dgSatisiDevamEden;
        private DataGridView dgEnSonEklenen10;
        private DataGridView dgIndirimdeki;
        private Button btnListeleriGetir;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
    }
}