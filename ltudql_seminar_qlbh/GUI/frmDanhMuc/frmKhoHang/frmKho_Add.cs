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
    public partial class frmKho_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmKho_Add(bool isAdd, string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit1.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }

        private void frmKho_Add_Load(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                BUSKhoHang b = new BUSKhoHang();
                DTOKho dtoHangHoa = b.getKhoDetail(gotID);
                textEdit1.Text = dtoHangHoa.MaKho;
                textEdit2.Text = dtoHangHoa.TenKho;
                textEdit3.Text = dtoHangHoa.NguoiLienHe;
                textEdit4.Text = dtoHangHoa.DiaChi;
                textEdit5.Text = dtoHangHoa.SODT;
                textEdit6.Text = dtoHangHoa.Mobile;
                textEdit7.Text = dtoHangHoa.Fax;
                textEdit8.Text = dtoHangHoa.Email;
                textEdit9.Text = dtoHangHoa.NguoiQuanLy;
                textEdit10.Text = dtoHangHoa.DienGiai;
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
            DTOKho d = new DTOKho();
            d.MaKho = textEdit1.Text;
            d.TenKho = textEdit2.Text;
            d.NguoiLienHe = textEdit3.Text;
            d.DiaChi = textEdit4.Text;
            d.SODT = textEdit5.Text;
            d.Mobile = textEdit6.Text;
            d.Fax = textEdit7.Text;
            d.Email = textEdit8.Text;
            d.NguoiQuanLy = textEdit9.Text;
            d.DienGiai = textEdit10.Text;
            d.ConQuanLy = checkEdit1.Checked;
            if (isAddForm)
            {
                if (b.insertKho(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateKho(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}