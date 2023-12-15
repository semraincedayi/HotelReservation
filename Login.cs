using MaterialSkin.Controls;
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
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            Services.DefaultMaterialFormTheme.UseTheme(this);
        }

        SqlConnection baglan = new SqlConnection("Data Source = 176.53.65.202\\MSSQLSERVER2019; Initial Catalog = senrecep_veritabaniproje; User ID = senrecep_recepsen; Password=Lq~406nj");


        private void btn_forgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen emailinize gelen bağlantıya tıklayarak parolanızı sıfırlayınız.", "Parola Sıfırlama", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }


    }
}
