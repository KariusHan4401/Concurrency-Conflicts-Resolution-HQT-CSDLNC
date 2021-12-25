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
    public partial class ChinhSuaTT_CN : UserControl
    {
        public ChinhSuaTT_CN()
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
        private void btnEditCN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaCN.Text != "")
                {
                    connection.Open();

                    string sqlMACN = "SELECT * FROM UV_CN_DOITAC WHERE MACN = '" + txtMaCN.Text + "'";

                    SqlCommand cmd1 = new SqlCommand(sqlMACN, connection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);

                    //kiem tra MACN co ton tai khong
                    if (dataTable1.Rows.Count == 0)
                    {
                        MessageBox.Show("MACN khong thuoc doi tac");
                        connection.Close();
                        return;
                    }

                    string query = "UPDATE UV_CN_DOITAC SET ";
                    string condition = " WHERE MACN = '";
                    int count = 0;

                    if (txtDuong.Text != "")
                    {
                        query += "DUONG = N'" + txtDuong.Text;
                        count += 1;
                    }

                    if (txtPhuong.Text != "")
                    {
                        if (count != 0)
                            query += "', PHUONG = N'" + txtPhuong.Text;
                        else
                            query += "PHUONG = N'" + txtPhuong.Text;
                        count += 1;
                    }

                    if (txtQuan.Text != "")
                    {
                        if (count != 0)
                            query += "', QUAN = N'" + txtQuan.Text;
                        else
                            query += "QUAN = N'" + txtQuan.Text;
                        count += 1;
                    }

                    if (txtTinh.Text != "")
                    {
                        if (count != 0)
                            query += " ', THANH_PHO = N'" + txtTinh.Text;
                        else
                            query += " THANH_PHO = N'" + txtTinh.Text;
                        count += 1;
                    }

                    if (count != 0) { 
                        query += "'";

                        condition += txtMaCN.Text + "'";
                        query += condition;
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }

                    connection.Close();
                }     
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            txtMaCN.Clear();
            txtDuong.Clear();
            txtPhuong.Clear();
            txtQuan.Clear();
            txtTinh.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string MADT, MAHD = "";
                if (txtMaCN.Text != "")
                {
                    connection.Open();

                    string sqlMACN = "SELECT * FROM CHI_NHANH WHERE MACN = '" + txtMaCN.Text + "'";

                    SqlCommand cmd1 = new SqlCommand(sqlMACN, connection);
                    SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(cmd1);
                    DataTable dataTable1 = new DataTable();
                    sqlDataAdapter1.Fill(dataTable1);

                    //kiem tra MACN co ton tai khong
                    if (dataTable1.Rows.Count > 0)
                    {
                        MessageBox.Show("MACN da ton tai");
                        connection.Close();
                        return;
                    }

                    string query = "INSERT UV_CN_DOITAC(MACN, MADT, MAHD, DUONG, PHUONG, QUAN, THANH_PHO) VALUES ('" + txtMaCN.Text + "', 'DT000007', 'HD000007', N'" + txtDuong.Text + "', N'" + txtPhuong.Text + "', N'" + txtQuan.Text + "', N'" + txtTinh.Text + "')";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm chi nhánh thành công!");
                    connection.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            txtMaCN.Clear();
            txtDuong.Clear();
            txtPhuong.Clear();
            txtQuan.Clear();
            txtTinh.Clear();
        }
    }
}
