using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionToSql
    {
        private SqlConnection Conn;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }

        }
        public SqlConnection connection
        {

            get { return Conn; }

        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        public ConnectionToSql()
        {
            StrCon = (@"server=;database=QuanLyBanHang;trusted_connection=true;");
            Conn = new SqlConnection(StrCon);
        }

        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }


    }
}



