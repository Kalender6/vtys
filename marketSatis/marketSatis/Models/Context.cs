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
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Tedarikci> Tedarikci { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Girdii> Girdii { get; set; }
    }
}