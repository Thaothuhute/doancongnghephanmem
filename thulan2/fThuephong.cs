using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2.Model;

namespace quanliphongtro
{
    public partial class fThuephong : Form
    {
        public fThuephong()
        {
            InitializeComponent();
            form_loaf();
        }

        private  void form_loaf()
        {
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnMohinh.Enabled = false;
            btnThem.Enabled = true;
           
            using (phongtroDBContext context = new phongtroDBContext())
            {
                List<PHONG> pos = context.PHONGs.ToList();
                List<HOPDONG> lhd = context.HOPDONGs.ToList();
                Filldatathuephong(lhd);
                Filldatagrid(pos);
                loafCbbPo(pos);
            }
            

        }
        
        private void Filldatagrid(List<PHONG> pos)
        {
            dgvPhong.Rows.Clear();
            foreach (PHONG item in pos)
            {
                int index = dgvPhong.Rows.Add();
                
                dgvPhong.Rows[index].Cells[0].Value = item.Sop.ToString();
                dgvPhong.Rows[index].Cells[1].Value = item.Sonuocdauthang.ToString();
                dgvPhong.Rows[index].Cells[2].Value = item.Sodiendauthang.ToString();
                dgvPhong.Rows[index].Cells[3].Value = item.Tang.ToString();
                if (item.Trangthai == 1)
                {
                    dgvPhong.Rows[index].Cells[4].Value = "da thue";
                }
                else
                {
                    dgvPhong.Rows[index].Cells[4].Value = "con trong";
                }
            }
        }
        private void Filldatathuephong(List<HOPDONG> lhd)
        {
            dgvhopdong.Rows.Clear();
            foreach( HOPDONG hd  in lhd)
            {
                int index = dgvhopdong.Rows.Add();
                dgvhopdong.Rows[index].Cells[0].Value = hd.KHACHHANG.Tenkh;
                dgvhopdong.Rows[index].Cells[1].Value = hd.PHONG.Sop;
                dgvhopdong.Rows[index].Cells[2].Value = hd.Ngaylapphieu;
                dgvhopdong.Rows[index].Cells[3].Value = hd.Ngayhethan;
                if (hd.Trangthai == 1)
                {
                    dgvhopdong.Rows[index].Cells[4].Value = "Disnable";
                }
                else
                    dgvhopdong.Rows[index].Cells[4].Value = "Active";
            }
        }
        private void loafCbbPo(List<PHONG> pos)
        {
            cbbSophong.DataSource = pos;
            cbbSophong.DisplayMember = "Sop";
            cbbSophong.ValueMember = "Sop";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fThuephong_Load(object sender, EventArgs e)
        {

        }

        private void btnDpng_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool checkFull()
        {
            if(txtTenkhach.Text =="" || txtCccd.Text ==""||txtSodienthoai.Text == "")
            {
                
                return false;
            }
            else
            {
                if (!checkphone(txtSodienthoai.Text,txtCccd.Text) || !checkname(txtTenkhach.Text) )
                {
                   
                    bool check =checkphone(txtSodienthoai.Text,txtCccd.Text);
                    if (check) { }
                    return false;
                }
                else
                    return true;
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            txtTenkhach.Enabled = true;
            txtSodienthoai.Enabled = true;
            txtCccd.Enabled = true;
            
            dtpNgaythue.Enabled = true;
            btnMohinh.Enabled = true;
            btnThem.Enabled = false;
            

        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            txtSonuoc.Text = dgvPhong.Rows[index].Cells[1].Value.ToString();
            txtSodien.Text = dgvPhong.Rows[index].Cells[2].Value.ToString();
            cbbtang.SelectedValue = dgvPhong.Rows[index].Cells[3].Value.ToString();
            cbbSophong.Text = dgvPhong.Rows[index].Cells[0].Value.ToString();
            
        }

        string hinh = "";
        private void addkhacnghang()
        {
            try
            {
                using (phongtroDBContext context = new phongtroDBContext())
                {
                    KHACHHANG kh;
                    List<KHACHHANG> liskh = context.KHACHHANGs.ToList();
                    if (liskh.Count < 1)
                    {
                       
                        kh = new KHACHHANG() { Makh = "KH1", CMND = txtCccd.Text, Tenkh = txtTenkhach.Text, MinhchungCMND = hinh, gioitinh = true ,Sdt = txtSodien.Text};

                    }
                    else
                    {
                        kh = new KHACHHANG() { Makh = "KH" + (liskh.Count + 1).ToString() + "", CMND = txtCccd.Text, Tenkh = txtTenkhach.Text, MinhchungCMND = hinh, gioitinh = true };
                    }
                    List<HOPDONG> lishd = context.HOPDONGs.ToList();
                    
                    HOPDONG hd = new HOPDONG()
                    {
                        Mahd = "HD" + (lishd.Count + 1).ToString() + "",
                        Ngaylapphieu = dtpNgaythue.Value,
                        Ngayhethan = dtpHan.Value,
                        Tiencoc = int.Parse(txtTiencoc.Text),
                        Sop = cbbSophong.SelectedValue.ToString(),

                        Makh = kh.Makh,
                        Trangthai = 1
                    };
                    context.KHACHHANGs.Add(kh);
                    context.SaveChanges();

                    context.HOPDONGs.Add(hd);
                    context.SaveChanges();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnLuu_Click(object sender, EventArgs e) 
        {
            int index = dgvPhong.RowCount;
            if(!checkFull())
            {
                MessageBox.Show("vui long dien du thong tin");
            }
            else
            {
                try
                {
                    using (phongtroDBContext context = new phongtroDBContext())
                    {
                        PHONG po = context.PHONGs.FirstOrDefault(p => p.Sop == cbbSophong.SelectedValue.ToString());
                        MessageBox.Show(cbbSophong.SelectedValue.ToString());
                        if(po != null)
                        {
                            if (po.Trangthai == 0)
                            {
                                addkhacnghang();
                                po.Trangthai = 1;

                                context.SaveChanges();
                                MessageBox.Show("da cap nhat");
                                hinh = "";
                            }
                            else
                            {
                                MessageBox.Show("phong da co nguoi thue");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                form_loaf();
            }
        }
    
        private void btnMohinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult re = opf.ShowDialog();

            if(re == DialogResult.OK)
            {
                Image img = Image.FromFile(opf.FileName);
                pictureBox1.Image = img;
                hinh = opf.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                hinh = opf.FileName;
            }
        }

        private void dtpNgaythue_ValueChanged(object sender, EventArgs e)
        {
            dtpHan.Value = dtpNgaythue.Value;
            dtpHan.Value = new DateTime(dtpNgaythue.Value.Year +1 , dtpNgaythue.Value.Month, dtpNgaythue.Value.Day) ;
        }
        private bool checkphone(string number,string Id)
        {
            if( Regex.Match(number, @"^(\[0-9]{10,11}$)").Success && Regex.Match(Id, @"^(\[0-9]{12}$)").Success)
            {
                return true;
            }
            return false;
        }
        private bool checkname(string name)
        {
            var withoutSpecial = new string(name.Where(c => Char.IsLetterOrDigit(c)
                                            || Char.IsWhiteSpace(c)).ToArray());

            if (name != withoutSpecial)
            {
                return false;
            }
            return true;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtCccd.Clear();
            txtSodienthoai.Clear();
            txtTenkhach.Clear();
            form_loaf();
            btnThem.Enabled = true;
            pictureBox1.Image = null;


        }

        private void dgvhopdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}
