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
namespace ltudql_seminar_qlbh.frmHeThong.frmHeThong
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BUSHeTHong bus = new BUSHeTHong();
            DTOThongTin thongTin = new DTOThongTin()
            {
                tendonvi = textEdit1.Text,
                diachi = textEdit2.Text,
                dienthoai = textEdit3.Text,
                fax = textEdit4.Text,
                website = textEdit5.Text,
                email = textEdit6.Text,
                gpkd = textEdit8.Text,
                linhvuc = comboBoxEdit1.Text,
                masothue = textEdit7.Text
            };
            bus.updateLinhVuc(thongTin);
            MessageBox.Show("Cập nhật thông tin thành công");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            BUSHeTHong bus = new BUSHeTHong();
            DataTable dt = new DataTable();
            dt = bus.getThongTin();
            if (dt.Rows.Count > 0)
            {
                textEdit1.Text = dt.Rows[0]["tendonvi"].ToString();
                textEdit2.Text = dt.Rows[0]["diachi"].ToString();
                textEdit3.Text = dt.Rows[0]["dienthoai"].ToString();
                textEdit4.Text = dt.Rows[0]["fax"].ToString();
                textEdit5.Text = dt.Rows[0]["website"].ToString();
                textEdit6.Text = dt.Rows[0]["email"].ToString();
                textEdit7.Text = dt.Rows[0]["masothue"].ToString();
                textEdit8.Text = dt.Rows[0]["gpkd"].ToString();
                comboBoxEdit1.Text = dt.Rows[0]["linhvuc"].ToString();
            }
            DataTable dt2 = new DataTable();
            dt2 = bus.getLinhVuc();
            if (dt2.Rows.Count > 0)
            {
                foreach (DataRow row in dt2.Rows)
                {
                    comboBoxEdit1.Properties.Items.Add(row["tenlinhvuc"]);
                }
            }

        }
    }
}