using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRole
    {
        static CommonQuery cq = new CommonQuery();
        public DataTable getRoleList()
        {
            string query = string.Format($"select * from Roles");
            DataTable dt = cq.GetData(query);
            return dt;
        }
    }
}
