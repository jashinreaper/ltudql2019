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
    public partial class frmNhaPhanPhoi : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void frmNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();
            DataTable dt = um.getNhaPhanPhoi();
            gridColumn1.FieldName = "id";
            gridColumn2.FieldName = "MaNPP";
            gridColumn3.FieldName = "TenNPP";
            gridColumn4.FieldName = "MaKhuVuc";
            gridColumn5.FieldName = "DiaChi";
            gridColumn6.FieldName = "SODT";
            gridColumn7.FieldName = "Fax";
            gridColumn8.FieldName = "Email";
            gridControl1.DataSource = dt;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaPhanPhoi_Add frm = new frmNhaPhanPhoi_Add(true, "");
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmNhaPhanPhoi_Add frm = new frmNhaPhanPhoi_Add(false, gridView1.GetFocusedRowCellValue("MaNPP").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSDoiTac um = new BUSDoiTac();

            string a = gridView1.GetFocusedRowCellValue("MaNPP").ToString();
            um.deleteNhaPhanPhoi(a);
            MessageBox.Show("Xóa thành công");
        }
    }
}