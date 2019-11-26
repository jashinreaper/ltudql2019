using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CommonQuery:ConnectionToSql
    {
        public int ExecNonQuery(string sql)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            OpenConn();
            var i = _cmd.ExecuteNonQuery();
            CloseConn();
            return i;
        }

        public int ExecSelectedCount(string sql)
        {
            DataTable dt = GetData(sql);
            return dt.Rows.Count;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = connection;
            try
            {
                OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                CloseConn();
            }
            return dt;
        }

    }
}
