using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marketSatis
{
    public partial class UrunlerStok : Form
    {
        public UrunlerStok()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();

        private void Urunler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Uruns.ToList();
            openFileDialog1.Title = "Dosya Seçiniz";
            openFileDialog1.FileName = "Dosya Seç";
            openFileDialog1.InitialDirectory = @"C:";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Uruns tbl = new Uruns();
            tbl.UrunAd = textBox1.Text;
            tbl.UrunFiyat = Convert.ToInt16(textBox2.Text);
            tbl.UrunMiktar = Convert.ToInt16(textBox3.Text);
            tbl.UrunBarkod = Convert.ToInt16(textBox4.Text);
            
            db.Uruns.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Eklendi lütfen listeleyin.");
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Uruns.ToList();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Uruns tbl = db.Uruns.First(w => w.UrunAd == textBox1.Text);
            db.Uruns.Remove(tbl);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = File.ReadLines(openFileDialog1.FileName).ToList();
                textBox1.Text = lines[0];
                textBox2.Text = lines[1];
                textBox3.Text = lines[2];
                textBox4.Text = lines[3];
            }
        }
    }
}
