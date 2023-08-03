using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temizlik_Otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Temizlik;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            HizmetEkle hizmetEkle = new HizmetEkle();
            hizmetEkle.Show();
            this.Hide();
            
        }

        private void btn_lisitele_Click(object sender, EventArgs e)
        {
            Listele listele = new Listele();
            listele.Show();
            this.Hide();
        }

        private void btn_satislar_Click(object sender, EventArgs e)
        {
            Satislar satislar = new Satislar();
            satislar.Show();
            this.Hide();
        }
    }
}
