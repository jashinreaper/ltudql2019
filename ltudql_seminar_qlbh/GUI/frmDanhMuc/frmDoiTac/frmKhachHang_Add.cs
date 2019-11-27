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
namespace ltudql_seminar_qlbh.frmDanhMuc.frmDoiTac
{
    public partial class frmKhachHang_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmKhachHang_Add(bool isAdd, string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit1.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BUSDoiTac b = new BUSDoiTac();
            //DTOKhachHang d = new DTOKhachHang();
            //d.MASP = textEdit2.Text;
            //d.TENSP = textEdit4.Text;
            //d.DVT = comboBoxEdit3.Text;
            //d.NUOCSX = textEdit1.Text;
            //d.GIA = comboBoxEdit10.Text;

            //if (isAddForm)
            //{
            //    if (b.insertHangHoa(d))
            //        MessageBox.Show("Thao tác thành công");
            //    else MessageBox.Show("Thao tác không thành công");
            //}
            //else
            //{
            //    b.updateHangHoa(d);
            //    MessageBox.Show("Thao tác hóa thành công");
            //}
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Add_Load(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                BUSDoiTac b = new BUSDoiTac();
                DTOKhachHang dtoHangHoa = b.getKhachHangDetail(gotID);
                textEdit1.Text = dtoHangHoa.MAKH;
                textEdit2.Text = dtoHangHoa.HOTEN;
                textEdit3.Text = dtoHangHoa.DCHI;
                textEdit6.Text = dtoHangHoa.SODT;
            }
        }
    }
}