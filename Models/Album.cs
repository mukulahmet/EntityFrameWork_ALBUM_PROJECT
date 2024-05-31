using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumAdi { get; set; }
        public string AlbumunSanatcisi_Grubu { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public decimal AlbumFiyati { get; set; }
        public double IndirimOrani { get; set; }
        public bool SatisDevamEdiyorMu { get; set; }
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;

        public ICollection<Album_Kullanici> Album_Kullanicilar { get; set; }

    }
}
