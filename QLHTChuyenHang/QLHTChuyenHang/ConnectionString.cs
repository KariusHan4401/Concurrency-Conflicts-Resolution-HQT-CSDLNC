using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHTChuyenHang
{
    // Không cần dùng nữa.Gọi Login.myConnection
    class ConnectionString
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string getConnectionString(string name, string pw)
        {
            return @"Server=LIN-LIN\SQLEXPRESS;Database=QLHTChuyenHang;User Id=" + name + "; Password=" + pw;
        }
    }
}
