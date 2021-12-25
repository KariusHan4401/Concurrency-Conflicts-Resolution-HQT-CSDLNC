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
using System.Threading;

namespace QLHTChuyenHang
{
    public partial class DoanhThuDT : Form
    {
        public DoanhThuDT()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(Login.myConnection);
        void LoadDoanhThu()
        {
            try
            {
                connection.Open();
                string query = "EXEC USP_DT_XEMDOANHTHU";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                gridViewDT.DataSource = ds.Tables[0];
                gridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                gridViewDSDH.DataSource = ds.Tables[1];
                gridViewDSDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            LoadDoanhThu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void DoanhThuDT_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnXemInfo_Click(object sender, EventArgs e)
        {
            ThongTinDT TTDT = new ThongTinDT();
            this.Hide();
            TTDT.ShowDialog();
            this.Show();
        }
    }
}
