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
    public partial class frmHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();
            DataTable dt = um.getHangHoa();
            gridColumn1.FieldName = "id";
            gridColumn2.FieldName = "MaHH";
            gridColumn3.FieldName = "TENHH";
            gridColumn4.FieldName = "MaDonVi";
            gridColumn5.FieldName = "GiaMua";
            gridControl1.DataSource = dt;
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa_Add frm = new frmHangHoa_Add(true, "");
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHangHoa_Add frm = new frmHangHoa_Add(false, gridView1.GetFocusedRowCellValue("MaHH").ToString());
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang um = new BUSKhoHang();

            string a = gridView1.GetFocusedRowCellValue("MaHH").ToString();

            um.removeHangHoa(a);
            MessageBox.Show("Xóa thành công");
        }
    }
}