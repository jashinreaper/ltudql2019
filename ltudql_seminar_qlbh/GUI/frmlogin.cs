using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS;

namespace ltudql_seminar_qlbh
{
    public partial class frmlogin : MaterialForm
    {
        public frmlogin()
        {
            InitializeComponent();
            //var skinManager = MaterialSkinManager.Instance;
            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkinManager.Themes.DARK;
            //skinManager.ColorScheme = new ColorScheme(Primary.LightBlue100, Primary.BlueGrey800, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
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
                bus.getRole(tbUsername.Text);
                MessageBox.Show("dang nhap thanh cong");
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
