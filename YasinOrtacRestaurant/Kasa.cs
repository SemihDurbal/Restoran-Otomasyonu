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
    public partial class Kasa : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=yasinortacrestorangunlukkar;Uid=root;Pwd='';");
        MySqlCommand sqlKomutu;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Kasa()
        {
            InitializeComponent();
            toplamHesaplar();
            gunlukKarLabel.Text = hesapTopla().ToString();
        }

        void toplamHesaplar()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("SELECT * from gunlukkar", conn);
            adapter.Fill(dt);
            toplamHesaplardgv.DataSource = dt;
            conn.Close();
        }

        public double hesapTopla()
        {
            double toplam = 0;
            try
            {
                foreach (DataGridViewRow row in toplamHesaplardgv.Rows)
                {
                    toplam += Convert.ToDouble(row.Cells[0].Value);
                    
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            return toplam;
        }

        private void gunlukKarLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
