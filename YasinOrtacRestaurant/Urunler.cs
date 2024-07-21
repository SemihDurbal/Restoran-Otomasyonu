using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinOrtacRestaurant
{
    public partial class Urunler : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yasinortacrestoranurunler;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu;
        MySqlDataAdapter adapter;
        DataTable dt;
        public Urunler()
        {
            InitializeComponent();
            TabloGetir();
            TabloBosMu();
        }

        public void TabloGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * from urunler", conn);
            adapter.Fill(dt);
            urunTablosu.DataSource = dt;
            conn.Close();
        }

        public void UrunEkleme()
        {
            try
            {
                if (isimTextBoxCheck() == true && fiyatTextBoxCheck() == true)
                {
                    if (AyniUrunCheck())
                    {
                        String sorgu = "INSERT into urunler (Urun_Ismi, Urun_Fiyati) values (@urunIsmi , @urunFiyati)";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        sqlKomutu.Parameters.AddWithValue("@urunIsmi", urunismitxtbox.Text);
                        sqlKomutu.Parameters.AddWithValue("@urunFiyati", urunfiyatitxtbox.Text);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                        TabloGetir();
                    }
                    else
                    {
                        throw new OutOfMemoryException();
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Bu Üründen Zaten Elinizde Bulunuyor...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Gerekli Tüm Alanları Doldurunuz...");
            }
        }

        public void UrunSilme()
        {
            try
            {
                tablodanUrunGetir();
                string sorgu = "DELETE from urunler WHERE Urun_Ismi = @Urunismi AND Urun_Fiyati = @Urunfiyati";
                sqlKomutu = new MySqlCommand(sorgu, conn);
                sqlKomutu.Parameters.AddWithValue("@Urunismi", urunismitxtbox.Text);
                sqlKomutu.Parameters.AddWithValue("@Urunfiyati", urunfiyatitxtbox.Text);
                conn.Open();
                sqlKomutu.ExecuteNonQuery();
                conn.Close();
                TabloGetir();
                MessageBox.Show("Ürün Silindi...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Silinemedi...");
            }
        }

        public void UrunDuzenleme()
        {
            try
            {
                string sorgu2 = "UPDATE urunler SET Urun_Fiyati = @urunfiyat WHERE Urun_Ismi = @urunismi";
                sqlKomutu = new MySqlCommand(sorgu2, conn);
                if (String.IsNullOrEmpty(urunismitxtbox.Text) && String.IsNullOrEmpty(urunfiyatitxtbox.Text))
                {
                    throw new Exception();
                }
                else
                {
                    sqlKomutu.Parameters.AddWithValue("@urunismi", urunismitxtbox.Text);
                    sqlKomutu.Parameters.AddWithValue("@urunfiyat", urunfiyatitxtbox.Text);
                    conn.Open();
                    sqlKomutu.ExecuteNonQuery();
                    conn.Close();
                    TabloGetir();
                    MessageBox.Show("Ürün Güncellendi...");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ürün Güncellenemedi...");
            }
        }


        public bool isimTextBoxCheck()
        {
            try
            {
                if (string.IsNullOrEmpty(urunismitxtbox.Text))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
        }
        public bool fiyatTextBoxCheck()
        {          
            try
            {
                if (string.IsNullOrEmpty(urunfiyatitxtbox.Text))
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void Urunler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunEkleme();
        }

        private void urunDuzenleButton_Click(object sender, EventArgs e)
        {
            UrunDuzenleme();
        }

        private void urunSilButton_Click(object sender, EventArgs e)
        {
            UrunSilme();
        }
        
        public bool TabloBosMu()
        {
            if(urunTablosu.RowCount <= 0)
            {
                MessageBox.Show("Tabloda Hiç Ürün Bulunmuyor");
                return false;
            }
            return true;
        }
        public bool AyniUrunCheck()
        {
            try
            {
                foreach(DataGridViewRow row in urunTablosu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(urunismitxtbox.Text.ToString())) 
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex) 
            {
                return true;
            }
            return true;
        }

        public void tablodanUrunGetir()
        {
            if (urunTablosu.RowCount > 1)
            {
                urunismitxtbox.Text = urunTablosu.CurrentRow.Cells[0].Value.ToString();
                urunfiyatitxtbox.Text = urunTablosu.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void urunTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tablodanUrunGetir();
        }
    }
}
