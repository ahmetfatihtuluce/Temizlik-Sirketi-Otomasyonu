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

namespace Temizlik_Otomasyonu
{
    public partial class Listele : Form
    {
        public Listele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Temizlik;Integrated Security=True;Trust Server Certificate=True");
        verilerTableAdapters.satisTableAdapter satislar = new verilerTableAdapters.satisTableAdapter();
        DataTable tablo = new DataTable();
       


        private void listele(string sql)
        {      
               
              tablo.Clear();
              
              baglanti.Open();
              SqlDataAdapter adtr = new SqlDataAdapter(sql,baglanti);
              adtr.Fill(tablo);
              dataGridView1.DataSource = tablo;
              baglanti.Close();
            
            
        }
        
        
        
        
        private void Listele_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Listele_Load(object sender, EventArgs e)
        {

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            
            
           
            
            listele("select * from satis");
        }
        
        private void btn_sil_Click(object sender, EventArgs e)
        {
            
            int id1 = 0;
            baglanti.Open();


            try
            {
                id1 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string sorgu = "Delete from satis where kayitId='" + id1 + "'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                
                komut.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

            }
            catch (Exception)
            {

                MessageBox.Show("Hata!");
            }
            baglanti.Close();
        }
    }
}
