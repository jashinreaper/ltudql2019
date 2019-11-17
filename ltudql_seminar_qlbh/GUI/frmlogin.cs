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
    public partial class frmlogin : Form
    {
        ConnectionToSQL Conn = new ConnectionToSQL();
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
            DataTable dt = new DataTable();
            dt= Conn.GetData("select * from NHANVIEN where TENDANGNHAP='" + tbdangnhap.Text + "' and MATKHAU='" + tbmatkhau.Text + "'");
            if(dt.Rows.Count>0)
            {
                MessageBox.Show("Đăng nhập thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmmain f = new frmmain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbnhomatkhau_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu mật khẩu thành công");
        }
    }
}
