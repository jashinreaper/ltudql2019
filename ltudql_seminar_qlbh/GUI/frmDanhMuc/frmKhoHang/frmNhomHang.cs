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
using DTO;
using BUS;
namespace ltudql_seminar_qlbh.frmDanhMuc.frmKhoHang
{
    public partial class frmNhomHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHang()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();
            DataTable dt = um.getBangNhomHang();
            gridColumn1.FieldName = "id";
            gridColumn2.FieldName = "MaNH";
            gridColumn3.FieldName = "TenNH";
            gridColumn4.FieldName = "GhiChu";
            gridColumn5.FieldName = "ConQuanLy";
            gridControl1.DataSource = dt;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhomHang_Add frm = new frmNhomHang_Add(true, "");
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhomHang_Add frm = new frmNhomHang_Add(false, gridView1.GetFocusedRowCellValue("MaNH").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();

            string a = gridView1.GetFocusedRowCellValue("MaNH").ToString();
            um.removeBangNhomHang(a);
            MessageBox.Show("Xóa thành công");
        }
    }
}