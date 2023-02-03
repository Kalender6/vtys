using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Stock
    {
        [Key]
        public int StockID { get; set; }

        public int UrunID { get; set; }
        public int UrunMiktarı { get; set; }
    }
}
