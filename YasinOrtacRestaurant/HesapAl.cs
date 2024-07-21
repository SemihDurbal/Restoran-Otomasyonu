using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinOrtacRestaurant
{
    public partial class HesapAl : Form
    {
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

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yasinortacrestorangunlukkar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu;
        MySqlDataAdapter adapter;

        public String MasaNumarasi;

        public double masa1Hesap = 0;
        public double masa2Hesap = 0;
        public double masa3Hesap = 0;
        public double masa4Hesap = 0;
        public double masa5Hesap = 0;
        public double masa6Hesap = 0;
        public double masa7Hesap = 0;
        public double masa8Hesap = 0;

        public double hesapTopla()
        {
            double toplam = 0;
            try
            {
                foreach (DataGridViewRow row in hesapUrunlerdgv.Rows)
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
                    hesapUrunlerdgv.DataSource = dt1;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa2"))
                {
                    dt2 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa2", conn2);
                    adapter2.Fill(dt2);
                    hesapUrunlerdgv.DataSource = dt2;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa3"))
                {
                    dt3 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa3", conn2);
                    adapter2.Fill(dt3);
                    hesapUrunlerdgv.DataSource = dt3;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa4"))
                {
                    dt4 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa4", conn2);
                    adapter2.Fill(dt4);
                    hesapUrunlerdgv.DataSource = dt4;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa5"))
                {
                    dt5 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa5", conn2);
                    adapter2.Fill(dt5);
                    hesapUrunlerdgv.DataSource = dt5;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa6"))
                {
                    dt6 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa6", conn2);
                    adapter2.Fill(dt6);
                    hesapUrunlerdgv.DataSource = dt6;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa7"))
                {
                    dt7 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa7", conn2);
                    adapter2.Fill(dt7);
                    hesapUrunlerdgv.DataSource = dt7;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
                if (masaNo.Equals("Masa8"))
                {
                    dt8 = new DataTable();
                    conn2.Open();
                    adapter2 = new MySqlDataAdapter("SELECT * from masa8", conn2);
                    adapter2.Fill(dt8);
                    hesapUrunlerdgv.DataSource = dt8;
                    conn2.Close();
                    hesapLabel.Text = hesapTopla().ToString();
                }
            }
            catch (Exception ex)
            {

            }
        }

        public HesapAl()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(this.MyForm_FormClosing);
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaMenu_2_ ana = new AnaMenu_2_();
            ana.Visible = true;
        }

        private void HesapAl_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String sorgu2 = "INSERT into gunlukkar (SatilanToplam) values (@masaToplam)";
            sqlKomutu = new MySqlCommand(sorgu2, conn);
            sqlKomutu.Parameters.AddWithValue("@masaToplam", hesapLabel.Text);
            conn.Open();
            sqlKomutu.ExecuteNonQuery();
            conn.Close();

            DialogResult result = MessageBox.Show("Hesap Ödenicektir Onaylıyor musunuz ?", "Mesaj Kutusu", MessageBoxButtons.YesNo);
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
