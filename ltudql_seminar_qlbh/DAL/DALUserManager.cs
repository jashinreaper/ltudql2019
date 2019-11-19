using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALUserManager
    {
        static CommonQuery cq = new CommonQuery();
        public DataTable getUserList()
        {
            string query = string.Format($"select u.userid,u.username,r.rolename,r.roledes from Users u join Roles r on u.roleid = r.roleid");
            DataTable dt = cq.GetData(query);
            return dt;
        }
    }
}
