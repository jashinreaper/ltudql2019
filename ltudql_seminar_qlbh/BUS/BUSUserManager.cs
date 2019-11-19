using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUSUserManager
    {
        public DataTable getUserList()
        {
            DALUserManager um = new DALUserManager();

            DataTable dt = um.getUserList();

            return dt;
        }
    }
}
