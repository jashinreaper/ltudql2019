using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DALDoiTac:CommonQuery
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
        public DataTable getKhachHangDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from KHACHHANG where MAKH = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getKhuVucDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from KHUVUC where MaKhuVuc = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getNhaPhanPhoiDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from NHAPHANPHOI where MaNPP = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public int deleteKhuVuc(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from KHUVUC where MaKhuVuc = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int deleteKhachHang(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from KHACHHANG where MAKH = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int deleteNhaPhanPhoi(string id)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from NHAPHANPHOI where MaNPP = '{id}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }

        public bool insertKhuVuc(DTOKhuVuc hanghoa)
        {
            string query = string.Format($"select * from KHUVUC where MaKhuVuc='{hanghoa.MaKhuVuc}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into KHUVUC values (@tendonvi,@diachi,@dienthoai,@fax)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@tendonvi", SqlDbType.Text).Value = hanghoa.MaKhuVuc;
                _cmd.Parameters.Add("@diachi", SqlDbType.Text).Value = hanghoa.TenKhuVuc;
                _cmd.Parameters.Add("@dienthoai", SqlDbType.Text).Value = hanghoa.GhiChu;
                _cmd.Parameters.Add("@fax", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
                OpenConn();
                var i = _cmd.ExecuteNonQuery();
                CloseConn();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int updateKhuVuc(DTOKhuVuc hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update KHUVUC set MaKhuVuc=@tendonvi,TenKhuVuc=@diachi,GhiChu=@dienthoai,ConQuanLy=@fax where MaKhuVuc=@tendonvi";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@tendonvi", SqlDbType.NVarChar).Value = hanghoa.MaKhuVuc;
            _cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = hanghoa.TenKhuVuc;
            _cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar).Value = hanghoa.GhiChu;
            _cmd.Parameters.Add("@fax", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }

        public bool insertKhachHang(DTOKhachHang hanghoa)
        {
            string query = string.Format($"select * from KHACHHANG where MAKH='{hanghoa.MAKH}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into KHACHHANG values (@MAKH,@MaKhuVuc,@HOTEN,@DiaChi,@MaSoThue,@Fax,@SODT,@Mobile,@Email,@Website,@TaiKhoan,@NganHang,@GioiHanNo,@NoHienTai,@ChietKhau,@NickYahoo,@NguoiLienHe,@NickSkype,@ConQuanLy,@DaiLy,@KhachLe)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MAKH", SqlDbType.Text).Value = hanghoa.MAKH;
                _cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Text).Value = hanghoa.MaKhuVuc;
                _cmd.Parameters.Add("@HOTEN", SqlDbType.Text).Value = hanghoa.HOTEN;
                _cmd.Parameters.Add("@DiaChi", SqlDbType.Text).Value = hanghoa.DiaChi;
                _cmd.Parameters.Add("@MaSoThue", SqlDbType.Text).Value = hanghoa.MaSoThue;
                _cmd.Parameters.Add("@Fax", SqlDbType.Text).Value = hanghoa.Fax;
                _cmd.Parameters.Add("@SODT", SqlDbType.Text).Value = hanghoa.SODT;
                _cmd.Parameters.Add("@Mobile", SqlDbType.Text).Value = hanghoa.Mobile;
                _cmd.Parameters.Add("@Email", SqlDbType.Text).Value = hanghoa.Email;
                _cmd.Parameters.Add("@TaiKhoan", SqlDbType.Text).Value = hanghoa.TaiKhoan;
                _cmd.Parameters.Add("@NganHang", SqlDbType.Text).Value = hanghoa.NganHang;
                _cmd.Parameters.Add("@GioiHanNo", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GioiHanNo);
                _cmd.Parameters.Add("@NoHienTai", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.NoHienTai);
                _cmd.Parameters.Add("@ChietKhau", SqlDbType.Float).Value = Convert.ToDouble(hanghoa.ChietKhau);
                _cmd.Parameters.Add("@NickYahoo", SqlDbType.Text).Value = hanghoa.NickYahoo;
                _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.Text).Value = hanghoa.NguoiLienHe;
                _cmd.Parameters.Add("@Website", SqlDbType.Text).Value = hanghoa.Website;
                _cmd.Parameters.Add("@NickSkype", SqlDbType.Text).Value = hanghoa.NickSkype;
                _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
                _cmd.Parameters.Add("@DaiLy", SqlDbType.Bit).Value = hanghoa.DaiLy;
                _cmd.Parameters.Add("@KhachLe", SqlDbType.Bit).Value = hanghoa.KhachLe;
                OpenConn();
                var i = _cmd.ExecuteNonQuery();
                CloseConn();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int updateKhachHang(DTOKhachHang hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update KHACHHANG set MAKH=@MAKH,MaKhuVuc=@MaKhuVuc,HOTEN=@HOTEN,DiaChi=@DiaChi,MaSoThue=@MaSoThue,Fax=@Fax,SODT=@SODT,Mobile=@Mobile,Email=@Email,Website=@Website,TaiKhoan=@TaiKhoan,NganHang=@NganHang,GioiHanNo=@GioiHanNo,NoHienTai=@NoHienTai,ChietKhau=@ChietKhau,NickYahoo=@NickYahoo,NguoiLienHe=@NguoiLienHe,NickSkype=@NickSkype,ConQuanLy=@ConQuanLy,DaiLy=@DaiLy,KhachLe=@KhachLe where MAKH=@MAKH ";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MAKH", SqlDbType.NVarChar).Value = hanghoa.MAKH;
            _cmd.Parameters.Add("@MaKhuVuc", SqlDbType.NVarChar).Value = hanghoa.MaKhuVuc;
            _cmd.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = hanghoa.HOTEN;
            _cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hanghoa.DiaChi;
            _cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar).Value = hanghoa.MaSoThue;
            _cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = hanghoa.Fax;
            _cmd.Parameters.Add("@SODT", SqlDbType.NVarChar).Value = hanghoa.SODT;
            _cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = hanghoa.Mobile;
            _cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = hanghoa.Email;
            _cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = hanghoa.TaiKhoan;
            _cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar).Value = hanghoa.NganHang;
            _cmd.Parameters.Add("@GioiHanNo", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GioiHanNo);
            _cmd.Parameters.Add("@NoHienTai", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.NoHienTai);
            _cmd.Parameters.Add("@ChietKhau", SqlDbType.Float).Value = Convert.ToDouble(hanghoa.ChietKhau);
            _cmd.Parameters.Add("@NickYahoo", SqlDbType.NVarChar).Value = hanghoa.NickYahoo;
            _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar).Value = hanghoa.NguoiLienHe;
            _cmd.Parameters.Add("@NickSkype", SqlDbType.NVarChar).Value = hanghoa.NickSkype;
            _cmd.Parameters.Add("@Website", SqlDbType.NVarChar).Value = hanghoa.Website;
            _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            _cmd.Parameters.Add("@DaiLy", SqlDbType.Bit).Value = hanghoa.DaiLy;
            _cmd.Parameters.Add("@KhachLe", SqlDbType.Bit).Value = hanghoa.KhachLe;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }
        public bool insertNhaPhanPhoi(DTONhaPhanPhoi hanghoa)
        {
            string query = string.Format($"select * from NHAPHANPHOI where MaNPP='{hanghoa.MaNPP}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into NHAPHANPHOI values (@MaNPP,@MaKhuVuc,@TenNPP,@DiaChi,@MaSoThue,@Fax,@SODT,@Mobile,@Email,@Website,@TaiKhoan,@NganHang,@GioiHanNo,@NoHienTai,@ChietKhau,@NguoiLienHe,@ChucVu,@ConQuanLy)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MaNPP", SqlDbType.Text).Value = hanghoa.MaNPP;
                _cmd.Parameters.Add("@MaKhuVuc", SqlDbType.Text).Value = hanghoa.MaKhuVuc;
                _cmd.Parameters.Add("@TenNPP", SqlDbType.Text).Value = hanghoa.TenNPP;
                _cmd.Parameters.Add("@DiaChi", SqlDbType.Text).Value = hanghoa.DiaChi;
                _cmd.Parameters.Add("@MaSoThue", SqlDbType.Text).Value = hanghoa.MaSoThue;
                _cmd.Parameters.Add("@Fax", SqlDbType.Text).Value = hanghoa.Fax;
                _cmd.Parameters.Add("@SODT", SqlDbType.Text).Value = hanghoa.SODT;
                _cmd.Parameters.Add("@Mobile", SqlDbType.Text).Value = hanghoa.Mobile;
                _cmd.Parameters.Add("@Email", SqlDbType.Text).Value = hanghoa.Email;
                _cmd.Parameters.Add("@TaiKhoan", SqlDbType.Text).Value = hanghoa.TaiKhoan;
                _cmd.Parameters.Add("@NganHang", SqlDbType.Text).Value = hanghoa.NganHang;
                _cmd.Parameters.Add("@GioiHanNo", SqlDbType.Money).Value =Convert.ToDecimal(hanghoa.GioiHanNo);
                _cmd.Parameters.Add("@NoHienTai", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.NoHienTai);
                _cmd.Parameters.Add("@ChietKhau", SqlDbType.Float).Value = Convert.ToDouble(hanghoa.ChietKhau);
                _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.Text).Value = hanghoa.NguoiLienHe;
                _cmd.Parameters.Add("@Website", SqlDbType.Text).Value = hanghoa.Website;
                _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
                _cmd.Parameters.Add("@ChucVu", SqlDbType.Text).Value = hanghoa.ChucVu;
                OpenConn();
                var i = _cmd.ExecuteNonQuery();
                CloseConn();
                return true;
            }
            else
            {
                return false;
            }
        }

        public int updateNhaPhanPhoi(DTONhaPhanPhoi hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update NHAPHANPHOI set MaNPP=@MaNPP,MaKhuVuc=@MaKhuVuc,TenNPP=@TenNPP,DiaChi=@DiaChi,MaSoThue=@MaSoThue,Fax=@Fax,SODT=@SODT,Mobile=@Mobile,Email=@Email,Website=@Website,TaiKhoan=@TaiKhoan,NganHang=@NganHang,GioiHanNo=@GioiHanNo,NoHienTai=@NoHienTai,ChietKhau=@ChietKhau,NguoiLienHe=@NguoiLienHe,ConQuanLy=@ConQuanLy where MaNPP=@MaNPP ";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MaNPP", SqlDbType.NVarChar).Value = hanghoa.MaNPP;
            _cmd.Parameters.Add("@MaKhuVuc", SqlDbType.NVarChar).Value = hanghoa.MaKhuVuc;
            _cmd.Parameters.Add("@TenNPP", SqlDbType.NVarChar).Value = hanghoa.TenNPP;
            _cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hanghoa.DiaChi;
            _cmd.Parameters.Add("@MaSoThue", SqlDbType.NVarChar).Value = hanghoa.MaSoThue;
            _cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = hanghoa.Fax;
            _cmd.Parameters.Add("@SODT", SqlDbType.NVarChar).Value = hanghoa.SODT;
            _cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = hanghoa.Mobile;
            _cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = hanghoa.Email;
            _cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = hanghoa.TaiKhoan;
            _cmd.Parameters.Add("@NganHang", SqlDbType.NVarChar).Value = hanghoa.NganHang;
            _cmd.Parameters.Add("@GioiHanNo", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GioiHanNo);
            _cmd.Parameters.Add("@NoHienTai", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.NoHienTai);
            _cmd.Parameters.Add("@ChietKhau", SqlDbType.Float).Value = Convert.ToDouble(hanghoa.ChietKhau);
            _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar).Value = hanghoa.NguoiLienHe;
            _cmd.Parameters.Add("@Website", SqlDbType.NVarChar).Value = hanghoa.Website;
            _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            _cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = hanghoa.ChucVu;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }
    }
}
