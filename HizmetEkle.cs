using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temizlik_Otomasyonu.verilerTableAdapters;

namespace Temizlik_Otomasyonu
{
    public partial class HizmetEkle : Form
    {
        public HizmetEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Temizlik;Integrated Security=True;Trust Server Certificate=True");
        // verilerTableAdapters.satisTableAdapter satis2 = new verilerTableAdapters.satisTableAdapter();
        
        private void HizmetEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void HizmetEkle_Load(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            try
            {   

                String sorgu = "INSERT INTO satis (isim, hizmet, adres, telefon, ucret) VALUES (@isim, @hizmet, @adres, @telefon, @ucret)";
                SqlCommand komut = new SqlCommand(sorgu,baglanti);
                komut.Parameters.AddWithValue("@isim",txt_isim.Text);
                komut.Parameters.AddWithValue("@hizmet", txt_hizmet.Text);
                komut.Parameters.AddWithValue("@adres", txt_adres.Text);
                komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                komut.Parameters.AddWithValue("@ucret", txt_ucret.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Eklendi!");

                foreach (TextBox item in this.Controls.OfType<TextBox>())
                {
                    item.Text = "";
                }
                txt_adres.Text = "";
                
            }
            catch (Exception)
            {

                MessageBox.Show("Hata!");
            }    
            baglanti.Close();
               
               
            
            
            

                
            
            
            
        }
    }
}
