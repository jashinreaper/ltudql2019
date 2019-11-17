using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALLogin
    {
       static CommonQuery cq = new CommonQuery();
       public bool isExistUser(string username, string password)
        {
            string query = string.Format($"select * from Users where username='{username}' and userpassword='{password}'");
            if (cq.ExecSelectedCount(query) > 0)
                return true;
            return false;
        }
        public string getRole(string username)
        {
            string query = string.Format($"select roleid from Users where username='{username}'");
            DataTable dt = cq.GetData(query);
            return dt.Rows[0][0].ToString();
        }

        public string getRoleName(string username)
        {
            string query = string.Format($"select rolename from Roles where roleid='{getRole(username)}'");
            DataTable dt = cq.GetData(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
