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

        private void toolStripTextBoxQLTK_Click(object sender, EventArgs e)
        {
            fDoimatkhau doiMK= new fDoimatkhau();
            doiMK.Show();
        }

        private void toolStripTextBoxQLPT_Click(object sender, EventArgs e)
        {
            fPhongtro phongtro=new fPhongtro();
            phongtro.Show();
        }

        //private void toolStripTextBoxQLHD_Click(object sender, EventArgs e)
        //{
        //    fHopdong hopDong = new fHopdong();
        //    hopDong.Show();
        //}

        private void toolStripTextBoxQLKH_Click(object sender, EventArgs e)
        {
            fKhachhang khachHang = new fKhachhang();
            khachHang.Show();
        }
    }
}
