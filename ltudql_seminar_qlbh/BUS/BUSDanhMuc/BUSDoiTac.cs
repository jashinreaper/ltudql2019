using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;
namespace BUS
{
    public class BUSDoiTac
    {
        public DataTable getKhachHang()
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getKhachHang();

            return dt;
        }
        public int deleteKhachHang(string maKhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.deleteKhachHang(maKhachHang);

            return dt;
        }

        public bool insertKhachHang(DTOKhachHang KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            bool dt = um.insertKhachHang(KhachHang);

            return dt;
        }

        public int updateKhachHang(DTOKhachHang KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.updateKhachHang(KhachHang);

            return dt;
        }

        public DTOKhachHang getKhachHangDetail(string mahanghoa)
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getKhachHangDetail(mahanghoa);
            DTOKhachHang a = new DTOKhachHang();
            a.id = dt.Rows[0]["id"].ToString();
            a.MAKH = dt.Rows[0]["MAKH"].ToString();
            a.HOTEN = dt.Rows[0]["HOTEN"].ToString();
            a.DCHI = dt.Rows[0]["DCHI"].ToString();
            a.SODT = dt.Rows[0]["SODT"].ToString();
            return a;
        }

    }
}
