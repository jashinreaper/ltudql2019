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
namespace ltudql_seminar_qlbh.frmBaoMat
{
    public partial class frmUser_Add : DevExpress.XtraEditors.XtraForm
    {
        static bool isAddForm;
        static string gotID;
        public frmUser_Add(bool isAdd,string id)
        {
            InitializeComponent();
            if (isAdd)
                textEdit2.ReadOnly = false;
            isAddForm = isAdd;
            gotID = id;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textEdit2.Text == textEdit3.Text)
            {
                BUSBaoMat b = new BUSBaoMat();
                DTOUser d = new DTOUser();
                d.userfullname = textEdit1.Text;
                d.username = textEdit5.Text;
                d.userpassword = textEdit2.Text;
                d.rolename = comboBoxEdit1.Text;
                d.roledes = textEdit4.Text;
                d.isactive = checkEdit1.Checked;
                d.userid = textEdit6.Text;
                //MessageBox.Show(d.rolename);
                if (isAddForm)
                {
                    if (b.insertUser(d))
                        MessageBox.Show("Thao tác thành công");
                    else MessageBox.Show("Thao tác không thành công");
                }
                else
                {
                    b.updateUser(d);
                    MessageBox.Show("Thao tác hóa thành công");
                }
            }else

                MessageBox.Show("Mật khẩu không trùng khớp");
        }
    

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmUser_Add_Load(object sender, EventArgs e)
        {
            BUSBaoMat bus = new BUSBaoMat();
            DataTable dt2 = new DataTable();
            dt2 = bus.getComboBoxRoles();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit1.Properties.Items.Add(row["rolename"]);
                }
            }
            if (!isAddForm)
            {
                BUSBaoMat b = new BUSBaoMat();
                DTOUser dtoHangHoa = b.getUserDetail(gotID);
                textEdit1.Text = dtoHangHoa.userfullname;
                textEdit2.Text = dtoHangHoa.userpassword;
                textEdit3.Text = dtoHangHoa.userpassword;
                comboBoxEdit1.Text = dtoHangHoa.rolename;
                textEdit4.Text = dtoHangHoa.roledes;
                textEdit5.Text = dtoHangHoa.username;
                textEdit6.Text = gotID;
                checkEdit1.Checked = dtoHangHoa.isactive;
            }
            else
            {
                textEdit1.ReadOnly = false;
                    textEdit5.ReadOnly = false;
                textEdit6.ReadOnly = false;
            }
        }
    }
}