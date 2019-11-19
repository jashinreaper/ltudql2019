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
            //dt.Columns[0].ColumnName = "Chức năng";
            //dt.Columns[1].ColumnName = "Tên người dùng";
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
           //treelistVaitro = "Tên người dùng";
            //gridColumn3.FieldName = "Tên vai trò";
            //gridColumn4.FieldName = "Diễn giải";
            treelistVaitro.DataSource = dt;
        }
    }
}