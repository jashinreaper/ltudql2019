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
    public partial class frmNhaPhanPhoi_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmNhaPhanPhoi_Add(bool isAdd, string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit1.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }

        private void frmNhaPhanPhoi_Add_Load(object sender, EventArgs e)
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
                DTONhaPhanPhoi dtoHangHoa = b.getNhaPhanPhoiDetail(gotID);
                textEdit1.Text = dtoHangHoa.MaNPP;
                textEdit2.Text = dtoHangHoa.TenNPP;
                textEdit3.Text = dtoHangHoa.DiaChi;
                textEdit4.Text = dtoHangHoa.MaSoThue;
                textEdit5.Text = dtoHangHoa.Fax;
                textEdit6.Text = dtoHangHoa.SODT;
                textEdit7.Text = dtoHangHoa.Mobile;
                textEdit8.Text = dtoHangHoa.Email;
                textEdit9.Text = dtoHangHoa.Website;
                textEdit10.Text = dtoHangHoa.TaiKhoan;
                textEdit11.Text = dtoHangHoa.NganHang;
                textEdit12.Text = dtoHangHoa.NguoiLienHe;
                textEdit13.Text = dtoHangHoa.ChucVu;
                comboBoxEdit1.Text = dtoHangHoa.MaKhuVuc;
                comboBoxEdit2.Text = dtoHangHoa.GioiHanNo;
                comboBoxEdit3.Text = dtoHangHoa.NoHienTai;
                comboBoxEdit4.Text = dtoHangHoa.ChietKhau;
                checkEdit1.Checked = dtoHangHoa.ConQuanLy;


            }
            else
            {
                textEdit1.ReadOnly = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSDoiTac b = new BUSDoiTac();
            DTONhaPhanPhoi d = new DTONhaPhanPhoi();
            d.MaNPP = textEdit1.Text;
            d.TenNPP = textEdit2.Text;
            d.DiaChi = textEdit3.Text;
            d.MaSoThue = textEdit4.Text;
            d.Fax = textEdit5.Text;
            d.SODT = textEdit6.Text;
            d.Mobile = textEdit7.Text;
            d.Email = textEdit8.Text;
            d.Website = textEdit9.Text;
            d.TaiKhoan = textEdit10.Text;
            d.NganHang = textEdit11.Text;
            d.NguoiLienHe = textEdit12.Text;
            d.ChucVu = textEdit13.Text;
            d.MaKhuVuc = comboBoxEdit1.Text;
            d.GioiHanNo = comboBoxEdit2.Text;
            d.NoHienTai = comboBoxEdit3.Text;
            d.ChietKhau = comboBoxEdit4.Text;
            d.ConQuanLy = checkEdit1.Checked;
            if (isAddForm)
            {
                if (b.insertNhaPhanPhoi(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateNhaPhanPhoi(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}