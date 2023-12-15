using MaterialSkin.Controls;
using veritabanidemo1.Services;
using System.Data.SqlClient;


namespace veritabanidemo1
{
    public partial class CustomerForm : MaterialForm
    {
        public CustomerForm()
        {
            InitializeComponent();
            DefaultMaterialFormTheme.UseTheme(this);
        }

        SqlConnection baglan = new SqlConnection("Data Source = 176.53.65.202\\MSSQLSERVER2019; Initial Catalog = senrecep_veritabaniproje; User ID = senrecep_recepsen; Password=Lq~406nj");

    }
}