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

namespace QLHTChuyenHang
{
    public partial class ThongTin_CN : UserControl
    {
        public ThongTin_CN()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Login.myConnection);
        void LoadData(string query, DataGridView dataGrid)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void ThongTin_CN_Load(object sender, EventArgs e)
        {
            LoadData("SELECT * FROM UV_CN_DOITAC", dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
