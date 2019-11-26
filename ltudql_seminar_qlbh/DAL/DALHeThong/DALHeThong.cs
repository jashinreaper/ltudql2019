using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DALHeThong: CommonQuery
    {
        public DataTable getThongTin()
        {
            string query = string.Format($"select * from THONGTIN");
            DataTable dt = GetData(query);
            return dt;
        }

        public DataTable getLinhVuc()
        {
            string query = string.Format($"select * from LINHVUC");
            DataTable dt = GetData(query);
            return dt;
        }

        public void updateLinhVuc(DTOThongTin thongtin)
        {
            string query = string.Format($"select * from THONGTIN");
            if (ExecSelectedCount(query) > 0)
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "update THONGTIN set tendonvi=@tendonvi,diachi=@diachi,dienthoai=@dienthoai,fax=@fax,website=@website,email=@email,linhvuc=@linhvuc,masothue=@masothue,gpkd=@gpkd";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@tendonvi",SqlDbType.Text).Value= thongtin.tendonvi;
                _cmd.Parameters.Add("@diachi", SqlDbType.Text).Value = thongtin.diachi;
                _cmd.Parameters.Add("@dienthoai", SqlDbType.Text).Value = thongtin.dienthoai;
                _cmd.Parameters.Add("@fax", SqlDbType.Text).Value = thongtin.fax;
                _cmd.Parameters.Add("@website", SqlDbType.Text).Value = thongtin.website;
                _cmd.Parameters.Add("@email", SqlDbType.Text).Value = thongtin.email;
                _cmd.Parameters.Add("@linhvuc", SqlDbType.Text).Value = thongtin.linhvuc;
                _cmd.Parameters.Add("@masothue", SqlDbType.Text).Value = thongtin.masothue;
                _cmd.Parameters.Add("@gpkd", SqlDbType.Text).Value = thongtin.gpkd;
                OpenConn();
                var i = _cmd.ExecuteNonQuery();
                CloseConn();
            }
            else
            {
                var _cmd = new SqlCommand();
                _cmd.CommandText = "insert into THONGTIN value(tendonvi=@tendonvi,diachi=@diachi,dienthoai=@dienthoai,fax=@fax,website=@website,email=@email,linhvuc=@linhvuc,masothue=@masothue,gpkd=@gpkd)";
                _cmd.CommandType = CommandType.Text;
                _cmd.Connection = connection;
                _cmd.Parameters.Add("@tendonvi", SqlDbType.Text).Value = thongtin.tendonvi;
                _cmd.Parameters.Add("@diachi", SqlDbType.Text).Value = thongtin.diachi;
                _cmd.Parameters.Add("@dienthoai", SqlDbType.Text).Value = thongtin.dienthoai;
                _cmd.Parameters.Add("@fax", SqlDbType.Text).Value = thongtin.fax;
                _cmd.Parameters.Add("@website", SqlDbType.Text).Value = thongtin.website;
                _cmd.Parameters.Add("@email", SqlDbType.Text).Value = thongtin.email;
                _cmd.Parameters.Add("@linhvuc", SqlDbType.Text).Value = thongtin.linhvuc;
                _cmd.Parameters.Add("@masothue", SqlDbType.Text).Value = thongtin.masothue;
                _cmd.Parameters.Add("@gpkd", SqlDbType.Text).Value = thongtin.gpkd;
                OpenConn();
                var i = _cmd.ExecuteNonQuery();
                CloseConn();
            }
        }

    }
}
