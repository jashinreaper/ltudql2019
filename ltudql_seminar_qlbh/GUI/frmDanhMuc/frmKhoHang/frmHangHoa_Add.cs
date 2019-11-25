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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            BUSHangHoa b = new BUSHangHoa();
            DTOHangHoa d = new DTOHangHoa();
            d.MASP = textEdit2.Text;
            d.TENSP = textEdit4.Text;
            d.DVT = comboBoxEdit3.Text;
            d.NUOCSX = textEdit1.Text;
            d.GIA = comboBoxEdit10.Text;

            if (isAddForm)
            {
                if (b.insertHangHoa(d))
                    MessageBox.Show("Thao tác thành công");
                else MessageBox.Show("Thao tác không thành công");
            }
            else
            {
                b.updateHangHoa(d);
                MessageBox.Show("Thao tác hóa thành công");
            }
        }

        private void frmHangHoa_Add_Load(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                BUSHangHoa b = new BUSHangHoa();
                DTOHangHoa dtoHangHoa = b.getHangHoaDetail(gotID);
               textEdit2.Text = dtoHangHoa.MASP;
                 textEdit4.Text = dtoHangHoa.TENSP; 
                 comboBoxEdit3.Text = dtoHangHoa.DVT; 
                textEdit1.Text = dtoHangHoa.NUOCSX; 
                 comboBoxEdit10.Text = dtoHangHoa.GIA; 
            }
        }

        private void imageEdit1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}