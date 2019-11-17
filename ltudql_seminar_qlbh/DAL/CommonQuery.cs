using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class CommonQuery
    {
        ConnectionToSql conClass = new ConnectionToSql();
        public int ExecNonQuery(string sql)
        {
            DataTable dt = new DataTable();
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conClass.connection;
            conClass.OpenConn();
            var i = _cmd.ExecuteNonQuery();
            conClass.CloseConn();
            return i;
        }

        public int ExecSelectedCount(string sql)
        {
            DataTable dt = new DataTable();
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conClass.connection;
            try
            {
                conClass.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conClass.CloseConn();
            }
            return dt.Rows.Count;
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conClass.connection;
            try
            {
                conClass.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conClass.CloseConn();
            }
            return dt;
        }

        public bool SetData(string sql)
        {
            var _cmd = new SqlCommand();
            _cmd.CommandText = sql;
            _cmd = new SqlCommand();
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = conClass.connection;
            try
            {
                conClass.OpenConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                conClass.CloseConn();
            }
            return false;
        }
    }
}
