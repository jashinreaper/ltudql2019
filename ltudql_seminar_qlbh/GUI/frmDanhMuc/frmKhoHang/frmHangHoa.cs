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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmHangHoa_Add frm = new frmHangHoa_Add(true,"");
            frm.Show();
        }

        public void getdata()
        {
            BUSHangHoa um = new BUSHangHoa();
            DataTable dt = um.getHangHoa();
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Mã hàng hóa";
            dt.Columns[2].ColumnName = "Tên hàng hóa";
            dt.Columns[3].ColumnName = "Đơn vị tính";
            //dt.Columns[4].ColumnName = "";
            dt.Columns[5].ColumnName = "Đơn giá";

            gridColumn1.FieldName = "ID";
            gridColumn2.FieldName = "Mã hàng hóa";
            gridColumn3.FieldName = "Tên hàng hóa";
            gridColumn4.FieldName = "Đơn vị tính";
            gridColumn5.FieldName = "Đơn giá";
            gridControl1.DataSource = dt;
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BUSHangHoa um = new BUSHangHoa();

            string a = gridView1.GetFocusedRowCellValue("Mã hàng hóa").ToString();
            MessageBox.Show(a);
            um.removeHangHoa(a);
            getdata();
            gridView1.RefreshData();


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmHangHoa_Add frm = new frmHangHoa_Add(false, gridView1.GetFocusedRowCellValue("Mã hàng hóa").ToString());
            frm.Show();
        }
    }
}