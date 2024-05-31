using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Album_Kullanici
    {
        public int Album_KullaniciID { get; set; }
        public int AlbumID { get; set; }
        public int KullaniciID { get; set; }

        public Album Album { get; set; }
        public Kullanici Kullanici { get; set; }

    }
}
