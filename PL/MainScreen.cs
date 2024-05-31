using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PL
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            context = new();
        }

        PlakDBContext context;
        private void MainScreen_Load(object sender, EventArgs e)
        {
            Listele();
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album();

            if (string.IsNullOrEmpty(txtAlbumunAdi.Text) || string.IsNullOrEmpty(txtFiyat.Text) || string.IsNullOrEmpty(txtIndirim.Text) || string.IsNullOrEmpty(txtSanatci.Text))
            {
                MessageBox.Show("Tüm Alanlar Doldurulmalıdır", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            album.AlbumAdi = txtAlbumunAdi.Text;
            album.AlbumunSanatcisi_Grubu = txtSanatci.Text;
            album.AlbumCikisTarihi = dtpTarih.Value.Date;
            album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);

            if (Convert.ToInt32(txtIndirim.Text) > 100 || Convert.ToInt32(txtIndirim.Text) < 0)
            {
                MessageBox.Show("İndirim oranı 0-100 arasında olmalıdır.");
                return;
            }
            else
            {
                album.IndirimOrani = Convert.ToDouble(txtIndirim.Text) / 100;
            }

            if (cbDevamEdiyor.Checked == true)
            {
                album.SatisDevamEdiyorMu = true;
            }
            else if (cbDevamEtmiyor.Checked == true)

            {
                album.SatisDevamEdiyorMu = false;
            }

            context.Albumler.Add(album);
            context.SaveChanges();
            MessageBox.Show("Ekleme Başarılı");
            Listele();
            Temizle();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Album album = (Album)dgTumAlbumler.CurrentRow.DataBoundItem;

            album.AlbumAdi = txtAlbumunAdi.Text;
            album.AlbumunSanatcisi_Grubu = txtSanatci.Text;
            album.AlbumCikisTarihi = dtpTarih.Value.Date;
            album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);
            album.IndirimOrani = Convert.ToDouble(txtIndirim.Text);

            if (cbDevamEdiyor.Checked == true)
            {
                album.SatisDevamEdiyorMu = true;
            }
            else if (cbDevamEtmiyor.Checked == true)

            {
                album.SatisDevamEdiyorMu = false;
            }

            context.SaveChanges();
            Listele();
            Temizle();
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Album album = (Album)dgTumAlbumler.CurrentRow.DataBoundItem;
            context.Albumler.Remove(album);
            context.SaveChanges();
            MessageBox.Show("Albüm Silindi.");
            Listele();
            Temizle();
            btnGuncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }


        private void dgTumAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuncelle.Enabled = true;
            btnEkle.Enabled = false;
            btnSil.Enabled = true;

            txtAlbumunAdi.Text = dgTumAlbumler.CurrentRow.Cells[1].Value.ToString();
            txtSanatci.Text = dgTumAlbumler.CurrentRow.Cells[2].Value.ToString();
            dtpTarih.Value = Convert.ToDateTime(dgTumAlbumler.CurrentRow.Cells[3].Value);
            txtFiyat.Text = dgTumAlbumler.CurrentRow.Cells[4].Value.ToString();
            txtIndirim.Text = dgTumAlbumler.CurrentRow.Cells[5].Value.ToString();

            if (dgTumAlbumler.CurrentRow.Cells[6].Value.ToString() == "True")
            {
                cbDevamEdiyor.Checked = true;
            }
            else
            {
                cbDevamEtmiyor.Checked = true;
            }
        }

        private void btnListeleriGetir_Click(object sender, EventArgs e)
        {
            dgSatisiDurmus.DataSource = context.Albumler
                    .Where(x => x.SatisDevamEdiyorMu == false)
                    .Select(x => new { x.AlbumAdi, x.AlbumunSanatcisi_Grubu }).ToList();

            dgSatisiDevamEden.DataSource = context.Albumler
                .Where(x => x.SatisDevamEdiyorMu == true)
                    .Select(x => new { x.AlbumAdi, x.AlbumunSanatcisi_Grubu }).ToList();

            dgEnSonEklenen10.DataSource = context.Albumler
                .OrderByDescending(x => x.EklenmeTarihi).Take(10)
                .Select(x => new { x.AlbumAdi, x.AlbumunSanatcisi_Grubu }).ToList();

            dgIndirimdeki.DataSource = context.Albumler
                .Where(x => x.IndirimOrani != 0)
                .Select(x => new { x.AlbumAdi, x.AlbumunSanatcisi_Grubu }).ToList();
        }

        private void Listele()
        {
            dgTumAlbumler.DataSource = context.Albumler.ToList();
            dgTumAlbumler.RowHeadersVisible = false;
            dgTumAlbumler.Columns["AlbumID"].Visible = false;
            dgTumAlbumler.Columns["Album_Kullanicilar"].Visible = false;
            dgTumAlbumler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgTumAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void Temizle()
        {
            txtAlbumunAdi.Clear();
            txtSanatci.Clear();
            txtIndirim.Clear();
            txtFiyat.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
