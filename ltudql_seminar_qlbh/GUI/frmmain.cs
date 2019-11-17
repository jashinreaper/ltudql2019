using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltudql_seminar_qlbh
{
    public partial class frmmain : Form
    {
        string tendangnhap = "", tennhanvien = "", matkhau = "", quyen = "";

       

        public frmmain()
        {
            InitializeComponent();
        }

        public frmmain(string tendangnhap, string tennhanvien, string matkhau, string quyen)
        {
            InitializeComponent();
            this.tendangnhap = tendangnhap;
            this.tennhanvien = tennhanvien;
            this.matkhau = matkhau;
            this.quyen = quyen;
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn được quyền thao tác ", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                MessageBox.Show("Bạn được quyền thao tác ", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bạn không được quyền thao tác ", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn được quyền thao tác ", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
