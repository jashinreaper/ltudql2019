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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();
            DataTable dt = um.getKhachHang();
            gridColumn1.FieldName = "MaKhuVuc";
            gridColumn2.FieldName = "MAKH";
            gridColumn3.FieldName = "HOTEN";
            gridColumn4.FieldName = "DiaChi";
            gridColumn5.FieldName = "SODT";
            gridColumn6.FieldName = "Email";
            gridColumn7.FieldName = "SODT";
            gridColumn8.FieldName = "ConQuanLy";
            gridControl1.DataSource = dt;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang_Add frm = new frmKhachHang_Add(true, "");
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frmKhachHang_Add frm = new frmKhachHang_Add(false, gridView1.GetFocusedRowCellValue("MAKH").ToString());
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();

            string a = gridView1.GetFocusedRowCellValue("MAKH").ToString();

            um.deleteKhachHang(a);
            MessageBox.Show("Xóa thành công");
        }
    }
}