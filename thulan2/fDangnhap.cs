using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using quanliphongtro.Model;

namespace quanliphongtro
{
    public partial class fDangnhap : Form
    {
        public fDangnhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = MSI\SQLEXPRESS; Initial Catalog = Qlyphongtro; Integrated Security = True");
            try
            {
                conn.Open();
                string tk = txtTaikhoan.Text;
                string mk = txtMatkhau.Text;
                string sql = "select *from Account where Username='" + tk + "' and Password='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read()==true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fMenu frm = new fMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if(tb == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            fMenu menu = new fMenu();
            menu.Show();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
