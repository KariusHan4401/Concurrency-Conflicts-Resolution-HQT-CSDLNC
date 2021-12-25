using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void ThongTinDT_Load(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelMAIN.Controls.Clear();
            panelMAIN.Controls.Add(new ThongTin_CN());
        }

        private void btnTTDT_Click(object sender, EventArgs e)
        {
            panelMAIN.Controls.Clear();
            panelMAIN.Controls.Add(new ThongTin_DT());
        }

        private void btnCSTT_Click(object sender, EventArgs e)
        {
            panelMAIN.Controls.Clear();
            panelMAIN.Controls.Add(new ChinhSuaTT());
        }
    }
}
