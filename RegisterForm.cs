using MaterialSkin.Controls;
using veritabanidemo1.Services;
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

namespace veritabanidemo1
{
    public partial class RegisterForm : MaterialForm
    {
        public RegisterForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        SqlConnection baglan = new SqlConnection("Data Source = 176.53.65.202\\MSSQLSERVER2019; Initial Catalog = senrecep_veritabaniproje; User ID = senrecep_recepsen; Password=Lq ~406nj");

        private void VerileriGoster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            baglan.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Customer (Email,Password) VALUES ('" + tb_email.Text.ToString() + "','" + tb_password.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
