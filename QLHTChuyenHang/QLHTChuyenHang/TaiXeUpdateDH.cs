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
    public partial class TaiXeUpdateDH : Form
    {
        public TaiXeUpdateDH()
        {
            InitializeComponent();
        }
        public IList<TaiXeUpdateDH> dsDonHang = new List<TaiXeUpdateDH>();
        public DataTable dataTable { get; set; }

        SqlConnection connection = new SqlConnection(Login.myConnection);
        void LoadData()
        {
            try
            {
                string query1 = "SELECT * FROM UV_DHTAIXEDANHAN";
                string query2 = "SELECT * FROM UV_TTDHTAIXE";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query1, connection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridViewDSDH.DataSource = dataTable;
                gridViewDSDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                cbMaDH.DataSource = dataTable;
                cbMaDH.DisplayMember = "MADH";
                cbMaDH.ValueMember = "MADH";
                cmd = new SqlCommand(query2, connection);
                sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter.Fill(dataTable1);
                gridViewTTDH.DataSource = dataTable1;
                gridViewTTDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void TaiXeUpdateDH_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void gridViewDSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDaNhan_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbTrangThai.SelectedIndex == -1 || cbMaDH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin!");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "EXEC USP_TX_DAGIAOHANG N'" + cbTrangThai.SelectedItem.ToString() + "', '" + dataTable.Rows[cbMaDH.SelectedIndex].ItemArray[0].ToString() + "', '" + dateTimePicker1.Value + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }

            }
            LoadData();

        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbMaDH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
