using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUSRole
    {
        public DataTable getRoleList()
        {
            DALRole um = new DALRole();

            DataTable dt = um.getRoleList();

            return dt;
        }

        public bool updateRoleList(DataTable dt)
        {
            DALRole um = new DALRole();
            if(um.updateRoleList(dt))
            {
                return true;
            }
            return false;
        }

    }
}
