using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;
namespace ltudql_seminar_qlbh.frmDanhMuc.frmKhoHang
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();
            DataTable dt = um.getBangDonVi();
            gridColumn1.FieldName = "id";
            gridColumn2.FieldName = "MaDV";
            gridColumn3.FieldName = "TenDV";
            gridColumn4.FieldName = "GhiChu";
            gridColumn5.FieldName = "ConQuanLy";
            gridControl1.DataSource = dt;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh_Add frm = new frmDonViTinh_Add(true, "");
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDonViTinh_Add frm = new frmDonViTinh_Add(false, gridView1.GetFocusedRowCellValue("MaDV").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();

            string a = gridView1.GetFocusedRowCellValue("MaDV").ToString();
            um.removeBangDonVi(a);
            MessageBox.Show("Xóa thành công");
        }


    }
}