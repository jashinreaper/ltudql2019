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
namespace ltudql_seminar_qlbh.frmHeThong.frmBaoMat
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show(DTOcurrentUser.username);
            BUSBaoMat b = new BUSBaoMat();
            if(b.isCorrect(DTOcurrentUser.username, textEdit1.Text))
            { 
                if(textEdit2.Text == textEdit3.Text)
                {
                    if (b.updatePassword(DTOcurrentUser.username, textEdit2.Text))
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập mật khẩu mới không trùng khớp");

                }

            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}