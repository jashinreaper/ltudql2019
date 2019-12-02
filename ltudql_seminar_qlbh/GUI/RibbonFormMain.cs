using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ltudql_seminar_qlbh.MainForm;
using ltudql_seminar_qlbh.frmDanhMuc.frmDoiTac;
using ltudql_seminar_qlbh.frmHeThong.frmHeThong;
using ltudql_seminar_qlbh.frmHeThong.frmBaoMat;
using ltudql_seminar_qlbh.frmHeThong.frmDuLieu;

namespace ltudql_seminar_qlbh
{
    public partial class RibbonFormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonFormMain()
        {
            InitializeComponent();
        }

        private void RibbonFormMain_Load(object sender, EventArgs e)
        {
            frmRole frm = new frmRole();
            //foreach (var item in MdiChildren)
            //{
            //    item.Close();
            //}
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRole frm = new frmRole();
            //foreach (var item in MdiChildren)
            //{
            //    item.Close();
            //}
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn thoát khỏi chương trình chứ?","Chấp nhận?",MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // If 'No', do something here.
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsers frm = new frmUsers();
            //foreach (var item in MdiChildren)
            //{
            //    item.Close();
            //}
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn quay lại màn hình đăng nhập chứ?", "Chấp nhận?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                frmlogin rfm = new frmlogin();
                //rfm.Text = rolename + " - Phần mềm quản lý bán hàng";
                this.Visible = false;
                rfm.ShowDialog();
                this.Close();
            }
            else
            {
                // If 'No', do something here.
            }
            
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHangHoa frm = new frmHangHoa();
            //foreach (var item in MdiChildren)
            //{
            //    item.Close();
            //}
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongTin frm = new frmThongTin();
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSaoLuu frm = new frmSaoLuu();
            frm.Show();
        }
    }
}