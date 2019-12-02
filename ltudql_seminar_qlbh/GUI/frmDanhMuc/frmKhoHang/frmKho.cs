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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();
            DataTable dt = um.getKho();
            gridColumn1.FieldName = "id";
            gridColumn2.FieldName = "MaKho";
            gridColumn3.FieldName = "TenKho";
            gridColumn4.FieldName = "DiaChi";
            gridColumn5.FieldName = "NguoiLienHe";
            gridColumn6.FieldName = "SODT";
            gridColumn7.FieldName = "ConQuanLy";
            gridControl1.DataSource = dt;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKho_Add frm = new frmKho_Add(true, "");
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKho_Add frm = new frmKho_Add(false, gridView1.GetFocusedRowCellValue("MaKho").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();

            string a = gridView1.GetFocusedRowCellValue("MaKho").ToString();
            um.removeKho(a);
            MessageBox.Show("Xóa thành công");
        }
    }
}