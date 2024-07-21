using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YasinOrtacRestaurant
{
    public partial class AnaMenu_2_ : Form
    {
        
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yasinortacrestoranmasalar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu;
        MySqlDataAdapter adapter;
        DataTable dt;

        MySqlConnection conn2 = new MySqlConnection("Server=localhost;Database=yasinortacrestoranacikmasalar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu2;
        MySqlDataAdapter adapter2;
        DataTable dt2;

        MySqlConnection conn3 = new MySqlConnection("Server=localhost;Database=yasinortacrestorangunlukkar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu3;
        MySqlDataAdapter adapter3;
        DataTable dt3;


        
        void acikMasaTablo()
        {
            dt2 = new DataTable();
            conn2.Open();
            adapter2 = new MySqlDataAdapter("SELECT * from acikmasa", conn2);
            adapter2.Fill(dt2);
            acikMasaTablosu.DataSource = dt2;
            conn2.Close();
        }

        public bool AcikmasaCheck(String masaNo)
        {
            try
            {
                foreach (DataGridViewRow row in acikMasaTablosu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(masaNo))
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

        public AnaMenu_2_()
        {
            InitializeComponent();
            acikMasaTablo();
            if (masa1IsOpen() == true && AcikmasaCheck("Masa 1"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 1");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa1IsOpen() == false && !(AcikmasaCheck("Masa 1")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 1'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa2IsOpen() == true && AcikmasaCheck("Masa 2"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 2");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
                acikMasaTablosu.Update();
            }
            else if (masa2IsOpen() == false && !(AcikmasaCheck("Masa 2")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 2'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa3IsOpen() == true && AcikmasaCheck("Masa 3"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 3");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa3IsOpen() == false && !(AcikmasaCheck("Masa 3")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 3'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa4IsOpen() == true && AcikmasaCheck("Masa 4"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 4");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa4IsOpen() == false && !(AcikmasaCheck("Masa 4")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 4'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa5IsOpen() == true && AcikmasaCheck("Masa 5"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 5");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa5IsOpen() == false && !(AcikmasaCheck("Masa 5")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 5'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa6IsOpen() == true && AcikmasaCheck("Masa 6"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 6");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa6IsOpen() == false && !(AcikmasaCheck("Masa 6")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 6'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa7IsOpen() == true && AcikmasaCheck("Masa 7"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 7");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa7IsOpen() == false && !(AcikmasaCheck("Masa 7")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 7'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            if (masa8IsOpen() == true && AcikmasaCheck("Masa 8"))
            {
                String sorgu1 = "INSERT into acikmasa (masaNo) values (@masaNumarasi)";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                sqlKomutu2.Parameters.AddWithValue("@masaNumarasi", "Masa 8");
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }
            else if (masa8IsOpen() == false && !(AcikmasaCheck("Masa 8")))
            {
                String sorgu1 = "DELETE from acikmasa WHERE masaNo = 'Masa 8'";
                sqlKomutu2 = new MySqlCommand(sorgu1, conn2);
                conn2.Open();
                sqlKomutu2.ExecuteNonQuery();
                conn2.Close();
                acikMasaTablo();
            }


            this.FormClosing += new FormClosingEventHandler(this.MyForm_FormClosing);
        }

        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Visible = true;
        }

        public bool masa1IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa1", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool masa2IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa2", conn);
                adapter.Fill(dt);
                conn.Close();
                
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa3IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa3", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa4IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa4", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa5IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa5", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa6IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa6", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa7IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa7", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool masa8IsOpen()
        {
            try
            {
                dt = new DataTable();
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * from masa8", conn);
                adapter.Fill(dt);
                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        private void AnaMenu_2__Load(object sender, EventArgs e)
        {
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            kasa.Visible = true;
        }

        private void masa1Button_Click(object sender, EventArgs e)
        {
            Masa masa1 = new Masa();
            masa1.masadakiUrunGetir("Masa1");
            masa1.Visible = true;
            this.Visible = false;
        }

        private void masa2Button_Click(object sender, EventArgs e)
        {
            Masa masa2 = new Masa();
            masa2.masadakiUrunGetir("Masa2");
            masa2.Visible = true;
            this.Visible = false;
        }

        private void masa3Button_Click(object sender, EventArgs e)
        {
            Masa masa3 = new Masa();
            masa3.masadakiUrunGetir("Masa3");
            masa3.Visible = true;
            this.Visible = false;
        }

        private void masa4Button_Click(object sender, EventArgs e)
        {
            Masa masa4 = new Masa();
            masa4.masadakiUrunGetir("Masa4");
            masa4.Visible = true;
            this.Visible = false;
        }

        private void masa5Button_Click(object sender, EventArgs e)
        {
            Masa masa5 = new Masa();
            masa5.masadakiUrunGetir("Masa5");
            masa5.Visible = true;
            this.Visible = false;
        }

        private void masa6Button_Click_1(object sender, EventArgs e)
        {
            Masa masa6 = new Masa();
            masa6.masadakiUrunGetir("Masa6");
            masa6.Visible = true;
            this.Visible = false;
        }

        private void masa7Button_Click_1(object sender, EventArgs e)
        {
            Masa masa7 = new Masa();
            masa7.masadakiUrunGetir("Masa7");
            masa7.Visible = true;
            this.Visible = false;
        }

        private void masa8Button_Click_1(object sender, EventArgs e)
        {
            Masa masa8 = new Masa();
            masa8.masadakiUrunGetir("Masa8");
            masa8.Visible = true;
            this.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Visible = true;
        }

        private void acikMasaTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dikkat Uygulama Kapatılacaktır !\nTüm masalar kapatılacaktır ayrıca gün sonu alınıp \ngünlük kar sıfırlanacaktır.", "Mesaj Kutusu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (!AcikmasaCheck("Masa 1"))
                    {
                        string sorgu = "DELETE FROM `masa1`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 2"))
                    {
                        string sorgu = "DELETE FROM `masa2`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 3"))
                    {
                        string sorgu = "DELETE FROM `masa3`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 4"))
                    {
                        string sorgu = "DELETE FROM `masa4`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 5"))
                    {
                        string sorgu = "DELETE FROM `masa5`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 6"))
                    {
                        string sorgu = "DELETE FROM `masa6`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 7"))
                    {
                        string sorgu = "DELETE FROM `masa7`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (!AcikmasaCheck("Masa 8"))
                    {
                        string sorgu = "DELETE FROM `masa8`";
                        sqlKomutu = new MySqlCommand(sorgu, conn);
                        conn.Open();
                        sqlKomutu.ExecuteNonQuery();
                        conn.Close();
                    }
                    string sorgu3 = "DELETE FROM gunlukkar";
                    sqlKomutu3 = new MySqlCommand(sorgu3,conn3);
                    conn3.Open();
                    sqlKomutu3.ExecuteNonQuery();
                    conn3.Close();
                    Close();
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}