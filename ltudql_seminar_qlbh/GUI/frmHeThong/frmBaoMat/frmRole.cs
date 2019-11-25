using BUS;
using DevExpress.XtraTreeList.Nodes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

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
            dt.Columns[1].ColumnName = "roleID";
            dt.Columns[2].ColumnName = "Chức năng";
            dt.Columns[3].ColumnName = "roleDes";
            dt.Columns[4].ColumnName = "Tất cả";
            dt.Columns[5].ColumnName = "Truy cập";
            dt.Columns[6].ColumnName = "Thêm";
            dt.Columns[7].ColumnName = "Sửa";
            dt.Columns[8].ColumnName = "Xóa";
            dt.Columns[9].ColumnName = "In";
            dt.Columns[10].ColumnName = "Nhập";
            dt.Columns[11].ColumnName = "Xuất";
            dt.Columns[12].ColumnName = "isActived";
            //treelistVaitro.DataSource = dt;

            treelistVaitro.BeginUnboundLoad();
            //root
            TreeListNode parentForRootNodes = null;
            TreeListNode rootNode = treelistVaitro.AppendNode(
                new object[] { "Hệ thống", "True", "True", "True", "True", "True", "True", "True", "True", "H0","", "True" },
                parentForRootNodes);
            //level1
            var hethong = treelistVaitro.AppendNode(new object[] { "Hệ thống", "true", "true", "true", "true", "true", "true", "true", "true", "H1", "", "true" }, rootNode);
            var baomat = treelistVaitro.AppendNode(new object[] { "Bảo mật", "true", "true", "true", "true", "true", "true", "true", "true", "B1", "", "true" }, rootNode);
            var dulieu = treelistVaitro.AppendNode(new object[] { "Dữ liệu", "true", "true", "true", "true", "true", "true", "true", "true", "D1", "", "true" }, rootNode);
            //level2
            treelistVaitro.AppendNode(new object[] { "Quản lí người dùng", "true", "true", "true", "true", "true", "true", "true", "true", "B2", "", "true" }, baomat);
            treelistVaitro.AppendNode(new object[] { "Vai trò và quyền hạn", "true", "true", "true", "true", "true", "true", "true", "true", "B3", "", "true" }, baomat);
            treelistVaitro.AppendNode(new object[] { "Nhật ký hệ thống", "true", "true", "true", "true", "true", "true", "true", "true", "B4", "", "true" }, baomat);
            treelistVaitro.AppendNode(new object[] { "Sao lưu", "true", "true", "true", "true", "true", "true", "true", "true", "D2", "", "true" }, dulieu);
            treelistVaitro.AppendNode(new object[] { "Phục hồi", "true", "true", "true", "true", "true", "true", "true", "true", "D3", "", "true" }, dulieu);
            treelistVaitro.AppendNode(new object[] { "Sửa chữa", "true", "true", "true", "true", "true", "true", "true", "true", "D4", "", "true" }, dulieu);
            treelistVaitro.EndUnboundLoad();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                foreach (TreeListNode item in treelistVaitro.GetNodeList())
                {
                    //Debug.WriteLine(dt.Rows[i]["roleID"].ToString());
                    //Debug.WriteLine(item.GetValue("roleID").ToString());
                    //Debug.WriteLine(treelistVaitro.GetNodeList().Count.ToString()+"------\n");
                    if (dt.Rows[i]["roleID"].ToString() == item.GetValue("roleID").ToString())
                    {
                        //Debug.WriteLine("activated");
                        item.SetValue("Chức năng", dt.Rows[i]["Chức năng"].ToString());
                        item.SetValue("roleDes", dt.Rows[i]["roleDes"].ToString());
                        item.SetValue("Tất cả", Convert.ToBoolean(dt.Rows[i]["Tất cả"].ToString()));
                        item.SetValue("Truy cập", Convert.ToBoolean(dt.Rows[i]["Truy cập"].ToString()));
                        item.SetValue("Thêm", Convert.ToBoolean(dt.Rows[i]["Thêm"].ToString()));
                        item.SetValue("Sửa", Convert.ToBoolean(dt.Rows[i]["Sửa"].ToString()));
                        item.SetValue("Xóa", Convert.ToBoolean(dt.Rows[i]["Xóa"].ToString()));
                        item.SetValue("In", Convert.ToBoolean(dt.Rows[i]["In"].ToString()));
                        item.SetValue("Nhập", Convert.ToBoolean(dt.Rows[i]["Nhập"].ToString()));
                        item.SetValue("Xuất", Convert.ToBoolean(dt.Rows[i]["Xuất"].ToString()));
                        item.SetValue("isActived", Convert.ToBoolean(dt.Rows[i]["isActived"].ToString()));
                        break;
                    }
                }
            }
            treelistVaitro.Refresh();
            treelistVaitro.ExpandAll();
        }

        private void treelistVaitro_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            //BUSRole um = new BUSRole();
            //DataTable dt = um.getRoleList();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    if (treelistVaitro.FocusedNode.Id == i)
            //    {
            //        textEdit1.Text = dt.Rows[i]["roleid"].ToString();
            //        textEdit2.Text = dt.Rows[i]["roledes"].ToString();
            //        textEdit3.Text = dt.Rows[i]["rolename"].ToString();
            //        checkEdit1.Checked = Convert.ToBoolean(dt.Rows[i]["isactive"]);
            //        break;
            //    }
            //}
            if (treelistVaitro.FocusedNode.GetValue("roleID") != null)
                textEdit1.Text = treelistVaitro.FocusedNode.GetValue("roleID").ToString();
            else textEdit1.Text = "";
            if (treelistVaitro.FocusedNode.GetValue("roleDes") != null)
                textEdit2.Text = treelistVaitro.FocusedNode.GetValue("roleDes").ToString();
            else textEdit2.Text = "";
            if (treelistVaitro.FocusedNode.GetValue("Chức năng") != null)
                textEdit3.Text = treelistVaitro.FocusedNode.GetValue("Chức năng").ToString();
            else textEdit3.Text = "";
            if (treelistVaitro.FocusedNode.GetValue("isActived") != null)
                checkEdit1.Checked = Convert.ToBoolean(treelistVaitro.FocusedNode.GetValue("isActived").ToString());
            else checkEdit1.Checked = false;
            //
            //
            //
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {
            treelistVaitro.FocusedNode.SetValue("Chức năng",textEdit3.Text);
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            treelistVaitro.FocusedNode.SetValue("roleDes", textEdit2.Text);
        }



        private void checkEdit1_CheckStateChanged(object sender, EventArgs e)
        {
            treelistVaitro.FocusedNode.SetValue("isActived", checkEdit1.Checked);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("roleID", typeof(string));
            dt.Columns.Add("Chức năng", typeof(string));
            dt.Columns.Add("roleDes", typeof(string));
            dt.Columns.Add("Tất cả", typeof(bool));
            dt.Columns.Add("Truy cập", typeof(bool));
            dt.Columns.Add("Thêm", typeof(bool));
            dt.Columns.Add("Sửa", typeof(bool));
            dt.Columns.Add("Xóa", typeof(bool));
            dt.Columns.Add("In", typeof(bool));
            dt.Columns.Add("Nhập", typeof(bool));
            dt.Columns.Add("Xuất", typeof(bool));
            dt.Columns.Add("isActived", typeof(bool));

            foreach (TreeListNode item in treelistVaitro.GetNodeList())
            {
                dt.Rows.Add(item.GetValue("roleID"), item.GetValue("Chức năng"), item.GetValue("roleDes"),
                    Convert.ToBoolean(item.GetValue("Tất cả")), Convert.ToBoolean(item.GetValue("Truy cập")), Convert.ToBoolean(item.GetValue("Thêm")), Convert.ToBoolean(item.GetValue("Sửa")),
                    Convert.ToBoolean(item.GetValue("Xóa")), Convert.ToBoolean(item.GetValue("In")), Convert.ToBoolean(item.GetValue("Nhập")), Convert.ToBoolean(item.GetValue("Xuất")), Convert.ToBoolean(item.GetValue("isActived")));
            }
            BUSRole busRole = new BUSRole();
            //MessageBox.Show(dt.Rows.Count.ToString());
            if (busRole.updateRoleList(dt))
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}