using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class DALBaoMat
    {
        static CommonQuery cq = new CommonQuery();
        public DataTable getRoleList()
        {
            string query = string.Format($"select * from Roles");
            DataTable dt = cq.GetData(query);
            return dt;
        }
        public DataTable getUserList()
        {
            string query = string.Format($"select u.*,r.* from Users u join Roles r on u.roleid = r.roleid");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getUserDetail(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select r.*,u.* from Users u join Roles r on u.roleid = r.roleid where userid = '{mahanghoa}'");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getComboBoxRoles()
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from Roles");
            DataTable dt = cq.GetData(query);
            return dt;
        }

        public DataTable getNhatKyHeThong()
        {
            string query = string.Format($"select * from NhatKyHeThong");
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
                    string query = string.Format($"update Roles set rolename=N'{dataTable.Rows[i]["Chức năng"]}' , roledes=N'{dataTable.Rows[i]["roleDes"]}' , rfull='{dataTable.Rows[i]["Tất cả"]}' , raccess='{dataTable.Rows[i]["Truy cập"]}'" +
                        $" , radd='{dataTable.Rows[i]["Thêm"]}' , redit='{dataTable.Rows[i]["Sửa"]}' , rdelete='{dataTable.Rows[i]["Xóa"]}' , rprint='{dataTable.Rows[i]["In"]}' , rwrite='{dataTable.Rows[i]["Nhập"]}'" +
                        $" , rread='{dataTable.Rows[i]["Xuất"]}' , isActive='{dataTable.Rows[i]["isActived"]}' where roleID = '{dataTable.Rows[i]["roleID"]}'");
                    if (cq.ExecNonQuery(query) > 0)
                        r = true;
                    else r = false;
                }
                else
                {
                    string query = string.Format($"insert into Roles (roleid,rolename,roledes,rfull,raccess,radd,redit,rdelete,rprint,rwrite,rread,isactive) values('{dataTable.Rows[i]["roleID"]}',N'{dataTable.Rows[i]["Chức năng"]}',N'{dataTable.Rows[i]["roleDes"]}','{dataTable.Rows[i]["Tất cả"]}','{dataTable.Rows[i]["Truy cập"]}','{dataTable.Rows[i]["Thêm"]}'," +
                        $"'{dataTable.Rows[i]["Sửa"]}','{dataTable.Rows[i]["Xóa"]}','{dataTable.Rows[i]["In"]}','{dataTable.Rows[i]["Nhập"]}','{dataTable.Rows[i]["Xuất"]}','{dataTable.Rows[i]["isActived"]}' )");
                    if (cq.ExecNonQuery(query) > 0)
                        r = true;
                    else r = false;
                }
            }
            return r;
        }

        public bool isExistUser(string username, string password)
        {
            string query = string.Format($"select * from Users where username='{username}' and userpassword='{password}'");
            if (cq.ExecSelectedCount(query) > 0)
                return true;
            return false;
        }

        public bool updatePassword(string username, string password)
        {
            string query = string.Format($"update Users set userpassword='{password}' where username='{username}'");
            if (cq.ExecNonQuery(query) > 0)
                return true;
            return false;
        }


        public int removeUser(string mahanghoa)
        {
            CommonQuery cq = new CommonQuery();

            string query = string.Format($"delete from Users where userid = '{mahanghoa}'");
            int dt = cq.ExecNonQuery(query);
            return dt;
        }
        public bool insertUser(DTOUser hanghoa)
        {
            CommonQuery cq = new CommonQuery();
            string query = string.Format($"select * from Users where userid = '{hanghoa.userid}'");
            if (cq.ExecSelectedCount(query) > 0)
                return false;


            string query2 = string.Format($"select * from Roles where rolename = '{hanghoa.rolename}'");

            DataTable dt2 = cq.GetData(query2);
            hanghoa.roleid = dt2.Rows[0]["roleid"].ToString();

            query = string.Format($"insert into Users values('{hanghoa.userid}','{hanghoa.username}'," +
                $"'{hanghoa.userpassword}','{hanghoa.userfullname}','{hanghoa.roleid}','{hanghoa.isactive}')");
            int dt = cq.ExecNonQuery(query);
            return true;
        }
        public int updateUser(DTOUser hanghoa)
        {


            CommonQuery cq = new CommonQuery();
            string query2 = string.Format($"select * from Roles where rolename = '{hanghoa.rolename}'");

            DataTable dt2 = cq.GetData(query2);
            hanghoa.roleid = dt2.Rows[0]["roleid"].ToString();

            string query = string.Format($"update Users set userpassword='{hanghoa.userpassword}',roleid='{hanghoa.roleid}',isactive='{hanghoa.isactive}' where userid = '{hanghoa.userid}'");
            int dt = cq.ExecNonQuery(query);

 
            return dt;
        }


    }
}
