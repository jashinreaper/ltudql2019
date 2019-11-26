using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
namespace DAL
{
    class DALDoiTac:CommonQuery
    {
        public DataTable getKhuVuc()
        {
            string query = string.Format($"select * from KHUVUC");
            DataTable dt = GetData(query);
            return dt;
        }
        public DataTable getKhachHang()
        {
            string query = string.Format($"select * from KHACHHANG");
            DataTable dt = GetData(query);
            return dt;
        }
        public DataTable getNhaPhanPhoi()
        {
            string query = string.Format($"select * from NHAPHANPHOI");
            DataTable dt = GetData(query);
            return dt;
        }

        public int deleteKhuVuc(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from SANPHAM where MaSP = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int deleteKhachHang(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from SANPHAM where MaSP = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int deleteNhaPhanPhoi(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from SANPHAM where MaSP = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }

        public bool insertHangHoa(DTOHangHoa hanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from SANPHAM where MaSP = '{hanghoa.MASP}'");
            if (cq.ExecSelectedCount(query) > 0)
                return false;

            query = string.Format($"insert into SANPHAM values('{hanghoa.MASP}','{hanghoa.TENSP}'," +
                $"'{hanghoa.DVT}','{hanghoa.NUOCSX}','{hanghoa.GIA}')");
            int dt = cq.ExecNonQuery(query);
            return true;
        }

        public int updateHangHoa(DTOHangHoa hanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"update SANPHAM set TENSP='{hanghoa.TENSP}',DVT='{hanghoa.DVT}',NUOCSX='{hanghoa.NUOCSX}',GIA='{hanghoa.GIA}' where MaSP = '{hanghoa.MASP}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }

    }
}
