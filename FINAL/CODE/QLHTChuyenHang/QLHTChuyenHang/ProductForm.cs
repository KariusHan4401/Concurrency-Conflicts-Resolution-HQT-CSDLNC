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
    public partial class ProductForm : Form
    {
        SqlConnection connection = new SqlConnection(Login.myConnection);
        public ProductForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (prodID.Text == "" || prodName.Text == "")
                {
                    MessageBox.Show("Missing Information!! Please fill it up!!");
                }
                else
                {
                    connection.Open();
                    var query = "EXEC USP_CAPNHAT_SP'" + prodID.Text + "', '" + categoryCB.Text + "', N'" + prodName.Text + "', N'" + prodDes.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated!!");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProductForm_Load();
        }

        private void refreshBT_Click(object sender, EventArgs e)
        {
            ProductForm_Load();
        }
        void ProductForm_Load()
        {
            try
            {
                var query = "SELECT * FROM SAN_PHAM";
                connection.Open();
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
            }
        }

        void Category_Load()
        {
            try
            {
                var query = "SELECT * FROM HANG_HOA";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                Category.DataSource = dataTable;
                Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fillCategoryCombo()
        {
            try
            {
                connection.Open();
                var query = "SELECT MALH FROM HANG_HOA";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader read;
                read = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("MALH", typeof(string));
                dataTable.Load(read);
                categoryCB.ValueMember = "MALH";
                categoryCB.DataSource = dataTable;

                read = cmd.ExecuteReader();
                DataTable dataTable_2 = new DataTable();
                dataTable_2.Columns.Add("MALH", typeof(string));
                dataTable_2.Load(read);
                cateCB.ValueMember = "MALH";
                cateCB.DataSource = dataTable_2;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cateBT_Click(object sender, EventArgs e)
        {
            Category_Load();
        }

        private void cateCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string cate = cateCB.Text;
                var query = "SELECT * FROM SAN_PHAM WHERE MALH = '" + cate + "'";
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
            }
        }

        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void prodBT_Click(object sender, EventArgs e)
        {
            ProductForm_Load();
            Category_Load();
            fillCategoryCombo();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            ProductForm_Load();
            Category_Load();
            fillCategoryCombo();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}