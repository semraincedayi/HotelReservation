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
using System.Collections;

namespace veritabanidemo1
{
    public partial class ManagerForm : MaterialForm
    {
        public ManagerForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        SqlConnection baglan = new SqlConnection("Data Source = 176.53.65.202\\MSSQLSERVER2019; Initial Catalog = senrecep_veritabaniproje; User ID = senrecep_recepsen; Password=Lq~406nj");

        private void materialButton1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string Select = "SELECT * FROM BeklenenDolulukRaporTablosu WHERE CheckIn<DATEADD(DAY , 30 , GETDATE()) AND YEAR(CheckIn) = YEAR(GETDATE()) AND CheckOut > GETDATE() ORDER BY RoomID ASC";
            using var commad = new SqlCommand(Select, baglan);
            var dr = new SqlDataAdapter(commad);
            var ds = new DataSet();
            dr.Fill(ds, "Data");
            dgv_doluluk.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string Select = "SELECT * FROM BeklenenOdaGelirRaporTablosu WHERE CheckIn<DATEADD(MONTH , +1 , GETDATE()) AND YEAR(CheckIn)= YEAR(GETDATE())";
            SqlDataAdapter da = new SqlDataAdapter(Select, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv_odagelir.DataSource = dt;
            baglan.Close();
        }

        private void btn_tabanUpdate_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string Select = "UPDATE MinimumPrices SET MinimumPrice = @MinimumPrice";
            SqlCommand cmd = new SqlCommand(Select, baglan);
            cmd.Parameters.AddWithValue("MinimumPrice" , tb_Taban.Text);
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
    }
}
