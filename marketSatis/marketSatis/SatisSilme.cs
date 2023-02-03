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
    public partial class SatisSilme : Form
    {
        public SatisSilme()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();

        private void SatisSilme_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Sales.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (db.Saticis.Where(u => u.Password == textBox2.Text).Count() > 0)
            {
                Sales tbl = db.Sales.AsEnumerable().First(w => w.SatisID == int.Parse(textBox1.Text));
                db.Sales.Remove(tbl);
                db.SaveChanges();
                MessageBox.Show("Silme Başarılı.");
                dataGridView1.DataSource = db.Sales.ToList();
            }
            else
            {
                MessageBox.Show("Şifre yanlış!");
            }
        }
    }
}
