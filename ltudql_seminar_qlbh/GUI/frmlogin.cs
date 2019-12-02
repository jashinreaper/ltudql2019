using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ltudql_seminar_qlbh
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btxacnhan_Click(object sender, EventArgs e)
        {
            var bus = new BUSLogin();
            if(bus.isCorrect(tbUsername.Text,tbPassword.Text) ==true)
            {
                DTOcurrentUser.roleid = bus.getRole(tbUsername.Text);
                DTOcurrentUser.rolename = bus.getRoleName(tbUsername.Text);
                RibbonFormMain rfm = new RibbonFormMain();
                rfm.Text = DTOcurrentUser.rolename + " - Phần mềm quản lý bán hàng";
                this.Visible = false;
                rfm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu!");
            }
        }

        private void cbnhomatkhau_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
