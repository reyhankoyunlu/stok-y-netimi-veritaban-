using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter veri;

        public Form1()
        {
            InitializeComponent();
        }

        void urunGetir()
        {
            baglanti = new SqlConnection("server=.; Initial Catalog=spot; Integrated Security=SSPI;");
            baglanti.Open();
            veri = new SqlDataAdapter("SELECT *FROM urunler", baglanti);
            DataTable tablo = new DataTable();
            veri.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO urunler(UrunAdi,StokAdet,Fiyat) VALUES (@UrunAdi,@StokAdet,@Fiyat)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@UrunAdi", txt_ad.Text);
            komut.Parameters.AddWithValue("@StokAdet", txt_stok.Text);
            komut.Parameters.AddWithValue("@Fiyat", txt_fiyat.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urunGetir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            urunGetir();
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 58)
            {
                e.Handled = false;

            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.", "HATA!!!");
                e.Handled = true;
            }
        }

        private void txt_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if  ( (int)e.KeyChar>=47 && (int)e.KeyChar <=58)
            {
                e.Handled = false;

            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir değer giriniz.", "HATA!!!");
                e.Handled = true;
            }
        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE urunler SET UrunAdi=@UrunAdi, StokAdet=@StokAdet, Fiyat=@Fiyat WHERE UrunID= @UrunID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("UrunID", Convert.ToInt32(txt_urun.Text));
            komut.Parameters.AddWithValue("@UrunAdi", txt_ad.Text);
            komut.Parameters.AddWithValue("@StokAdet", txt_stok.Text);
            komut.Parameters.AddWithValue("@Fiyat", txt_fiyat.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            urunGetir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_urun.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_stok.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_fiyat.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            DialogResult sonuc;
            sonuc = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?","ONAY", MessageBoxButtons.YesNo);
            if (sonuc == DialogResult.Yes)
            {
                string sorgu = "DELETE FROM urunler WHERE UrunID=@UrunID";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("UrunID", Convert.ToInt32(txt_urun.Text));
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                urunGetir();
                MessageBox.Show("Kayıt silme işlemi başarılı","SONUÇ");
            }
            else
            {
                MessageBox.Show("Kayıt silme işlemi iptal edildi", "SONUÇ");
            }
                
        }

        private void txt_fiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
