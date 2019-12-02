using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDuLieu: CommonQuery
    {
        public void backupDB(string path)
        {
            string query = string.Format($"BACKUP DATABASE QuanLyBanHang TO DISK = '{path}'");
            GetData(query);
        }
    }
}
