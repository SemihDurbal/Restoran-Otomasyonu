using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinOrtacRestaurant
{
    public partial class Masa : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yasinortacrestoranurunler;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu;
        MySqlDataAdapter adapter;
        DataTable dt;

        MySqlConnection conn2 = new MySqlConnection("Server=localhost;Database=yasinortacrestoranmasalar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu2;
        MySqlDataAdapter adapter2;
        DataTable dt1;
        DataTable dt2;
        DataTable dt3;
        DataTable dt4;
        DataTable dt5;
        DataTable dt6;
        DataTable dt7;
        DataTable dt8;

        public String MasaNumarasi;

        public double masa1Hesap = 0;
        public double masa2Hesap = 0;
        public double masa3Hesap = 0;
        public double masa4Hesap = 0;
        public double masa5Hesap = 0;
        public double masa6Hesap = 0;
        public double masa7Hesap = 0;
        public double masa8Hesap = 0;

        public Masa()
        {
            InitializeComponent();
            urunGetir();
            this.FormClosing += new FormClosingEventHandler(this.MyForm_FormClosing);
        }

        public double hesapTopla()
        {
            double toplam = 0;
            try
            {
                foreach (DataGridViewRow row in masadakiUrunlerdgv.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        toplam += Convert.ToDouble(row.Cells[1].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return toplam;
        }

        public void masadakiUrunGetir(String masaNo)
        {
            MasaNumarasi = masaNo;
            try
            {
                if (masaNo.Equals("Masa1"))
                {
                    dt1 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa1", conn2);
                    adapter2.Fill(dt1);
                    masadakiUrunlerdgv.DataSource = dt1;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa2"))
                {
                    dt2 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa2", conn2);
                    adapter2.Fill(dt2);
                    masadakiUrunlerdgv.DataSource = dt2;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa3"))
                {
                    dt3 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa3", conn2);
                    adapter2.Fill(dt3);
                    masadakiUrunlerdgv.DataSource = dt3;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa4"))
                {
                    dt4 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa4", conn2);
                    adapter2.Fill(dt4);
                    masadakiUrunlerdgv.DataSource = dt4;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa5"))
                {
                    dt5 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa5", conn2);
                    adapter2.Fill(dt5);
                    masadakiUrunlerdgv.DataSource = dt5;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa6"))
                {
                    dt6 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa6", conn2);
                    adapter2.Fill(dt6);
                    masadakiUrunlerdgv.DataSource = dt6;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa7"))
                {
                    dt7 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa7", conn2);
                    adapter2.Fill(dt7);
                    masadakiUrunlerdgv.DataSource = dt7;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa8"))
                {
                    dt8 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa8", conn2);
                    adapter2.Fill(dt8);
                    masadakiUrunlerdgv.DataSource = dt8;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void urunGetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * from urunler", conn);
            adapter.Fill(dt);
            urunListesidgv.DataSource = dt;
            conn.Close();
        }

        private void MASA_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MasaNumarasi.Equals("Masa1"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa1");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa2"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa2");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa3"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa3");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa4"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa4");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa5"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa5");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa6"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa6");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa7"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa7");
                hesap.Visible = true;
                this.Visible = false;
            }
            if (MasaNumarasi.Equals("Masa8"))
            {
                HesapAl hesap = new HesapAl();
                hesap.masadakiUrunGetir("Masa8");
                hesap.Visible = true;
                this.Visible = false;
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void masadakiUrunlerdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaMenu_2_ ana = new AnaMenu_2_();
            ana.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MasaNumarasi.Equals("Masa1"))
                {
                    String sorgu2 = "INSERT into masa1 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa2"))
                {
                    String sorgu2 = "INSERT into masa2 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa3"))
                {
                    String sorgu2 = "INSERT into masa3 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa4"))
                {
                    String sorgu2 = "INSERT into masa4 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa5"))
                {
                    String sorgu2 = "INSERT into masa5 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa6"))
                {
                    String sorgu2 = "INSERT into masa6 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa7"))
                {
                    String sorgu2 = "INSERT into masa7 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa8"))
                {
                    String sorgu2 = "INSERT into masa8 (Urunler, Fiyati) values (@urunIsmi , @urunFiyati)";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", urunListesidgv.CurrentRow.Cells[0].Value.ToString());
                    sqlKomutu2.Parameters.AddWithValue("@urunFiyati", urunListesidgv.CurrentRow.Cells[1].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
            }
            catch (Exception ex)
            {

            }
        }

        public int urunSayiControl(String urunIsmi)
        {
            int sayii = 0;
            try
            {
                foreach (DataGridViewRow row in masadakiUrunlerdgv.Rows)
                {
                    if (urunIsmi.Equals(masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString()))
                    {
                        sayii++;
                    }
                }
            }
            catch (Exception ex) 
            {
                
            }
            if(sayii > 1)
            {
                return sayii;
            }


            return sayii;
        }

        private void cikarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MasaNumarasi.Equals("Masa1"))
                {
                    String sorgu2 = "DELETE from masa1 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa2"))
                {
                    String sorgu2 = "DELETE from masa2 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa3"))
                {
                    String sorgu2 = "DELETE from masa3 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa4"))
                {
                    String sorgu2 = "DELETE from masa4 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa5"))
                {
                    String sorgu2 = "DELETE from masa5 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa6"))
                {
                    String sorgu2 = "DELETE from masa6 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa7"))
                {
                    String sorgu2 = "DELETE from masa7 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
                if (MasaNumarasi.Equals("Masa8"))
                {
                    String sorgu2 = "DELETE from masa8 WHERE Urunler = @urunIsmi LIMIT 1";
                    sqlKomutu2 = new MySqlCommand(sorgu2, conn2);
                    sqlKomutu2.Parameters.AddWithValue("@urunIsmi", masadakiUrunlerdgv.CurrentRow.Cells[0].Value.ToString());
                    conn2.Open();
                    sqlKomutu2.ExecuteNonQuery();
                    conn2.Close();
                    masadakiUrunGetir(MasaNumarasi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silinecek Ürün Kalmadı...");
            }
        }




        private void hesapLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dikkat masa kapatılacak ve masadaki tüm ürünler silinecektir.", "Mesaj Kutusu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (MasaNumarasi.Equals("Masa1"))
                    {
                        string sorgu = "DELETE FROM `masa1`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa2"))
                    {
                        string sorgu = "DELETE FROM `masa2`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa3"))
                    {
                        string sorgu = "DELETE FROM `masa3`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa4"))
                    {
                        string sorgu = "DELETE FROM `masa4`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa5"))
                    {
                        string sorgu = "DELETE FROM `masa5`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa6"))
                    {
                        string sorgu = "DELETE FROM `masa6`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa7"))
                    {
                        string sorgu = "DELETE FROM `masa7`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    if (MasaNumarasi.Equals("Masa8"))
                    {
                        string sorgu = "DELETE FROM `masa8`";
                        sqlKomutu2 = new MySqlCommand(sorgu, conn2);
                        conn2.Open();
                        sqlKomutu2.ExecuteNonQuery();
                        conn2.Close();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
