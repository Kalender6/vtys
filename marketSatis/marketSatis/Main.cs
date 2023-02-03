using marketSatis.Models;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunlerStok UrunList = new UrunlerStok();
            UrunList.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri MusteriList = new Musteri();
            MusteriList.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veresiye VeresiyeSatis = new Veresiye();
            VeresiyeSatis.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pesin PesinSatis = new Pesin();
            PesinSatis.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorcOdeme BorcOde = new BorcOdeme();
            BorcOde.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SatisSilme SatisSil = new SatisSilme();
            SatisSil.Show();
        }
    }
}
