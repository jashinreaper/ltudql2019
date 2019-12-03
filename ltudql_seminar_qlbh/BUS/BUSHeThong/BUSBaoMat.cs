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

        public DTOUser getUserDetail(string mahanghoa)
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getUserDetail(mahanghoa);
            DTOUser a = new DTOUser();
            a.id = dt.Rows[0]["id"].ToString();
            a.username = dt.Rows[0]["username"].ToString();
            a.userfullname = dt.Rows[0]["userfullname"].ToString();
            a.roleid = dt.Rows[0]["roleid"].ToString();
            a.isactive = Convert.ToBoolean(dt.Rows[0]["isactive"].ToString());
            a.roledes = dt.Rows[0]["roledes"].ToString();
            a.rolename = dt.Rows[0]["rolename"].ToString();
            a.userpassword = dt.Rows[0]["userpassword"].ToString();
            return a;
        }
        public DataTable getComboBoxRoles()
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getComboBoxRoles();


            return dt;
        }

        public bool insertUser(DTOUser hanghoa)
        {
            DALBaoMat um = new DALBaoMat();

            bool dt = um.insertUser(hanghoa);

            return dt;
        }

        public int updateUser(DTOUser hanghoa)
        {
            DALBaoMat um = new DALBaoMat();

            int dt = um.updateUser(hanghoa);

            return dt;
        }

        public bool isCorrect(string username, string password)
        {
            DALBaoMat dl = new DALBaoMat();
            if (dl.isExistUser(username, password))
            {
                return true;
            }
            else return false;
        }

        public bool updatePassword(string username, string password)
        {
            DALBaoMat dl = new DALBaoMat();
            if (dl.updatePassword(username, password))
            {
                return true;
            }
            else return false;
        }

        public int removeHangHoa(string mahanghoa)
        {
            DALBaoMat um = new DALBaoMat();

            int dt = um.removeUser(mahanghoa);

            return dt;
        }
        

    }
}
