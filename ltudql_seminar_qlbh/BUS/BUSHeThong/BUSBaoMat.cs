using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSBaoMat
    {


        public DataTable getRoleList()
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getRoleList();

            return dt;
        }

        public bool updateRoleList(DataTable dt)
        {
            DALBaoMat um = new DALBaoMat();
            if (um.updateRoleList(dt))
            {
                return true;
            }
            return false;
        }

        public DataTable getUserList()
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getUserList();

            return dt;
        }


    }
}
