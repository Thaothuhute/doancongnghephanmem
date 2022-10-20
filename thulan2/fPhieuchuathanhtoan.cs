using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thulan2.Model;

namespace thulan2
{
    public partial class fPhieuchuathanhtoan : Form
    {
        public fPhieuchuathanhtoan()
        {
            InitializeComponent();
        }

        private void fPhieuchuathanhtoan_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            using (phongtroDBContext context = new phongtroDBContext())
            {
                List<HOPDONG> hds = context.HOPDONGs.Where(p =>p.Trangthai == 1).ToList();
                List<PHIEUTHANHTOAN> pttoans = context.PHIEUTHANHTOANs.ToList().Where(p => p.Trangthai == 0).ToList();
                List<PHTHANHTOANREP> phttoanres = new List<PHTHANHTOANREP>();
                List<CTDICHVU> ctdichvus = context.CTDICHVUs.ToList();

                foreach (PHIEUTHANHTOAN pHTHANhtoan in pttoans)
                {
                    PHTHANHTOANREP pHTHANHTOANREP = new PHTHANHTOANREP();
                    pHTHANHTOANREP.Sop = ctdichvus.FirstOrDefault(p => p.PHIEUTHANHTOAN.Maptt == pHTHANhtoan.Maptt).Sop;
                    pHTHANHTOANREP.Ngaylapphieu = pHTHANhtoan.Ngaylapphieu;
                    pHTHANHTOANREP.Tongtien = float.Parse(ctdichvus.FirstOrDefault(p => p.PHIEUTHANHTOAN.Maptt == pHTHANhtoan.Maptt).Soluongdung.ToString()) * 3.5f + 3000;
                    string sop = ctdichvus.FirstOrDefault(p => p.PHIEUTHANHTOAN.Maptt == pHTHANhtoan.Maptt).Sop;
                    pHTHANHTOANREP.TenKH = hds.FirstOrDefault(p => p.Sop == sop).KHACHHANG.Tenkh;
                    phttoanres.Add(pHTHANHTOANREP);
                }

                var reportDataSource = new ReportDataSource("DataThanhtoan", phttoanres);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();


            }
        }
    }
}
