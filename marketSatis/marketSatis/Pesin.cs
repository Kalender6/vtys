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
    public partial class Pesin : Form
    {
        public Pesin()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();

        private void Pesin_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID", 150);
            listView1.Columns.Add("Fiyat", 150);
            listView1.Columns.Add("Miktar", 150);

        }

        private void add(String ID, String Fiyat, String Miktar)
        {
            String[] row = { ID, Fiyat, Miktar };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            String ID = listView1.SelectedItems[0].SubItems[0].Text;
            String Fiyat = listView1.SelectedItems[0].SubItems[1].Text;
            String Miktar = listView1.SelectedItems[0].SubItems[2].Text;

            textBox1.Text = ID;
            textBox2.Text = Fiyat;
            textBox3.Text = Miktar;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            add(textBox1.Text, textBox2.Text, textBox3.Text);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem itemSelected in listView1.SelectedItems)
            {
                listView1.Items.Remove(itemSelected);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Sales sales = new Sales();
                sales.UrunID = Convert.ToInt32(listView1.Items[i].SubItems[0].Text);
                sales.UrunFiyat = Convert.ToInt32(listView1.Items[i].SubItems[1].Text);
                sales.UrunMiktar = Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                sales.Ver_Pes = "Pesin";
                DateTime today = DateTime.Now;
                sales.UrunTarih = today.ToString();

                db.Sales.Add(sales);


                var kontrol1 = db.Uruns.AsEnumerable().FirstOrDefault(f => f.UrunID == Convert.ToInt32(listView1.Items[i].SubItems[0].Text));

                if (kontrol1 != null)
                {
                    Uruns guncelle = db.Uruns.AsEnumerable().FirstOrDefault(f => f.UrunID == Convert.ToInt32(listView1.Items[i].SubItems[0].Text));
                    guncelle.UrunMiktar -= Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                }
                else
                {
                    MessageBox.Show("Elde olmayan ürün satılamaz:\n" + (i + 1) + ". ürün stokta yok.");
                }

                db.SaveChanges();

                Uruns kontrol2 = db.Uruns.AsEnumerable().FirstOrDefault(f => f.UrunID == Convert.ToInt32(listView1.Items[i].SubItems[0].Text));
                if (kontrol2.UrunMiktar <= 25)
                {
                    MessageBox.Show(kontrol2.UrunID + "ID'li ürün stoğu 25'den az kaldı.");
                }
            }
            MessageBox.Show("Satış yapıldı.");
        }
    }
}