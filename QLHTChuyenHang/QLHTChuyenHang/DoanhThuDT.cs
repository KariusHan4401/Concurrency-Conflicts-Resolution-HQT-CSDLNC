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
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            SqlTransaction transaction;

            transaction = connection.BeginTransaction("XemDoanhThu");

            command.Connection = connection;
            command.Transaction = transaction;

            try
            {
                // Lỗi Phantom Read
                //command.CommandText =
                //"SET TRAN ISOLATION LEVEL REPEATABLE READ  SELECT * FROM UV_DOANHTHUDT";

                // Fix Lỗi
                command.CommandText =
                        "SET TRAN ISOLATION LEVEL SERIALIZABLE  SELECT * FROM UV_DOANHTHUDT";
                SqlDataAdapter sqlDA = new SqlDataAdapter(command);
                DataTable dt1 = new DataTable();
                sqlDA.Fill(dt1);
                gridViewDT.DataSource = dt1;
                gridViewDT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Thread.Sleep(5000);
                command.CommandText =
                    "SELECT MADH, PHI_SAN_PHAM, PHI_GIAM, PHI_SAN_PHAM - PHI_GIAM AS THANH_TIEN, HINH_THUC_THANH_TOAN FROM UV_DHDOITAC WHERE TRANG_THAI = N'Đã giao hàng'";
                sqlDA = new SqlDataAdapter(command);
                DataTable dt2 = new DataTable();
                sqlDA.Fill(dt2);
                gridViewDSDH.DataSource = dt2;
                gridViewDSDH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message);
                }
            }

            connection.Close();
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
    }
}
