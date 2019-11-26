using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALKhoHang
    {
        public DataTable getKho()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from Kho");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getDonViTinh()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from DonViTinh");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getNhomHang()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from NhomHang");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getHangHoa()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from SANPHAM");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getHangHoaDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from SANPHAM where MaSP = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getTiGia()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from Kho");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public int removeHangHoa(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from SANPHAM where MaSP = '{mahanghoa}'");
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
