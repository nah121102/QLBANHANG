using Microsoft.Reporting.WinForms;
using QLBANHANG.Model1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBANHANG
{
    public partial class InHoaDon : Form
    {
        string hd = "";
        public InHoaDon(string hd)
        {
            InitializeComponent();
            this.hd = hd;
            
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonContext context = new HoaDonContext();
            List<tb_CTHD> listCTHD = context.tb_CTHD.Where(s => s.MaHD == hd).ToList(); //l y t t c sv
            List<reportCLass> listReport = new List<reportCLass>();
            foreach (tb_CTHD i in listCTHD)
            {
                reportCLass temp = new reportCLass();
                temp.MaHD = i.MaHD;
                temp.TenHang = i.tb_HangHoa.TenHang;
                temp.SoLuong = i.SoLuong;
                temp.DonGia = i.DonGia;

                listReport.Add(temp);
            }
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            var reportDataSource = new ReportDataSource("DataSet1", listReport);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
