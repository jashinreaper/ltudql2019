using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSKhoHang
    {
        public DataTable getHangHoa()
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getHangHoa();

            return dt;
        }
        public DataTable getKho()
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getKho();

            return dt;
        }
        public DataTable getBangDonVi()
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getBanDonVi();

            return dt;
        }
        public DataTable getBangNhomHang()
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getBangNhomHang();

            return dt;
        }
        public DTOKho getKhoDetail(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getKhoDetail(mahanghoa);
            DTOKho a = new DTOKho();
            a.MaKho = dt.Rows[0]["MaKho"].ToString();
            a.TenKho = dt.Rows[0]["TenKho"].ToString();
            a.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            a.Fax = dt.Rows[0]["Fax"].ToString();
            a.SODT = dt.Rows[0]["SODT"].ToString();
            a.Mobile = dt.Rows[0]["Mobile"].ToString();
            a.Email = dt.Rows[0]["Email"].ToString();
            a.NguoiQuanLy = dt.Rows[0]["NguoiQuanLy"].ToString();
            a.NguoiLienHe = dt.Rows[0]["NguoiLienHe"].ToString();
            a.DienGiai = dt.Rows[0]["DienGiai"].ToString();
            a.ConQuanLy =Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            return a;
        }
        public DTODonViTinh getBanDonViDetail(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getBanDonViDetail(mahanghoa);
            DTODonViTinh a = new DTODonViTinh();
            a.MaDV = dt.Rows[0]["MaDV"].ToString();
            a.TenDV = dt.Rows[0]["TenDV"].ToString();
            a.GhiChu = dt.Rows[0]["GhiChu"].ToString();
            a.ConQuanLy = Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            return a;
        }
        public DTONhomHang getBangNhomHangDetail(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getBangNhomHangDetail(mahanghoa);
            DTONhomHang a = new DTONhomHang();
            a.MaNH = dt.Rows[0]["MaNH"].ToString();
            a.TenNH = dt.Rows[0]["TenNH"].ToString();
            a.GhiChu = dt.Rows[0]["GhiChu"].ToString();
            a.ConQuanLy = Convert.ToBoolean(dt.Rows[0]["ConQuanLy"].ToString());
            return a;
        }
        public DTOHangHoa getHangHoaDetail(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getHangHoaDetail(mahanghoa);
            DTOHangHoa a = new DTOHangHoa();
            a.id = dt.Rows[0]["id"].ToString();
            a.VatTu =Convert.ToBoolean(dt.Rows[0]["VatTu"].ToString());
            a.DichVu = Convert.ToBoolean(dt.Rows[0]["DichVu"].ToString());
            a.MaKhoHang = dt.Rows[0]["MaKhoHang"].ToString();
            a.PhanLoai = dt.Rows[0]["PhanLoai"].ToString();
            a.MaHH = dt.Rows[0]["MaHH"].ToString();
            a.TENHH = dt.Rows[0]["TENHH"].ToString();
            a.MaVachNSX = dt.Rows[0]["MaVachNSX"].ToString();
            a.MaDonVi = dt.Rows[0]["MaDonVi"].ToString();
            a.XuatXu = dt.Rows[0]["XuatXu"].ToString();
            a.Thue = dt.Rows[0]["Thue"].ToString();
            a.TonKhoToiThieu = dt.Rows[0]["TonKhoToiThieu"].ToString();
            a.TonKhoHienTai = dt.Rows[0]["TonKhoHienTai"].ToString();
            a.MaNhaCungCap = dt.Rows[0]["MaNhaCungCap"].ToString();
            a.GiaMua = dt.Rows[0]["GiaMua"].ToString();
            a.GiaSi = dt.Rows[0]["GiaSi"].ToString();
            a.GiaLe = dt.Rows[0]["GiaLe"].ToString();
            return a;
        }
        public int removeHangHoa(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.removeHangHoa(mahanghoa);

            return dt;
        }
        public int removeBangDonVi(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.removeBangDonVi(mahanghoa);

            return dt;
        }
        public int removeKho(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.removeKho(mahanghoa);

            return dt;
        }
        public int removeBangNhomHang(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.removeBangNhomHang(mahanghoa);

            return dt;
        }

        public bool insertHangHoa(DTOHangHoa hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            bool dt = um.insertHangHoa(hanghoa);

            return dt;
        }

        public int updateHangHoa(DTOHangHoa hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.updateHangHoa(hanghoa);

            return dt;
        }
        public bool insertBangDonVi(DTODonViTinh hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            bool dt = um.insertBangDonVi(hanghoa);

            return dt;
        }

        public int updateBangDonVi(DTODonViTinh hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.updateBangDonVi(hanghoa);

            return dt;
        }
        public bool insertKho(DTOKho hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            bool dt = um.insertKho(hanghoa);

            return dt;
        }

        public int updateKho(DTOKho hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.updateKho(hanghoa);

            return dt;
        }

        public bool insertBangNhomHang(DTONhomHang hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            bool dt = um.insertBangNhomHang(hanghoa);

            return dt;
        }

        public int updateBangNhomHang(DTONhomHang hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.updateBangNhomHang(hanghoa);

            return dt;
        }
    }
}
