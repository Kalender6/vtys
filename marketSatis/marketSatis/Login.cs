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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        stokdbEntities db = new stokdbEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (db.Saticis.Where(u => u.Username == textBox1.Text && u.Password == textBox2.Text).Count() > 0)
            {
                MessageBox.Show("Giriş Başarılı.");
                Main MainScreen = new Main();
                this.Hide();
                MainScreen.Show();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
