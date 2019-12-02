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

        public DataTable getKhuVuc()
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getKhuVuc();

            return dt;
        }
        public DataTable getNhaPhanPhoi()
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getNhaPhanPhoi();

            return dt;
        }
        public int deleteKhachHang(string maKhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.deleteKhachHang(maKhachHang);

            return dt;
        }
        public int deleteKhuVuc(string maKhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.deleteKhuVuc(maKhachHang);

            return dt;
        }
        public int deleteNhaPhanPhoi(string maKhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.deleteNhaPhanPhoi(maKhachHang);

            return dt;
        }
        public bool insertKhuVuc(DTOKhuVuc KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            bool dt = um.insertKhuVuc(KhachHang);

            return dt;
        }
        public bool insertKhachHang(DTOKhachHang KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            bool dt = um.insertKhachHang(KhachHang);

            return dt;
        }

        public int updateKhuVuc(DTOKhuVuc KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.updateKhuVuc(KhachHang);

            return dt;
        }

        public int updateKhachHang(DTOKhachHang KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.updateKhachHang(KhachHang);

            return dt;
        }

        public bool insertNhaPhanPhoi(DTONhaPhanPhoi KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            bool dt = um.insertNhaPhanPhoi(KhachHang);

            return dt;
        }

        public int updateNhaPhanPhoi(DTONhaPhanPhoi KhachHang)
        {
            DALDoiTac um = new DALDoiTac();

            int dt = um.updateNhaPhanPhoi(KhachHang);

            return dt;
        }
        public DTOKhachHang getKhachHangDetail(string mahanghoa)
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getKhachHangDetail(mahanghoa);
            DTOKhachHang a = new DTOKhachHang();
            a.MAKH = dt.Rows[0]["MAKH"].ToString();
            a.MaKhuVuc = dt.Rows[0]["MaKhuVuc"].ToString();
            a.HOTEN = dt.Rows[0]["HOTEN"].ToString();
            a.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            a.MaSoThue = dt.Rows[0]["MaSoThue"].ToString();
            a.Fax = dt.Rows[0]["Fax"].ToString();
            a.SODT = dt.Rows[0]["SODT"].ToString();
            a.Mobile = dt.Rows[0]["Mobile"].ToString();
            a.Email = dt.Rows[0]["Email"].ToString();
            a.Website = dt.Rows[0]["Website"].ToString();
            a.TaiKhoan = dt.Rows[0]["TaiKhoan"].ToString();
            a.NganHang = dt.Rows[0]["NganHang"].ToString();
            a.GioiHanNo = dt.Rows[0]["GioiHanNo"].ToString();
            a.NoHienTai = dt.Rows[0]["NoHienTai"].ToString();
            a.ChietKhau = dt.Rows[0]["ChietKhau"].ToString();
            a.NickYahoo = dt.Rows[0]["NickYahoo"].ToString();
            a.NguoiLienHe = dt.Rows[0]["NguoiLienHe"].ToString();
            a.NickSkype = dt.Rows[0]["NickSkype"].ToString();
            a.ConQuanLy =Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            a.DaiLy = Convert.ToBoolean(dt.Rows[0]["DaiLy"].ToString());
            a.KhachLe = Convert.ToBoolean(dt.Rows[0]["KhachLe"].ToString());
            return a;
        }
        public DTONhaPhanPhoi getNhaPhanPhoiDetail(string mahanghoa)
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getNhaPhanPhoiDetail(mahanghoa);
            DTONhaPhanPhoi a = new DTONhaPhanPhoi();
            a.MaNPP = dt.Rows[0]["MaNPP"].ToString();
            a.MaKhuVuc = dt.Rows[0]["MaKhuVuc"].ToString();
            a.TenNPP = dt.Rows[0]["TenNPP"].ToString();
            a.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            a.MaSoThue = dt.Rows[0]["MaSoThue"].ToString();
            a.Fax = dt.Rows[0]["Fax"].ToString();
            a.SODT = dt.Rows[0]["SODT"].ToString();
            a.Mobile = dt.Rows[0]["Mobile"].ToString();
            a.Email = dt.Rows[0]["Email"].ToString();
            a.Website = dt.Rows[0]["Website"].ToString();
            a.TaiKhoan = dt.Rows[0]["TaiKhoan"].ToString();
            a.NganHang = dt.Rows[0]["NganHang"].ToString();
            a.GioiHanNo = dt.Rows[0]["GioiHanNo"].ToString();
            a.NoHienTai = dt.Rows[0]["NoHienTai"].ToString();
            a.ChietKhau = dt.Rows[0]["ChietKhau"].ToString();
            a.NguoiLienHe = dt.Rows[0]["NguoiLienHe"].ToString();
            a.ChucVu = dt.Rows[0]["ChucVu"].ToString();
            a.ConQuanLy = Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            return a;
        }
        public DTOKhuVuc getKhuVucDetail(string mahanghoa)
        {
            DALDoiTac um = new DALDoiTac();

            DataTable dt = um.getKhuVucDetail(mahanghoa);
            DTOKhuVuc a = new DTOKhuVuc();
            a.MaKhuVuc = dt.Rows[0]["MaKhuVuc"].ToString();
            a.TenKhuVuc = dt.Rows[0]["TenKhuVuc"].ToString();
            a.GhiChu = dt.Rows[0]["GhiChu"].ToString();
            a.ConQuanLy =Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            return a;
        }
    }
}
