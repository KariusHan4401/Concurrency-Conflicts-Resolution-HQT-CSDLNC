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
    public partial class DoanhThuDT : Form
    {
        public DoanhThuDT()
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            LoadData("SET TRAN ISOLATION LEVEL REPEATABLE READ  SELECT * FROM UV_DOANHTHUDT", gridViewDT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT MADH, PHI_SAN_PHAM, PHI_GIAM, PHI_SAN_PHAM - PHI_GIAM AS THANH_TIEN, HINH_THUC_THANH_TOAN FROM UV_DHDOITAC WHERE TRANG_THAI = N'Đã giao hàng'";
            LoadData(query, gridViewDSDH);
        }

        private void DoanhThuDT_Load(object sender, EventArgs e)
        {
            LoadData("SET TRAN ISOLATION LEVEL REPEATABLE READ  SELECT * FROM UV_DOANHTHUDT", gridViewDT);

        }
    }
}
