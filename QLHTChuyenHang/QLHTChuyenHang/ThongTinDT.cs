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
    public partial class ThongTinDT : Form
    {
        //public static string connectionString = @"Data Source=LIN-LIN\SQLEXPRESS;Initial Catalog=QLHTChuyenHang;Integrated Security=True; User Id=Meg; Password=TK000021";
        //public static string connectionString = @"Server=LIN-LIN\SQLEXPRESS;Database=QLHTChuyenHang;User Id=Meg;Password=TK000021";
        
        public ThongTinDT()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditDT_Click(object sender, EventArgs e)
        {
            //USP_DT_TTCASE1
            try
            {
                connection.Open();
                //string query = "EXEC USP_DT_TTCASE1 N'"+ txtTenDD+ "', '"+ txtMaCN + "', N'" + txtDuong +"'";
                string query = "UPDATE UV_CN_DOITAC SET ";
                string condition = " WHERE MACN = '";
                //SET DUONG = N'" +txtDuong.Text+ "' WHERE MACN = '"+ txtMaCN.Text+ "'  UPDATE DOI_TAC SET NGUOI_DAI_DIEN = N'"+txtTenDD.Text+"' WHERE MADT = 'DT000001' ";
                if (txtMaCN.Text != "")
                {
                    if (txtDuong.Text != "") query += "DUONG = N'" + txtDuong.Text + "', ";
                    if (txtPhuong.Text != "") query += "PHUONG = N'" + txtPhuong.Text + "', ";
                    if (txtQuan.Text != "") query += "QUAN = N'" + txtQuan.Text + "', ";
                    if (txtTinh.Text != "") query += "THANH_PHO = N'" + txtTinh.Text + "', ";
                    query += "MACN = MACN";
                    condition += txtMaCN.Text + "'";
                    SqlCommand cmd = new SqlCommand(query + condition, connection);
                    cmd.ExecuteNonQuery();
                }
                query = "UPDATE UV_TTDOITAC SET ";
                if (txtTenDT.Text != "") query += "TEN_DOI_TAC =N'" + txtTenDT.Text + "', ";
                if (txtTenDD.Text != "") query += "NGUOI_DAI_DIEN = N'" + txtTenDD.Text + "',";
                query += " MADT = MADT";
                SqlCommand cmd2 = new SqlCommand(query, connection);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thông tin thành công!");
                connection.Close();

                LoadData("SELECT * FROM UV_TTDOITAC", dataGridView2);
                LoadData("SELECT * FROM UV_CN_DOITAC", dataGridView1);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT CHI_NHANH VALUES('" + txtMaCN.Text + "', 'DT000001', NULL, N'" + txtDuong.Text + "', N'" + txtPhuong.Text + "', N'" + txtQuan.Text + "', N'" + txtTinh.Text + "')";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm chi nhánh thành công!");
                connection.Close();
                LoadData("SELECT * FROM UV_CN_DOITAC", dataGridView2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }
        private void ThongTinDT_Load(object sender, EventArgs e)
        {
            //load toàn bộ dữ liệu cho người dùng
            LoadData("SELECT * FROM UV_TTDOITAC", dataGridView1);
            LoadData("SELECT * FROM UV_CN_DOITAC", dataGridView2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
