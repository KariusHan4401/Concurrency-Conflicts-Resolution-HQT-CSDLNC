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
    public partial class HomePage : Form
    {
        SqlConnection connection = new SqlConnection(Login.myConnection);
        public HomePage()
        {
            InitializeComponent();
            HomePage_Load();
        }
        
        private void Reload_Click(object sender, EventArgs e)
        {
            HomePage_Load();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                var stringFind = txtSearch.Text;
                var query = "exec USP_TIMSPTEN N'" + stringFind + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                Products.DataSource = dataTable;
                Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        void HomePage_Load()
        {
            try
            {
                connection.Open();
                var query = "SELECT * FROM SAN_PHAM";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                Products.DataSource = dataTable;
                Products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
