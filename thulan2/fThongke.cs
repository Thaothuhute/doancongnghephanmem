using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2;
using thulan2.Model;


namespace quanliphongtro
{
    public partial class fThongke : Form
    {
        public fThongke()
        {
            InitializeComponent();
            loaddata();
            resetcontrol();
            setautocomplete();
        }

        private void loaddata()
        {
            try
            {
                using (phongtroDBContext context = new phongtroDBContext())
                {
                    List<CTDICHVU> lisctdc = (from p in context.CTDICHVUs.ToList()
                                              //where p.Madv == "N'DV1'"
                                              select p).ToList();
                    List<CTDICHVU> lisctdcdien = new List<CTDICHVU>();
                    foreach (CTDICHVU ite in lisctdc)
                    {
                        string s = ite.DICHVU.Tendv.ToString();
                        if (s == "Dien")
                        {
                            lisctdcdien.Add(ite);
                        }
                    }
                    List<HOPDONG> lishd = context.HOPDONGs.ToList();
                    List<PHONG> lispo = context.PHONGs.ToList();
                    Filldatagrid(lisctdcdien, lishd);
                    loadccbPhong(lispo);

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetcontrol()
        {
            txtTenkhach.Enabled = true;
            txtsothang.Enabled = true;
            txtTenkhach.Clear();
            txtSop.Clear();
            btnTimp.Enabled = false;
            flpTuongtacxuat.Enabled = false;
            flpTuongtactim.Enabled = true;
            panel1.Enabled = true;
            btnReport.Enabled = true;
            btnHuyp.Enabled = false;
            btnXuatdgv.Enabled = false;
            txtTenkhach.Enabled = true;
            txtSop.Enabled = true;
            txtTenkhach.Clear();
            txtSop.Clear();
            rdbThang.Checked = true;
            btnXuatdgv.Enabled = true;
        }
        private void Filldatagrid(List<CTDICHVU> ptt, List<HOPDONG> lhd)
        {
            dgvThongkehd.AllowUserToAddRows = false;
           
            dgvThongkehd.Rows.Clear();
            foreach (CTDICHVU item in ptt)
            {
                int index = dgvThongkehd.Rows.Add();
              
                dgvThongkehd.Rows[index].Cells[0].Value = lhd.FirstOrDefault(p => p.PHONG.Sop == item.Sop).KHACHHANG.Tenkh;

                dgvThongkehd.Rows[index].Cells[1].Value = item.PHIEUTHANHTOAN.Ngaylapphieu.ToString();
                dgvThongkehd.Rows[index].Cells[2].Value = item.Sop.ToString();
                dgvThongkehd.Rows[index].Cells[3].Value = "3000000";
                dgvThongkehd.Rows[index].Cells[4].Value = item.Soluongdung * item.DICHVU.Gia;
                dgvThongkehd.Rows[index].Cells[5].Value = 60000;
                dgvThongkehd.Rows[index].Cells[6].Value = item.PHIEUTHANHTOAN.Tongtiendichvu + 3000000;
                if (item.PHIEUTHANHTOAN.Trangthai is 1)
                {
                    dgvThongkehd.Rows[index].Cells[7].Value = "Da thanh toan";

                }
                else
                {
                    dgvThongkehd.Rows[index].Cells[7].Value = "Chua thanh toan";

                }

            }
            //}

        }

        private void txtTenkhach_TextChanged(object sender, EventArgs e)
        {
            
            if (txtTenkhach.Text != "")
            {
                txtSop.Enabled = false;
                btnHuyp.Enabled = true;
                btnTimp.Enabled = true;
            }
            else
            {
                txtSop.Enabled = Enabled;
                btnHuyp.Enabled = false;
                btnTimp.Enabled = false;
            }
            
        }

        private void txtSop_TextChanged(object sender, EventArgs e)
        {
            if (txtSop.Text != "")
            {
                txtTenkhach.Enabled = false;
                btnHuyp.Enabled = true;
                btnTimp.Enabled = true;
            }
            else
            {
                txtTenkhach.Enabled = true;
                btnHuyp.Enabled = false;
                btnTimp.Enabled = false;
            }
        }
        private bool checkname(string name)
        {
            var withoutSpecial = new string(name.Where(c => Char.IsLetterOrDigit(c)
                                            || Char.IsWhiteSpace(c)).ToArray());

            if (name != withoutSpecial)
            {
                return true;
            }
            return false;
        }

        private void btnTimp_Click(object sender, EventArgs e)
        {
            if (!checkname(txtTenkhach.Text)) 
            {
                if (txtTenkhach.Text != "")
                {
                    try
                    {

                        using (phongtroDBContext context = new phongtroDBContext())
                        {
                            KHACHHANG kh = context.KHACHHANGs.FirstOrDefault(p => p.Tenkh == txtTenkhach.Text);
                            if (kh != null)
                            {
                                List<HOPDONG> lishd = (from p in context.HOPDONGs.ToList()
                                                       where p.KHACHHANG.Tenkh.StartsWith(txtTenkhach.Text)
                                                       select p).ToList();

                                List<CTDICHVU> lisctdc = (from p in context.CTDICHVUs.ToList()
                                                          where p.PHONG.Sop == lishd.First().PHONG.Sop
                                                          select p).ToList();

                                List<CTDICHVU> lisctdcdien = new List<CTDICHVU>();
                                foreach (CTDICHVU ite in lisctdc)
                                {
                                    string s = ite.DICHVU.Tendv.ToString();
                                    if (s == "Dien")
                                    {
                                        lisctdcdien.Add(ite);
                                    }
                                }
                                Filldatagrid(lisctdcdien, lishd);

                            }
                            else
                            {
                                MessageBox.Show("khong tim thay");
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {

                        using (phongtroDBContext context = new phongtroDBContext())
                        {
                            HOPDONG po = context.HOPDONGs.FirstOrDefault(p => p.PHONG.Sop == txtSop.Text);
                            CTDICHVU po2 = context.CTDICHVUs.FirstOrDefault(p => p.PHONG.Sop == txtSop.Text);
                            if (po != null && po2 != null)
                            {
                                List<HOPDONG> lishd = (from p in context.HOPDONGs.ToList()
                                                       where p.PHONG.Sop.StartsWith(txtSop.Text)
                                                       select p).ToList();

                                List<CTDICHVU> lisctdc = (from p in context.CTDICHVUs.ToList()
                                                          where p.PHONG.Sop.StartsWith(txtSop.Text)
                                                          select p).ToList();

                                List<CTDICHVU> lisctdcdien = new List<CTDICHVU>();
                                foreach (CTDICHVU ite in lisctdc)
                                {
                                    string s = ite.DICHVU.Tendv.ToString();
                                    if (s == "Dien")
                                    {
                                        lisctdcdien.Add(ite);
                                    }
                                }
                                Filldatagrid(lisctdcdien, lishd);

                            }
                            else
                            {
                                MessageBox.Show("khong tim thay");
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("thong tin nhap khong hop le");
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel16.Enabled = true;
            flpTuongtacxuat.Enabled = true;
            flpTuongtactim.Enabled = false;
        }

        private void btnThoatrpt_Click(object sender, EventArgs e)
        {
            resetcontrol();
        }
        private void setautocomplete()
        {
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            txtTenkhach.AutoCompleteMode = AutoCompleteMode.Append;
            txtTenkhach.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtSop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSop.AutoCompleteSource = AutoCompleteSource.CustomSource;
            using (phongtroDBContext context = new phongtroDBContext())
            {
                List<KHACHHANG> lkh = context.KHACHHANGs.ToList();  
                List<PHONG> lpo = context.PHONGs.ToList();

                foreach(KHACHHANG kh in lkh)
                {
                    auto1.Add(kh.Tenkh);
                }
                txtTenkhach.AutoCompleteCustomSource = auto1;

                foreach (PHONG po in lpo)
                {
                    auto1.Add(po.Sop);
                }
                txtTenkhach.AutoCompleteCustomSource = auto1;
                txtSop.AutoCompleteCustomSource = auto1;
            }
        }
        private void btnXuatdgvall_Click(object sender, EventArgs e)
        {
            loaddata();
            resetcontrol();
        }

        private void dgvThongkehd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int emp = e.RowIndex;
            txtTenkhach.Text = dgvThongkehd.Rows[emp].Cells[0].Value.ToString();
            dtpNgaylap.Value = DateTime.Parse(dgvThongkehd.Rows[emp].Cells[1].Value.ToString());
            txtSop.Text = dgvThongkehd.Rows[emp].Cells[2].Value.ToString();
            string cccd;
            int sothang;

            
            using (phongtroDBContext context = new phongtroDBContext())
            {
                cccd = context.KHACHHANGs.FirstOrDefault(p => p.Tenkh == txtTenkhach.Text).CMND;
                HOPDONG hd = context.HOPDONGs.FirstOrDefault(p => p.KHACHHANG.CMND == cccd && p.Trangthai == 1);
                dtpHan.Value =DateTime.Parse(hd.Ngayhethan.ToString());
                txtsothang.Text = (DateTime.Now.Month - hd.Ngaylapphieu.Value.Month).ToString();


            }
            txtDien.Text = (float.Parse(dgvThongkehd.Rows[emp].Cells[4].Value.ToString()) / 3.5f).ToString();
            txtCccd.Text = cccd;
            string thanhtoan = dgvThongkehd.Rows[emp].Cells[7].Value.ToString();
            if (thanhtoan == "Chua thanh toan")
            {
                rdbChuathanhtoan.Checked = true;
            }
            else
            {
                rdbDathanhtoan.Checked = true;
            }
            txtTiendien.Text = dgvThongkehd.Rows[emp].Cells[4].Value.ToString();
            txtTiennha.Text = "3000000";
            txtTiennuoc.Text = dgvThongkehd.Rows[emp].Cells[5].Value.ToString();




        }

        private void rdbPhong_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbPhong.Checked == true)
            {
                cbbPhong.Enabled = true;
                cbbThang.Text = "";
                cbbThang.Enabled = false;
            }
            else
            {
                cbbThang.Enabled = true;
                cbbPhong.Text = "";
                cbbPhong.Enabled = false;
            }
        }

        private void loadccbPhong(List<PHONG> po)
        {
            cbbPhong.Items.Clear();
            cbbPhong.DataSource = po;
            cbbPhong.ValueMember = "Sop";
            cbbPhong.DisplayMember = "Sop";
        }

        private void doanhthu()
        {
            
            float dthu = 0;
            txtTonghoadon.Text = (dgvThongkehd.RowCount - 1).ToString();
            for(int  i = 0; i < dgvThongkehd.RowCount -1 ; i++)
            {
                dthu += float.Parse(dgvThongkehd.Rows[i].Cells[6].Value.ToString());
            }
            txtTongdoanhthu.Text = dthu.ToString() + ".000";


        }
        private void btnXuatrpt_Click(object sender, EventArgs e)
        {
            if (rdbThang.Checked == true)
            {
                try
                {

                    using (phongtroDBContext context = new phongtroDBContext())
                    {
                       
                        int thang = int.Parse(cbbThang.Text);

                        PHIEUTHANHTOAN tt = context.PHIEUTHANHTOANs.FirstOrDefault(p => p.Ngaylapphieu.Value.Month == thang);
                        if (tt != null)
                        {
                            List<HOPDONG> lishd = context.HOPDONGs.ToList();


                            List<CTDICHVU> lisctdc = (from p in context.CTDICHVUs.ToList()
                                                      where p.PHIEUTHANHTOAN.Ngaylapphieu.Value.Month == thang
                                                      select p).ToList();

                            List<CTDICHVU> lisctdcdien = new List<CTDICHVU>();
                            foreach (CTDICHVU ite in lisctdc)
                            {
                                string s = ite.DICHVU.Tendv.ToString();
                                if (s == "Dien")
                                {
                                    lisctdcdien.Add(ite);
                                }
                            }
                            Filldatagrid(lisctdcdien, lishd);

                            doanhthu();

                        }
                        else
                        {
                            MessageBox.Show("khong tim thay");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {

                    using (phongtroDBContext context = new phongtroDBContext())
                    {
                        string sop = cbbPhong.Text;
                        HOPDONG po = context.HOPDONGs.FirstOrDefault(p => p.PHONG.Sop == sop);
                        CTDICHVU po2 = context.CTDICHVUs.FirstOrDefault(p => p.PHONG.Sop == sop);
                        if (po != null && po2 != null)
                        {
                            List<HOPDONG> lishd = (from p in context.HOPDONGs.ToList()
                                                   where p.PHONG.Sop.StartsWith(sop)
                                                   select p).ToList();

                            List<CTDICHVU> lisctdc = (from p in context.CTDICHVUs.ToList()
                                                      where p.PHONG.Sop.StartsWith(sop)
                                                      select p).ToList();

                            List<CTDICHVU> lisctdcdien = new List<CTDICHVU>();
                            foreach (CTDICHVU ite in lisctdc)
                            {
                                string s = ite.DICHVU.Tendv.ToString();
                                if (s == "Dien")
                                {
                                    lisctdcdien.Add(ite);
                                }
                            }
                            Filldatagrid(lisctdcdien, lishd);
                           
                            doanhthu();

                        }
                        else
                        {
                            MessageBox.Show("khong tim thay");
                        }


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnXuatallrpt_Click(object sender, EventArgs e)
        {
            loaddata();
            resetcontrol();
        }

        private void phòngỞLâuNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fReportThanhtoan f = new fReportThanhtoan();
            f.ShowDialog();
            
        }

        private void phòngCóĐiệnNướcBấtThườngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPhieuchuathanhtoan f = new fPhieuchuathanhtoan();
            f.ShowDialog();
        }
        private void ToExcel(DataGridView dtg , string filename)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worbookl;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                worbookl = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)worbookl.Sheets["Sheet1"];

                worksheet.Name = "Bao cao";

                for(int  i= 0;i< dtg.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dtg.Columns[i].HeaderText;
                }
                for(int i =0;i < dtg.RowCount; i++)
                {
                    for(int j = 0;j < dtg.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dtg.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worbookl.SaveAs(filename);

                worbookl.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                worbookl = null;
                worksheet = null;
            }
        }
        private void btnXuatdgv_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel 97-2007 Workbook(*.xls)|*.xls|Excel Workbook(*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                ToExcel(dgvThongkehd, saveFileDialog1.FileName);
              
            }
        }
    }
    
}
