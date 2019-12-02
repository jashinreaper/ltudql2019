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
            BUSDoiTac b = new BUSDoiTac();
            DTOKhachHang d = new DTOKhachHang();
            d.MAKH = textEdit1.Text;
            d.HOTEN = textEdit2.Text;
            d.DiaChi = textEdit3.Text;
            d.MaSoThue = textEdit4.Text;
            d.Fax = textEdit5.Text;
            d.SODT = textEdit6.Text;
            d.Mobile = textEdit7.Text;
            d.Email = textEdit8.Text;
            d.Website = textEdit9.Text;
            d.TaiKhoan = textEdit10.Text;
            d.NganHang = textEdit11.Text;
            d.NickYahoo = textEdit12.Text;
            d.NguoiLienHe = textEdit13.Text;
            d.NickSkype = textEdit14.Text;
            d.MaKhuVuc = comboBoxEdit1.Text;
            d.GioiHanNo = comboBoxEdit2.Text;
            d.NoHienTai = comboBoxEdit3.Text;
            d.ChietKhau = comboBoxEdit4.Text;
            d.ConQuanLy = checkEdit1.Checked;
            d.DaiLy = radioButton1.Checked;
            d.KhachLe = radioButton2.Checked;
            if (isAddForm)
            {
                if (b.insertKhachHang(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateKhachHang(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhachHang_Add_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            BUSDoiTac bus = new BUSDoiTac();
            dt2 = bus.getKhuVuc();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit1.Properties.Items.Add(row["MaKhuVuc"]);
                }
            }

            if (!isAddForm)
            {
                BUSDoiTac b = new BUSDoiTac();
                DTOKhachHang dtoHangHoa = b.getKhachHangDetail(gotID);
                textEdit1.Text = dtoHangHoa.MAKH;
                textEdit2.Text = dtoHangHoa.HOTEN;
                textEdit3.Text = dtoHangHoa.DiaChi;
                textEdit4.Text = dtoHangHoa.MaSoThue;
                textEdit5.Text = dtoHangHoa.Fax;
                textEdit6.Text = dtoHangHoa.SODT;
                textEdit7.Text = dtoHangHoa.Mobile;
                textEdit8.Text = dtoHangHoa.Email;
                textEdit9.Text = dtoHangHoa.Website;
                textEdit10.Text = dtoHangHoa.TaiKhoan;
                textEdit11.Text = dtoHangHoa.NganHang;
                textEdit12.Text = dtoHangHoa.NickYahoo;
                textEdit13.Text = dtoHangHoa.NguoiLienHe;
                textEdit14.Text = dtoHangHoa.NickSkype;
                comboBoxEdit1.Text = dtoHangHoa.MaKhuVuc;
                comboBoxEdit2.Text = dtoHangHoa.GioiHanNo;
                comboBoxEdit3.Text = dtoHangHoa.NoHienTai;
                comboBoxEdit4.Text = dtoHangHoa.ChietKhau;
                radioButton1.Checked = dtoHangHoa.DaiLy;
                radioButton2.Checked = dtoHangHoa.KhachLe;
                checkEdit1.Checked = dtoHangHoa.ConQuanLy;


            }
            else
            {
                textEdit1.ReadOnly = false;
            }
        }
    }
}