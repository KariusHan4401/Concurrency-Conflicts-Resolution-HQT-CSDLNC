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
    public partial class Login : Form
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public static string myConnection { get; set; }
        public Login()
        {
            InitializeComponent();
        }
        public string getConnectionString(string name, string pw)
        {
            return @"Server=LIN-LIN\SQLEXPRESS;Database=QLHTChuyenHang;User Id=" + name + "; Password=" + pw;

        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPw.Text == "")
            {
                MessageBox.Show("Missing username or password!");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Choose your role!");
            }
            else
            {
                SqlConnection connection = new SqlConnection(getConnectionString(txtUsername.Text, txtPw.Text));
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM UV_TTDOITAC";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    MessageBox.Show("Login successed!");
                    username = txtUsername.Text;
                    password = txtPw.Text;
                    myConnection = getConnectionString(txtUsername.Text, txtPw.Text);
                    ThongTinDT ttdt = new ThongTinDT();
                    ttdt.Show();
                    this.Hide();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

        }
    }
}
