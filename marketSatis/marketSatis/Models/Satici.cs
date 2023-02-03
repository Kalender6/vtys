using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Satici
    {
        [Key]
        public int SaticiID { get; set; }

        public String Username { get; set; }
        public String Password { get; set; }
    }
}
