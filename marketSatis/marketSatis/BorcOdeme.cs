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
    public partial class BorcOdeme : Form
    {
        public BorcOdeme()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            Musteris borc = db.Musteris.AsEnumerable().FirstOrDefault(f => f.MusteriID == Convert.ToInt32(textBox1.Text));
            if (borc != null)
            {
                textBox2.Text = borc.MusteriBorc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteris borcode = db.Musteris.AsEnumerable().FirstOrDefault(f => f.MusteriID == Convert.ToInt32(textBox1.Text));
            if (borcode != null)
            {
                borcode.MusteriBorc -= int.Parse(textBox3.Text);
            }

            db.SaveChanges();
        }
    }
}
