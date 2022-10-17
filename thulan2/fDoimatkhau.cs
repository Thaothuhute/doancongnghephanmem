using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2;
using thulan2.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quanliphongtro
{
    public partial class fDoimatkhau : Form
    {
        public fDoimatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "" || txtMatkhau.Text == "" || txtMatkhaumoi.Text == "" || txtNhaplai.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
            }
            else
            {
                if (checkuser(txtTaikhoan.Text))
                {
                    if(checkpass(txtMatkhau.Text))
                    {
                        if(txtMatkhaumoi.Text==txtNhaplai.Text)
                        {
                            phongtroDBContext context = new phongtroDBContext();
                            Account dbUpdate = context.Accounts.FirstOrDefault(p=>p.Username==txtTaikhoan.Text);
                            if(dbUpdate!=null)
                            {
                                dbUpdate.Password = txtMatkhaumoi.Text;
                                context.SaveChanges();
                            }
                            MessageBox.Show("Đã cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Không trùng mật khẩu mới!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không tồn tại");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
        }


        private bool checkuser(string username)
        {
            using (phongtroDBContext phongtro = new phongtroDBContext())
            {
                Account ac = phongtro.Accounts.FirstOrDefault(p => p.Username==username);   
                if(ac==null)
                {
                    return false;
                }
                return true;
            } 
        }
        private bool checkpass(string passwd)
        {
            using(phongtroDBContext phongtro = new phongtroDBContext())
            {
                Account ac = phongtro.Accounts.FirstOrDefault(p => p.Password == passwd);
                if (ac == null)
                {
                    return false;
                }
                return true;
            }    
        }
        
    }
}
