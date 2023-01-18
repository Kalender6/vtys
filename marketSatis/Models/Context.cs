using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marketSatis.Models
{
    public class Context : DbContext
    {
        public DbSet<Satici> Satici { get; set; }
        public DbSet<Urun> Urun { get; set; }

    }
}
