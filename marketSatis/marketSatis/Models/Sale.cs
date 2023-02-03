using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Sale
    {
        [Key]
        public int SatisID { get; set; }

        public int UrunID { get; set; }
        public int UrunFiyat { get; set; }
        public int UrunMiktar { get; set; }
        public String UrunTarih { get; set; }
        public String Ver_Pes { get; set; }
    }
}
