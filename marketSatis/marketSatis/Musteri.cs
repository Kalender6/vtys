using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace marketSatis
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();
        private void Musteri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Musteris.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteris tbl = new Musteris();
            
            tbl.Adi = (textBox2.Text);
            tbl.Soyadi = (textBox3.Text);
            tbl.MusteriBorc = 0;
            db.Musteris.Add(tbl);
            db.SaveChanges();
            dataGridView1.DataSource = db.Musteris.ToList();
        }
    }
}
