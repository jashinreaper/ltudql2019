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

namespace ltudql_seminar_qlbh.frmDanhMuc.frmDoiTac
{
    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuVuc_Add frm = new frmKhuVuc_Add(true, "");
            frm.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuVuc_Add frm = new frmKhuVuc_Add(false, gridView1.GetFocusedRowCellValue("MaKhuVuc").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();

            string a = gridView1.GetFocusedRowCellValue("MaKhuVuc").ToString();
            um.deleteKhuVuc(a);
            MessageBox.Show("Xóa thành công");
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();
            DataTable dt = um.getKhuVuc();
            gridColumn1.FieldName = "MaKhuVuc";
            gridColumn2.FieldName = "TenKhuVuc";
            gridColumn3.FieldName = "GhiChu";
            gridColumn4.FieldName = "ConQuanLy";
            gridControl1.DataSource = dt;
        }
    }
}