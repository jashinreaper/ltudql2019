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
    public partial class frmKhuVuc_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmKhuVuc_Add(bool isAdd, string id)
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
            DTOKhuVuc d = new DTOKhuVuc();
            d.MaKhuVuc = textEdit1.Text;
            d.TenKhuVuc = textEdit2.Text;
            d.GhiChu = textEdit3.Text;
            d.ConQuanLy = checkEdit1.Checked;

            if (isAddForm)
            {
                if (b.insertKhuVuc(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateKhuVuc(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmKhuVuc_Add_Load(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                BUSDoiTac b = new BUSDoiTac();
                DTOKhuVuc dtoHangHoa = b.getKhuVucDetail(gotID);
                textEdit1.Text = dtoHangHoa.MaKhuVuc;
                textEdit2.Text = dtoHangHoa.TenKhuVuc;
                textEdit3.Text = dtoHangHoa.GhiChu;
                checkEdit1.Checked = dtoHangHoa.ConQuanLy;
            }
            else
            {
                textEdit1.ReadOnly = false;
            }
        }
    }
}