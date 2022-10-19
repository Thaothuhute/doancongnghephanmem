using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2.Model;

namespace quanliphongtro
{
    public partial class fKhachhang : Form
    {
        public fKhachhang()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = MSI\SQLEXPRESS; Initial Catalog = Qlyphongtro; Integrated Security = True");
        private void form_loaf()
        {
            conn.Open();
            using (phongtroDBContext context = new phongtroDBContext())
            {
                List<KHACHHANG> kh = context.KHACHHANGs.ToList();
                Filldatagridkhach(kh);
            }

        }
        private void loafCbbPo(List<PHONG> pos)
        {
            cbbSP.DataSource = pos;
            cbbSP.DisplayMember = "Sop";
            cbbSP.ValueMember = "Sop";
        }
        private void Filldatagridkhach(List<KHACHHANG> kh)
        {
            dgvKhachhang.Rows.Clear();
            foreach (KHACHHANG item in kh)
            {
                int index = dgvKhachhang.Rows.Add();
                dgvKhachhang.Rows[index].Cells[0].Value = item.Tenkh.ToString();
                string tenkh = item.Tenkh.ToString();
                dgvKhachhang.Rows[index].Cells[1].Value = item.CMND.ToString();
                dgvKhachhang.Rows[index].Cells[2].Value = item.Sdt.ToString();
                if (item.gioitinh == true)
                {
                    dgvKhachhang.Rows[index].Cells[3].Value = "Nam";
                }
                else
                {
                    dgvKhachhang.Rows[index].Cells[3].Value = "Nu";
                }

                dgvKhachhang.Rows[index].Cells[4].Value = item.HOPDONGs.FirstOrDefault(p => p.KHACHHANG.Tenkh.StartsWith(tenkh)).Sop.ToString();
            }
        }
        private Boolean Exe(string cmd)
        {

            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            conn.Close();
            return check;
        }
        private DataTable Red(string cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }
            conn.Close();
            return dt;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Exe("UPDATE KHACHHANG SET Sdt = N'" + txtSDT.Text + "' WHERE CMND = '" + txtCMND.Text + "'  ");
            form_loaf();
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKhachHang.Text = dgvKhachhang.CurrentRow.Cells[0].Value.ToString();
            txtCMND.Text = dgvKhachhang.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachhang.CurrentRow.Cells[2].Value.ToString();
            lblGioitinh.Text = dgvKhachhang.CurrentRow.Cells[3].Value.ToString();
            cbbSP.Text = dgvKhachhang.CurrentRow.Cells[4].Value.ToString();

        }

        string hinh = "";
        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            DialogResult re = opf.ShowDialog();

            if (re == DialogResult.OK)
            {
                Image img = Image.FromFile(opf.FileName);
                pictureBox1.Image = img;
                hinh = opf.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                hinh = opf.FileName;
            }
        }

        private void fKhachhang_Load(object sender, EventArgs e)
        {
            form_loaf();    
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DataTable dt = Red("SELECT * FROM KHACHHANG WHERE maTT = '" + txtTenKhachHang.Text + "' ");
            if (dt != null)
            {
                dgvKhachhang.DataSource = dt;
            }
        }
            private void btnHuy_Click(object sender, EventArgs e)
            {
                txtTenKhachHang.ResetText();
                txtCMND.ResetText();
                txtSDT.ResetText();
                lblGioitinh.ResetText();
                cbbSP.ResetText();
            }
    }
 }
