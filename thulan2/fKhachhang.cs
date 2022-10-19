using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
        private void openCon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        private void closeCon()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        private void form_loaf()
        {
            openCon();
            btnHuy.Enabled = false;
            btnTim.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = true;
            using (phongtroDBContext context = new phongtroDBContext())
            {
                List<KHACHHANG> kh = context.KHACHHANGs.ToList();
                Filldatagridkhach(kh);            
            }

        }


        private void Filldatagridkhach(List<KHACHHANG> kh)
        {
            dgvKhachhang.Rows.Clear();
            foreach (KHACHHANG item in kh)
            {
                int index = dgvKhachhang.Rows.Add();

                dgvKhachhang.Rows[index].Cells[0].Value = item.Tenkh.ToString();
                dgvKhachhang.Rows[index].Cells[1].Value = item.CMND.ToString();
                dgvKhachhang.Rows[index].Cells[2].Value = item.Sdt.ToString();
                dgvKhachhang.Rows[index].Cells[3].Value = item.gioitinh.ToString();
            }
        }

        private void loafCbbPo(List<PHONG> pos)
        {
            cbbSP.DataSource = pos;
            cbbSP.DisplayMember = "Sop";
            cbbSP.ValueMember = "Sop";
        }
        private Boolean Exe(string cmd)
        {
            openCon();
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
            closeCon();
            return check;
        }
        private DataTable Red(string cmd)
        {
            openCon();
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
                throw;
            }
            closeCon();
            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            form_loaf();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = true;
            btnXoa.Enabled = true;
            txtTenKhachHang.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;

            lblGioitinh.Enabled = true;
            cbbSP.Enabled = true;
            btnSua.Enabled = false;
            Exe("UPDATE KHACHHANG SET Tenkh = N'" + txtTenKhachHang.Text + "', CMND = N'" + txtCMND.Text + "', Sdt = N'" + txtSDT.Text + "', gioitinh = N'"+lblGioitinh+"'" );

        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenKhachHang.Text = dgvKhachhang.CurrentRow.Cells[0].Value.ToString();
            txtCMND.Text = dgvKhachhang.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachhang.CurrentRow.Cells[2].Value.ToString();
            lblGioitinh.Text = dgvKhachhang.CurrentRow.Cells[3].Value.ToString();
            cbbSP.Text = dgvKhachhang.CurrentRow.Cells[5].Value.ToString();

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
            // TODO: This line of code loads data into the 'qlyphongtroDataSet.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.qlyphongtroDataSet.KHACHHANG);

        }
    }

        
    
}
