using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;

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
                string role = bus.getRole(tbUsername.Text);
                string rolename = bus.getRoleName(tbUsername.Text);
                RibbonFormMain rfm = new RibbonFormMain();
                rfm.Text = rolename + " - Phần mềm quản lý bán hàng";
                this.Visible = false;
                rfm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("sai mat khau");
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
