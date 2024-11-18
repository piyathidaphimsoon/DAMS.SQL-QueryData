
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Text;
using System.Web;

namespace DAMS.SQL_QueryData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        private void connect()
        {
            string server = @".\sqlexpress";
            string db = "Minimart";
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};" + "Integrated Security=True ;Encrypt=False",
                server, db);

            conn = new SqlConnection(strCon);
            conn.Open();
        }
        private void close()

        {
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




            connect();
            string sql = "select *from Products";
            da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}


