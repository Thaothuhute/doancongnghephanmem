using quanliphongtro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanliphongtro.Model;
using System.Data.SqlClient;

namespace quanliphongtro
{
    public partial class fDoimatkhau : Form
    {
        public fDoimatkhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection conn = new SqlConnection(@"data source=LAPTOP-B9UJ254M\MSSQLSERVER01;initial catalog=Qlyphongtro;integrated security=True");

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select count(*) from Account where Username =N'" + "' and Password =N'", conn);
            DataTable dt = new DataTable();
            conn.Open();
            string tk = txtTaikhoan.Text;
            string mk = txtMatkhaucu.Text;
            string sql = "select *from Account where Username='" + tk + "' and Password='" + mk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader data = cmd.ExecuteReader();
            //da.Fill(dt);
            errorProvider1.Clear(); //xuất hiện dấu x và hiện thông báo khi thao tác sai
            if (data.Read() == true)
            {
                if (dt.Rows.ToString() == "1")
                {
                    if (txtMatkhaumoi.Text == txtNhaplai.Text)
                    {
                        if (txtMatkhaumoi.Text.Length > 6) //khi đổi mật khẩu bạn phải có nhiều hơn 6 kí tự
                        {
                            SqlDataAdapter dal = new SqlDataAdapter("Update Account set Password = N'" + txtMatkhaumoi.Text + "'where Username =N'" + txtTaikhoan.Text + "'and Password =N'" + txtMatkhaucu.Text + "'", conn);
                            DataTable dt1 = new DataTable();
                            dal.Fill(dt1);
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            errorProvider1.SetError(txtMatkhaumoi, "Độ dài mật khẩu không đủ!");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtMatkhaumoi, "Bạn chưa điền mật khẩu!");
                        errorProvider1.SetError(txtNhaplai, "Mật khẩu nhập lại chưa đúng!");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtTaikhoan, "Tên người dùng không đúng!");
                    errorProvider1.SetError(txtMatkhaucu, "Mật khẩu cũ không đúng!");
                }
            }



        }

        private void fDoimatkhau_Load(object sender, EventArgs e)
        {
          
        }
    }
}
