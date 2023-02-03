using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }

        public String UrunAd { get; set; }
        public int UrunFiyat { get; set; }
        public int UrunMiktar { get; set; }
        public int UrunBarkod { get; set; }

    }
}
