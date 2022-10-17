using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2.Model;

namespace quanliphongtro
{
    public partial class fPhongtro : Form
    {
        phongtroDBContext context = new phongtroDBContext();
        public fPhongtro()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loafCbbPo(List<PHONG> pos)
        {
            cbbSP.DataSource = pos;
            cbbSP.DisplayMember = "Sop";
            cbbSP.ValueMember = "Sop";
        }
        private void loafCbbTa(List<PHONG> tag)
        {
            cbbST.DataSource = tag;
            cbbST.DisplayMember = "Tang";
            cbbST.ValueMember = "Tang";
        }

        private void loafCbbTT(List<PHONG> tth)
        {
            cbbTT.DataSource = tth;
            cbbTT.DisplayMember = "Trangthai";
            cbbTT.ValueMember = "Trangthai";
        }

        private int GetSelectedRow(string sophong)
        {
            for(int i = 0; i < dgvPhongtro.Rows.Count; i++)
            {
                if (dgvPhongtro.Rows[i].Cells[0].Value.ToString()== sophong)
                {
                    return i;
                }    
            }  
            return -1;
        }
        private void InsertUpdate(int selectRow)
        {
            dgvPhongtro.Rows[selectRow].Cells[0].Value=cbbSP.Text;
            dgvPhongtro.Rows[selectRow].Cells[1].Value=cbbST.Text;
            dgvPhongtro.Rows[selectRow].Cells[2].Value = txtGia.Text;
            dgvPhongtro.Rows[selectRow].Cells[3].Value = cbbTT.Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
        public bool Kiemtradulieu()
        {
            if (cbbSP.Text == "" || cbbST.Text == "" || cbbTT.Text == "")
            {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                    return false;
            }
             else
             {
             }
        }
        private void loaddgv(List<PHONG> listPhong)
        {
            dgvPhongtro.Rows.Clear();
            foreach(var item in listPhong)
            {
                int index = dgvPhongtro.Rows.Add();
                dgvPhongtro.Rows[index].Cells[0].Value = item.Sop;
                dgvPhongtro.Rows[index].Cells[1].Value = item.Tang;
                dgvPhongtro.Rows[index].Cells[2].Value = "3000000";
                dgvPhongtro.Rows[index].Cells[3].Value = item.Trangthai;
            }    
        }
        private void ResetForm()
        {
            cbbSP.SelectedIndex = 0;
            cbbST.SelectedIndex = 0;
            cbbTT.SelectedIndex = 0;
        }
        private void fPhongtro_Load(object sender, EventArgs e)
        {
                List<PHONG> pHONGs = context.PHONGs.ToList();
                loafCbbPo(pHONGs);
                loafCbbTa(pHONGs);
                loafCbbTT(pHONGs);
                loaddgv(pHONGs);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectRow = GetSelectedRow(cbbSP.Text);
                if(selectRow == -1)
                {
                    throw new Exception("Không tìm số phòng cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if(dr == DialogResult.Yes)
                    {
                        dgvPhongtro.Rows.RemoveAt(selectRow);
                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
