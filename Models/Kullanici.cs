using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string KullaniciAdSoyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public ICollection<Album_Kullanici> Album_Kullanicilar { get; set; }

    }
}
