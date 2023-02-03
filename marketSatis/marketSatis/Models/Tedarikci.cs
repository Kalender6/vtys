using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Tedarikci
    {
        [Key]
        public int TedarikciID { get; set; }

        public String TedarikciAd { get; set; }
        public String TedarikciSoyad { get; set; }

        public int TedarikciBorc { get; set; }
        public int IrsaliyeNo { get; set; }
    }
}
