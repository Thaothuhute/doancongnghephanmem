using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliphongtro
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            fThongke thongke = new fThongke();
            thongke.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            fThongke f = new fThongke();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            fDoimatkhau doiMK = new fDoimatkhau();
            doiMK.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            fHopdong hopdong = new fHopdong();
            hopdong.ShowDialog();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            fPhongtro phongTro = new fPhongtro();
            phongTro.ShowDialog();
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            fKhachhang khachhang = new fKhachhang();
            khachhang.ShowDialog();
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            fThuephong thuephong = new fThuephong();
            thuephong.ShowDialog();
        }
    }
}
