using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string query = string.Format($"select u.id,u.userid,u.username,u.userfullname,r.rolename,r.roledes from Users u join Roles r on u.roleid = r.roleid");
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




    }
}
