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
    public partial class ChinhSuaTT : UserControl
    {
        public ChinhSuaTT()
        {
            InitializeComponent();
        }

        private void btnCSTT_DT_Click(object sender, EventArgs e)
        {
            panelCSTT.Controls.Clear();
            panelCSTT.Controls.Add(new ChinhSuaTT_DT());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelCSTT.Controls.Clear();
            panelCSTT.Controls.Add(new ChinhSuaTT_CN());
        }
    }
}
