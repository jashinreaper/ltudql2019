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
using ltudql_seminar_qlbh.frmBaoMat;

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
            BUSBaoMat um = new BUSBaoMat();
            DataTable dt = um.getUserList();
            gridColumn5.FieldName = "id";
            gridColumn1.FieldName = "userid";
            gridColumn2.FieldName = "userfullname";
            gridColumn3.FieldName = "rolename";
            gridColumn4.FieldName = "roledes";
            gridColumn6.FieldName = "username";
            gridColumn7.FieldName = "isactive";
            dgvQuanlynguoidung.DataSource = dt;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUser_Add add = new frmUser_Add(true,"");
            add.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUser_Add add = new frmUser_Add(false, gridView1.GetFocusedRowCellValue("userid").ToString());
            add.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSBaoMat um = new BUSBaoMat();

            string a = gridView1.GetFocusedRowCellValue("userid").ToString();
            um.removeHangHoa(a);


            BUSBaoMat um2 = new BUSBaoMat();
            DataTable dt = um2.getUserList();
            dgvQuanlynguoidung.DataSource = dt;
        }
    }
}