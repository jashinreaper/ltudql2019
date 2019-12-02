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
namespace ltudql_seminar_qlbh.frmHeThong.frmDuLieu
{
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        public frmSaoLuu()
        {
            InitializeComponent();
        }
        string path = "";
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog openFileDialog1 = new SaveFileDialog();
            openFileDialog1.ShowDialog();
            textEdit1.Text = System.IO.Path.GetFileName(openFileDialog1.FileName.ToString()+".bak");
            textEdit2.Text = System.IO.Path.GetDirectoryName(openFileDialog1.FileName.ToString());
            path = textEdit2.Text +"\\"+ textEdit1.Text;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BUSDuLieu b = new BUSDuLieu();
            b.backupDB(path);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}