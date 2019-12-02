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
    public partial class frmHangHoa_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmHangHoa_Add(bool isAdd, string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit2.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }


        private void frmHangHoa_Add_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            BUSKhoHang bus = new BUSKhoHang();
            dt2 = bus.getKho();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit1.Properties.Items.Add(row["TenKho"]);
                }
            }
            dt2 = new DataTable();
            dt2 = bus.getBangNhomHang();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit2.Properties.Items.Add(row["TenNH"]);
                }
            }
            dt2 = new DataTable();
            dt2 = bus.getBangDonVi();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit3.Properties.Items.Add(row["TenDV"]);
                }
            }
            dt2 = new DataTable();
            BUSDoiTac bus2 = new BUSDoiTac();
            dt2 = bus2.getNhaPhanPhoi();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit7.Properties.Items.Add(row["TenNPP"]);
                }
            }
            ////////////////////
            if (!isAddForm)
            {
                BUSKhoHang b = new BUSKhoHang();
                DTOHangHoa dtoHangHoa = b.getHangHoaDetail(gotID);
                radioButton1.Checked = dtoHangHoa.VatTu; 
                radioButton1.Checked = dtoHangHoa.DichVu;
                textEdit1.Text = dtoHangHoa.XuatXu;
                textEdit2.Text = dtoHangHoa.MaHH;
                 textEdit3.Text = dtoHangHoa.MaVachNSX;
                textEdit4.Text = dtoHangHoa.TENHH;
                comboBoxEdit1.Text = dtoHangHoa.MaKhoHang;
                comboBoxEdit2.Text = dtoHangHoa.PhanLoai;
                comboBoxEdit3.Text = dtoHangHoa.MaDonVi;
                comboBoxEdit7.Text = dtoHangHoa.MaNhaCungCap;
                comboBoxEdit4.Text = dtoHangHoa.Thue;
                comboBoxEdit5.Text = dtoHangHoa.TonKhoToiThieu;
                comboBoxEdit6.Text = dtoHangHoa.TonKhoHienTai;
                comboBoxEdit8.Text = dtoHangHoa.GiaMua;
                comboBoxEdit9.Text = dtoHangHoa.GiaSi;
                comboBoxEdit10.Text = dtoHangHoa.GiaLe; 
            }
            else
            {
                textEdit2.ReadOnly = false;
                comboBoxEdit6.Text = "0";
            }
        }

        private void imageEdit1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSKhoHang b = new BUSKhoHang();
            DTOHangHoa dtoHangHoa = new DTOHangHoa();
            dtoHangHoa.VatTu = radioButton1.Checked;
            dtoHangHoa.DichVu = radioButton1.Checked;
            dtoHangHoa.XuatXu = textEdit1.Text;
            dtoHangHoa.MaHH = textEdit2.Text;
            dtoHangHoa.MaVachNSX = textEdit3.Text;
            dtoHangHoa.TENHH = textEdit4.Text;
            dtoHangHoa.MaKhoHang = comboBoxEdit1.Text;
            dtoHangHoa.PhanLoai = comboBoxEdit2.Text;
            dtoHangHoa.MaDonVi = comboBoxEdit3.Text;
            dtoHangHoa.MaNhaCungCap = comboBoxEdit7.Text;
            dtoHangHoa.Thue = comboBoxEdit4.Text;
            dtoHangHoa.TonKhoToiThieu = comboBoxEdit5.Text;
            dtoHangHoa.TonKhoHienTai = comboBoxEdit6.Text;
            dtoHangHoa.GiaMua = comboBoxEdit8.Text;
            dtoHangHoa.GiaSi = comboBoxEdit9.Text;
            dtoHangHoa.GiaLe = comboBoxEdit10.Text;

            if (isAddForm)
            {
                if (b.insertHangHoa(dtoHangHoa))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateHangHoa(dtoHangHoa);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }
    }
}