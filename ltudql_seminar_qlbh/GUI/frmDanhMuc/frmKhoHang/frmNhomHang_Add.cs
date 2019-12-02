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
namespace ltudql_seminar_qlbh.frmDanhMuc
{
    public partial class frmNhomHang_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmNhomHang_Add(bool isAdd, string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit1.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }

        private void frmNhomHang_Add_Load(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                BUSKhoHang b = new BUSKhoHang();
                DTONhomHang dtoHangHoa = b.getBangNhomHangDetail(gotID);
                textEdit1.Text = dtoHangHoa.MaNH;
                textEdit2.Text = dtoHangHoa.TenNH;
                textEdit3.Text = dtoHangHoa.GhiChu;
                checkEdit1.Checked = dtoHangHoa.ConQuanLy;
            }
            else
            {
                textEdit1.ReadOnly = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang b = new BUSKhoHang();
            DTONhomHang d = new DTONhomHang();
            d.MaNH = textEdit1.Text;
            d.TenNH = textEdit2.Text;
            d.GhiChu = textEdit3.Text;
            d.ConQuanLy = checkEdit1.Checked;
            if (isAddForm)
            {
                if (b.insertBangNhomHang(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateBangNhomHang(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}