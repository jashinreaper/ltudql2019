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
using DTO;

namespace ltudql_seminar_qlbh.MainForm
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void dgvQuanlynguoidung_Load(object sender, EventArgs e)
        {
            BUSUserManager um = new BUSUserManager();
            DataTable dt = um.getUserList();
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Tên người dùng";
            dt.Columns[2].ColumnName = "Tên vai trò";
            dt.Columns[3].ColumnName = "Diễn giải";
            gridColumn1.FieldName = "ID";
            gridColumn2.FieldName = "Tên người dùng";
            gridColumn3.FieldName = "Tên vai trò";
            gridColumn4.FieldName = "Diễn giải";
            dgvQuanlynguoidung.DataSource = dt;
        }
    }
}