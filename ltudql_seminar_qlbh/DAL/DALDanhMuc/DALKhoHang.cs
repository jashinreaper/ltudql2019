using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALKhoHang:CommonQuery
    {
        public DataTable getKho()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from Kho");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getBanDonVi()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from BANGDONVI");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getBangNhomHang()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from BANGNHOMHANG");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getHangHoa()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from HANGHOA");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getHangHoaDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from HANGHOA where MaHH = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getKhoDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from KHO where MaKho = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getBanDonViDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from BANGDONVI where MaDV = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getBangNhomHangDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from BANGNHOMHANG where MaNH = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public int removeHangHoa(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from HANGHOA where MaHH = '{mahanghoa}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int removeKho(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from KHO where MaKho = '{mahanghoa}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int removeBangDonVi(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from BANGDONVI where MaDV = '{mahanghoa}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public int removeBangNhomHang(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"delete from BANGNHOMHANG where MaNH = '{mahanghoa}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public bool insertHangHoa(DTOHangHoa hanghoa)
        {
            string query = string.Format($"select * from HANGHOA where MaHH='{hanghoa.MaHH}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into HANGHOA values (@VatTu,@DichVu,@MaKhoHang,@PhanLoai,@MaHH,@TENHH,@MaVachNSX,@MaDonVi,@XuatXu,@Thue,@TonKhoToiThieu,@TonKhoHienTai,@MaNhaCungCap,@GiaMua,@GiaSi,@GiaLe)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MaKhoHang", SqlDbType.Text).Value = hanghoa.MaKhoHang;
                _cmd.Parameters.Add("@PhanLoai", SqlDbType.Text).Value = hanghoa.PhanLoai;
                _cmd.Parameters.Add("@MaHH", SqlDbType.Text).Value = hanghoa.MaHH;
                _cmd.Parameters.Add("@TENHH", SqlDbType.Text).Value = hanghoa.TENHH;
                _cmd.Parameters.Add("@MaVachNSX", SqlDbType.Text).Value = hanghoa.MaVachNSX;
                _cmd.Parameters.Add("@MaDonVi", SqlDbType.Text).Value = hanghoa.MaDonVi;
                _cmd.Parameters.Add("@XuatXu", SqlDbType.Text).Value = hanghoa.XuatXu;
                _cmd.Parameters.Add("@Thue", SqlDbType.Float).Value =Convert.ToDouble(hanghoa.Thue);
                _cmd.Parameters.Add("@TonKhoToiThieu", SqlDbType.Int).Value =Convert.ToInt32(hanghoa.TonKhoToiThieu);
                _cmd.Parameters.Add("@TonKhoHienTai", SqlDbType.Int).Value = Convert.ToInt32(hanghoa.TonKhoHienTai);
                _cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.Text).Value = hanghoa.MaNhaCungCap;
                _cmd.Parameters.Add("@GiaMua", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaMua);
                _cmd.Parameters.Add("@GiaSi", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaSi);
                _cmd.Parameters.Add("@GiaLe", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaLe);
                _cmd.Parameters.Add("@VatTu", SqlDbType.Bit).Value =Convert.ToBoolean(hanghoa.VatTu);
                _cmd.Parameters.Add("@DichVu", SqlDbType.Bit).Value = Convert.ToBoolean(hanghoa.DichVu);
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

        public int updateHangHoa(DTOHangHoa hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update HANGHOA set VatTu=@VatTu,DichVu=@DichVu,MaKhoHang=@MaKhoHang,PhanLoai=@PhanLoai,MaHH=@MaHH,TENHH=@TENHH,MaVachNSX=@MaVachNSX,MaDonVi=@MaDonVi,XuatXu=@XuatXu,Thue=@Thue,TonKhoToiThieu=@TonKhoToiThieu,TonKhoHienTai=@TonKhoHienTai,MaNhaCungCap=@MaNhaCungCap,GiaMua=@GiaMua,GiaSi=@GiaSi,GiaLe=@GiaLe where MaHH=@MaHH ";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MaKhoHang", SqlDbType.NVarChar).Value = hanghoa.MaKhoHang;
            _cmd.Parameters.Add("@PhanLoai", SqlDbType.NVarChar).Value = hanghoa.PhanLoai;
            _cmd.Parameters.Add("@MaHH", SqlDbType.NVarChar).Value = hanghoa.MaHH;
            _cmd.Parameters.Add("@TENHH", SqlDbType.NVarChar).Value = hanghoa.TENHH;
            _cmd.Parameters.Add("@MaVachNSX", SqlDbType.NVarChar).Value = hanghoa.MaVachNSX;
            _cmd.Parameters.Add("@MaDonVi", SqlDbType.NVarChar).Value = hanghoa.MaDonVi;
            _cmd.Parameters.Add("@XuatXu", SqlDbType.NVarChar).Value = hanghoa.XuatXu;
            _cmd.Parameters.Add("@Thue", SqlDbType.Float).Value = Convert.ToDouble(hanghoa.Thue);
            _cmd.Parameters.Add("@TonKhoToiThieu", SqlDbType.Int).Value = Convert.ToInt32(hanghoa.TonKhoToiThieu);
            _cmd.Parameters.Add("@TonKhoHienTai", SqlDbType.Int).Value = Convert.ToInt32(hanghoa.TonKhoHienTai);
            _cmd.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = hanghoa.MaNhaCungCap;
            _cmd.Parameters.Add("@GiaMua", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaMua);
            _cmd.Parameters.Add("@GiaSi", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaSi);
            _cmd.Parameters.Add("@GiaLe", SqlDbType.Money).Value = Convert.ToDecimal(hanghoa.GiaLe);
            _cmd.Parameters.Add("@VatTu", SqlDbType.Bit).Value = Convert.ToBoolean(hanghoa.VatTu);
            _cmd.Parameters.Add("@DichVu", SqlDbType.Bit).Value = Convert.ToBoolean(hanghoa.DichVu);
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }

        public bool insertKho(DTOKho hanghoa)
        {
            string query = string.Format($"select * from KHO where MaKho='{hanghoa.MaKho}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into KHO values (@MaKho,@TenKho,@DiaChi,@Fax,@SODT,@Mobile,@Email,@NguoiQuanLy,@NguoiLienHe,@DienGiai,@ConQuanLy)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MaKho", SqlDbType.Text).Value = hanghoa.MaKho;
                _cmd.Parameters.Add("@TenKho", SqlDbType.Text).Value = hanghoa.TenKho;
                _cmd.Parameters.Add("@DiaChi", SqlDbType.Text).Value = hanghoa.DiaChi;
                _cmd.Parameters.Add("@Fax", SqlDbType.Text).Value = hanghoa.Fax;
                _cmd.Parameters.Add("@SODT", SqlDbType.Text).Value = hanghoa.SODT;
                _cmd.Parameters.Add("@Mobile", SqlDbType.Text).Value = hanghoa.Mobile;
                _cmd.Parameters.Add("@Email", SqlDbType.Text).Value = hanghoa.Email;
                _cmd.Parameters.Add("@NguoiQuanLy", SqlDbType.Text).Value = hanghoa.NguoiQuanLy;
                _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.Text).Value = hanghoa.NguoiLienHe;
                _cmd.Parameters.Add("@DienGiai", SqlDbType.Text).Value = hanghoa.DienGiai;
                _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
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

        public int updateKho(DTOKho hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update KHO set MaKho=@MaKho,TenKho=@TenKho,DiaChi=@DiaChi,Fax=@Fax,SODT=@SODT,Mobile=@Mobile,NguoiQuanLy=@NguoiQuanLy,NguoiLienHe=@NguoiLienHe,DienGiai=@DienGiai,ConQuanLy=@ConQuanLy where MaKho=@MaKho ";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MaKho", SqlDbType.NVarChar).Value = hanghoa.MaKho;
            _cmd.Parameters.Add("@TenKho", SqlDbType.NVarChar).Value = hanghoa.TenKho;
            _cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = hanghoa.DiaChi;
            _cmd.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = hanghoa.Fax;
            _cmd.Parameters.Add("@SODT", SqlDbType.NVarChar).Value = hanghoa.SODT;
            _cmd.Parameters.Add("@Mobile", SqlDbType.NVarChar).Value = hanghoa.Mobile;
            _cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = hanghoa.Email;
            _cmd.Parameters.Add("@NguoiQuanLy", SqlDbType.NVarChar).Value = hanghoa.NguoiQuanLy;
            _cmd.Parameters.Add("@NguoiLienHe", SqlDbType.NVarChar).Value = hanghoa.NguoiLienHe;
            _cmd.Parameters.Add("@DienGiai", SqlDbType.NVarChar).Value = hanghoa.DienGiai;
            _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }

        public bool insertBangDonVi(DTODonViTinh hanghoa)
        {
            string query = string.Format($"select * from BANGDONVI where MaDV='{hanghoa.MaDV}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into BANGDONVI values (@MaDV,@TenDV,@GhiChu,@ConQuanLy)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MaDV", SqlDbType.Text).Value = hanghoa.MaDV;
                _cmd.Parameters.Add("@TenDV", SqlDbType.Text).Value = hanghoa.TenDV;
                _cmd.Parameters.Add("@GhiChu", SqlDbType.Text).Value = hanghoa.GhiChu;
                _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
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

        public int updateBangDonVi(DTODonViTinh hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update BANGDONVI set MaDV=@MaDV,TenDV=@TenDV,GhiChu=@GhiChu,ConQuanLy=@ConQuanLy where MaDV=@MaDV";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MaDV", SqlDbType.NVarChar).Value = hanghoa.MaDV;
            _cmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = hanghoa.TenDV;
            _cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = hanghoa.GhiChu;
            _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }

        public bool insertBangNhomHang(DTONhomHang hanghoa)
        {
            string query = string.Format($"select * from BANGNHOMHANG where MaNH='{hanghoa.MaNH}'");
            if (ExecSelectedCount(query) == 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into BANGNHOMHANG values (@MaNH,@TenNH,@GhiChu,@ConQuanLy)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@MaNH", SqlDbType.Text).Value = hanghoa.MaNH;
                _cmd.Parameters.Add("@TenNH", SqlDbType.Text).Value = hanghoa.TenNH;
                _cmd.Parameters.Add("@GhiChu", SqlDbType.Text).Value = hanghoa.GhiChu;
                _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
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

        public int updateBangNhomHang(DTONhomHang hanghoa)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = "update BANGNHOMHANG set MaNH=@MaNH,TenNH=@TenNH,GhiChu=@GhiChu,ConQuanLy=@ConQuanLy where MaNH=@MaNH";
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            _cmd.Parameters.Add("@MaNH", SqlDbType.NVarChar).Value = hanghoa.MaNH;
            _cmd.Parameters.Add("@TenNH", SqlDbType.NVarChar).Value = hanghoa.TenNH;
            _cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar).Value = hanghoa.GhiChu;
            _cmd.Parameters.Add("@ConQuanLy", SqlDbType.Bit).Value = hanghoa.ConQuanLy;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }
    }
}
