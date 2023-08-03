using Microsoft.Data.SqlClient;
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

namespace Temizlik_Otomasyonu
{
    public partial class Satislar : Form
    {
        public Satislar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Temizlik;Integrated Security=True;Trust Server Certificate=True");
        verilerTableAdapters.satisTableAdapter satislar = new verilerTableAdapters.satisTableAdapter();
        DataTable tablo = new DataTable();
        private void listele(string sql)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(sql, baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();


        }
        private void Satislar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            listele("select ucret from satis");
            ucrettoplami();
        }

        private void ucrettoplami()
        {
            int ucrettoplami = 0;
            for (int i = 0;i<dataGridView1.Rows.Count; i++)
            {
                ucrettoplami += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
                
            }
            lbl_toplamucret.Text = ucrettoplami.ToString();  
        }
    }
}
