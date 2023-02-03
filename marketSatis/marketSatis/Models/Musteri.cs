using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        public String Adi { get; set; }
        public String Soyadi { get; set; }

        public int MusteriBorc { get; set; }
    }
}
