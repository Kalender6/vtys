using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketSatis
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Saticis.ToList();
        }
    }
}
