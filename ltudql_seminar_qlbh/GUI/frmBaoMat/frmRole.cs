using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DevExpress.XtraTreeList.Nodes;

namespace ltudql_seminar_qlbh.MainForm
{
    public partial class frmRole : DevExpress.XtraEditors.XtraForm
    {
        public frmRole()
        {
            InitializeComponent();
        }

        private void treelistVaitro_Load(object sender, EventArgs e)
        {
            
            BUSRole um = new BUSRole();
            DataTable dt = um.getRoleList();
            //dt.Columns[0].ColumnName = "ID";
            //dt.Columns[1].ColumnName = "roleID";
            dt.Columns[2].ColumnName = "Chức năng";
            //dt.Columns[3].ColumnName = "Diễn giải";
            dt.Columns[4].ColumnName = "Tất cả";
            dt.Columns[5].ColumnName = "Truy cập";
            dt.Columns[6].ColumnName = "Thêm";
            dt.Columns[7].ColumnName = "Sửa";
            dt.Columns[8].ColumnName = "Xóa";
            dt.Columns[9].ColumnName = "In";
            dt.Columns[10].ColumnName = "Nhập";
            dt.Columns[11].ColumnName = "Xuất";
            treelistVaitro.DataSource = dt;


        }

        private void treelistVaitro_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            BUSRole um = new BUSRole();
            DataTable dt = um.getRoleList();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if(treelistVaitro.FocusedNode.Id == i)
                {
                    textEdit1.Text = dt.Rows[i]["roleid"].ToString();
                    textEdit2.Text = dt.Rows[i]["roledes"].ToString();
                    textEdit3.Text = dt.Rows[i]["rolename"].ToString();
                    checkEdit1.Checked = Convert.ToBoolean(dt.Rows[i]["isactive"]);
                    break;
                }
            }
        }
    }
}