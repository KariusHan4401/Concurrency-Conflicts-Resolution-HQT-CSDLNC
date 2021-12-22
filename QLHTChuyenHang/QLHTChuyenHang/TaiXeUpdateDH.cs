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

        private void TaiXeUpdateDH_Load(object sender, EventArgs e)
        {
            LoadData("SELECT MADH, MADT, TRANG_THAI, PHI_SAN_PHAM, PHI_VAN_CHUYEN, PHI_GIAM, TONG_PHI FROM UV_DHTAIXE", gridViewDSDH);
        }

        private void gridViewDSDH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDaNhan_Click(object sender, EventArgs e)
        {
            LoadData("SELECT MADH, MADT, TRANG_THAI, PHI_SAN_PHAM, PHI_VAN_CHUYEN, PHI_GIAM, TONG_PHI FROM UV_DHTAIXE", gridViewDSDH);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaDH.Text == "" || cbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin!");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "EXEC USP_TX_DAGIAOHANG N'" + cbTrangThai.SelectedItem.ToString() + "', '" + txtMaDH.Text + "', '" + dateTimePicker1.Value + "'";
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

            LoadData("SELECT MADH, MADT, TRANG_THAI, PHI_SAN_PHAM, PHI_VAN_CHUYEN, PHI_GIAM, TONG_PHI FROM UV_DHTAIXE", gridViewDSDH); 
        }

        private void txtMaDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
