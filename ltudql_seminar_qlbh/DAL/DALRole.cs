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

        public bool updateRoleList(DataTable dataTable)
        {
            bool r = new bool();
            for (int i = 0; i < dataTable.Rows.Count ; i++)
            {
                if (cq.ExecSelectedCount($"select * from Roles where roleID = '{dataTable.Rows[i]["roleID"]}'")>0)
                {
                    string query = string.Format($"update Roles set rolename='{dataTable.Rows[i]["Chức năng"]}' where roleID = '{dataTable.Rows[i]["roleID"]}'");
                    if (cq.ExecNonQuery(query) > 0)
                        r = true;
                    else r = false;
                }
                else
                {
                    string query = string.Format($"insert into Roles (rolename) values('{dataTable.Rows[i]["Chức năng"]}')");
                    if (cq.ExecNonQuery(query) > 0)
                        r = true;
                    else r = false;
                }
            }
            return r;
        }

    }
}
