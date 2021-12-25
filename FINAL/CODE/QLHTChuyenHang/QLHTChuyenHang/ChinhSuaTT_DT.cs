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
    public partial class ChinhSuaTT_DT : UserControl
    {
        public ChinhSuaTT_DT()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEditDT_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string query = "";
                int count = 0;

                if (txtTenDD.Text != "")
                {
                    query = "EXEC USP_DT_NDD N'" + txtTenDD.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query, connection);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }

                if (txtQuanDD.Text != "")
                {
                    query = "EXEC USP_DT_QuanNDD N'" + txtQuanDD.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, connection);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }

                query = "UPDATE UV_TTDOITAC SET ";

                if (txtTenDT.Text != "")
                {
                    query += "TEN_DOI_TAC = N'" + txtTenDT.Text;
                    count += 1;
                }

                if (txtEMAIL.Text != "")
                {
                    if (count != 0)
                        query += "', EMAIL = N'" + txtEMAIL.Text;
                    else
                        query += "EMAIL = N'" + txtEMAIL.Text;
                    count += 1;
                }

                if (txtSDT.Text != "")
                {
                    if (count != 0)
                        query += "', SDT = '" + txtSDT.Text;
                    else
                        query += "SDT = '" + txtSDT.Text;
                    count += 1;
                }

                if (txtDuong.Text != "")
                {
                    if (count != 0)
                        query += "', DUONG = N'" + txtDuong.Text;
                    else
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

                if (txtTP.Text != "")
                {
                    if (count != 0)
                        query += "', THANH_PHO = N'" + txtTP.Text;
                    else
                        query += "THANH_PHO = N'" + txtTP.Text;
                    count += 1;
                }

                if (txtTinhDD.Text != "")
                {
                    if (count != 0)
                        query += "', TP_NDD = N'" + txtTinhDD.Text;
                    else
                        query += "TP_NDD = N'" + txtTinhDD.Text;
                    count += 1;
                }

                if (count != 0)
                {
                    query += "'";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cập nhật thông tin thành công!");
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

            txtTenDT.Clear();
            txtEMAIL.Clear();
            txtSDT.Clear();
            txtDuong.Clear();
            txtPhuong.Clear();
            txtQuan.Clear();
            txtTP.Clear();
            txtTenDD.Clear();
            txtQuanDD.Clear();
            txtTinhDD.Clear();
        }
    }
}
